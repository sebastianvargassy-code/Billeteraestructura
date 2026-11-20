using System;
using System.Data.SQLite;
using System.IO;
using BilleteraCajaArequipa.Estructuras;
using BilleteraCajaArequipa.Modelos;

namespace BilleteraCajaArequipa.Datos
{
    public class ConexionSQLite
    {
        public string rutaArchivo;
        public string cadenaConexion;

        public ConexionSQLite()
        {
            string carpetaDatos = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Datos"));
            if (Directory.Exists(carpetaDatos))
            {
                rutaArchivo = Path.Combine(carpetaDatos, "billetera.db");
            }
            else
            {
                rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "billetera.db");
            }

            cadenaConexion = "Data Source=" + rutaArchivo + ";Version=3;";
            CrearTablas();
        }

        private void CrearTablas()
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();

                string sqlCuenta =
                    "CREATE TABLE IF NOT EXISTS Cuenta (" +
                    "Id INTEGER PRIMARY KEY, " +
                    "Titular TEXT, " +
                    "Celular TEXT, " +
                    "Saldo REAL, " +
                    "Contador INTEGER);";

                string sqlOperaciones =
                    "CREATE TABLE IF NOT EXISTS Operaciones (" +
                    "Orden INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "Codigo TEXT UNIQUE, " +
                    "Tipo TEXT, " +
                    "Monto REAL, " +
                    "Origen TEXT, " +
                    "Destino TEXT, " +
                    "Fecha TEXT, " +
                    "Estado TEXT);";

                string sqlEnlaces =
                    "CREATE TABLE IF NOT EXISTS EnlacesAgencias (" +
                    "Origen INTEGER, " +
                    "Destino INTEGER, " +
                    "Peso INTEGER, " +
                    "PRIMARY KEY (Origen, Destino));";

                using (SQLiteCommand cmd = new SQLiteCommand(sqlCuenta, cn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(sqlOperaciones, cn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(sqlEnlaces, cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ExisteCuenta()
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Cuenta WHERE Id = 1;", cn))
                {
                    long total = (long)cmd.ExecuteScalar();
                    return total > 0;
                }
            }
        }

        public void GuardarCuenta(string titular, string celular, double saldo, int contador)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                string sql =
                    "INSERT OR REPLACE INTO Cuenta (Id, Titular, Celular, Saldo, Contador) " +
                    "VALUES (1, @titular, @celular, @saldo, @contador);";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@titular", titular);
                    cmd.Parameters.AddWithValue("@celular", celular);
                    cmd.Parameters.AddWithValue("@saldo", saldo);
                    cmd.Parameters.AddWithValue("@contador", contador);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CargarCuenta(Billetera b)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT Titular, Celular, Saldo, Contador FROM Cuenta WHERE Id = 1;", cn))
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        b.titular = dr.GetString(0);
                        b.celular = dr.GetString(1);
                        b.saldo = dr.GetDouble(2);
                        b.contador = dr.GetInt32(3);
                    }
                }
            }
        }

        public void InsertarOperacion(Operacion op)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                string sql =
                    "INSERT OR REPLACE INTO Operaciones (Codigo, Tipo, Monto, Origen, Destino, Fecha, Estado) " +
                    "VALUES (@codigo, @tipo, @monto, @origen, @destino, @fecha, @estado);";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@codigo", op.codigo);
                    cmd.Parameters.AddWithValue("@tipo", op.tipo);
                    cmd.Parameters.AddWithValue("@monto", op.monto);
                    cmd.Parameters.AddWithValue("@origen", op.origen);
                    cmd.Parameters.AddWithValue("@destino", op.destino);
                    cmd.Parameters.AddWithValue("@fecha", op.fecha);
                    cmd.Parameters.AddWithValue("@estado", op.estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarEstadoOperacion(string codigo, string nuevoEstado)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                string sql = "UPDATE Operaciones SET Estado = @estado WHERE Codigo = @codigo;";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarOperacion(string codigo)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Operaciones WHERE Codigo = @codigo;", cn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPorEstado(string estado)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Operaciones WHERE Estado = @estado;", cn))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CargarOperacionesEnEstructuras(Billetera b)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                string sql = "SELECT Codigo, Tipo, Monto, Origen, Destino, Fecha, Estado FROM Operaciones ORDER BY Orden ASC;";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cn))
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Operacion op = new Operacion();
                        op.codigo = dr.GetString(0);
                        op.tipo = dr.GetString(1);
                        op.monto = dr.GetDouble(2);
                        op.origen = dr.GetString(3);
                        op.destino = dr.GetString(4);
                        op.fecha = dr.GetString(5);
                        op.estado = dr.GetString(6);

                        if (op.estado == "Procesada")
                        {
                            b.listaSimple.Adicionar(op);
                            b.listaDoble.Adicionar(op);
                            b.pila.Poner(op);
                            b.arbol.Insertar(op);
                        }
                        else if (op.estado == "En Cola")
                        {
                            b.cola.Adicionar(op);
                        }
                        else if (op.estado == "Pendiente")
                        {
                            b.listaCircular.Adicionar(op);
                        }
                    }
                }
            }
        }

        public void GuardarEnlacesGrafo(GrafoAgencias grafo)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                using (SQLiteCommand cmdDel = new SQLiteCommand("DELETE FROM EnlacesAgencias;", cn))
                {
                    cmdDel.ExecuteNonQuery();
                }

                for (int i = 0; i < grafo.n; i++)
                {
                    for (int j = i + 1; j < grafo.n; j++)
                    {
                        if (grafo.matriz[i, j] < GrafoAgencias.INF)
                        {
                            using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO EnlacesAgencias (Origen, Destino, Peso) VALUES (@o, @d, @p);", cn))
                            {
                                cmd.Parameters.AddWithValue("@o", i);
                                cmd.Parameters.AddWithValue("@d", j);
                                cmd.Parameters.AddWithValue("@p", grafo.matriz[i, j]);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        public bool CargarEnlacesGrafo(GrafoAgencias grafo)
        {
            using (SQLiteConnection cn = new SQLiteConnection(cadenaConexion))
            {
                cn.Open();
                using (SQLiteCommand cmdCount = new SQLiteCommand("SELECT COUNT(*) FROM EnlacesAgencias;", cn))
                {
                    long total = (long)cmdCount.ExecuteScalar();
                    if (total == 0)
                    {
                        return false;
                    }
                }

                using (SQLiteCommand cmd = new SQLiteCommand("SELECT Origen, Destino, Peso FROM EnlacesAgencias;", cn))
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int o = dr.GetInt32(0);
                        int d = dr.GetInt32(1);
                        int p = dr.GetInt32(2);
                        grafo.AgregarEnlace(o, d, p);
                    }
                }
                return true;
            }
        }
    }
}
