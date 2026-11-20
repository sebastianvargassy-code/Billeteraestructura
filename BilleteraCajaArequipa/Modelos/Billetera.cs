using System;
using BilleteraCajaArequipa.Datos;
using BilleteraCajaArequipa.Estructuras;
using BilleteraCajaArequipa.Nodos;

namespace BilleteraCajaArequipa.Modelos
{
    public class Billetera
    {
        public string titular;
        public string celular;
        public double saldo;
        public int contador;

        public ConexionSQLite db;

        public ListaSimpleOperaciones listaSimple;
        public ListaDobleOperaciones listaDoble;
        public ListaCircularReintentos listaCircular;
        public PilaOperaciones pila;
        public ColaOperaciones cola;
        public ArbolOperaciones arbol;
        public GrafoAgencias grafo;

        public Billetera()
        {
            titular = "Sebastián Gómez";
            celular = "987 654 321";
            saldo = 1000.00;
            contador = 200;

            listaSimple = new ListaSimpleOperaciones();
            listaDoble = new ListaDobleOperaciones();
            listaCircular = new ListaCircularReintentos();
            pila = new PilaOperaciones();
            cola = new ColaOperaciones();
            arbol = new ArbolOperaciones();

            db = new ConexionSQLite();

            if (!db.ExisteCuenta())
            {
                CargarDatosIniciales();
                RestaurarRedAgencias();
            }
            else
            {
                db.CargarCuenta(this);
                db.CargarOperacionesEnEstructuras(this);
                IniciarNodosGrafo();
                if (!db.CargarEnlacesGrafo(grafo))
                {
                    RestaurarRedAgencias();
                }
            }
        }

        public Operacion CrearOperacion(string codigo, string tipo, double monto, string destino, string estado)
        {
            Operacion op = new Operacion();
            op.codigo = codigo;
            op.tipo = tipo;
            op.monto = monto;
            op.origen = titular;
            op.destino = destino;
            op.fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            op.estado = estado;
            return op;
        }

        public void RegistrarMovimiento(string codigo, string tipo, string destino, double monto)
        {
            Operacion nueva = CrearOperacion(codigo, tipo, monto, destino, "Procesada");
            listaSimple.Adicionar(nueva);
            listaDoble.Adicionar(nueva);
            pila.Poner(nueva);
            arbol.Insertar(nueva);
            db.InsertarOperacion(nueva);
        }

        private void CargarDatosIniciales()
        {
            RegistrarMovimiento("150", "Abono", "Cuenta Principal", 500.00);
            RegistrarMovimiento("120", "Transferencia", "Ana Torres", 80.00);
            RegistrarMovimiento("180", "Transferencia", "Carlos Mendoza", 120.00);
            RegistrarMovimiento("110", "Pago QR", "Bodega Central", 35.00);
            RegistrarMovimiento("190", "Transferencia", "María Ríos", 65.00);

            Operacion c1 = CrearOperacion("210", "Transferencia", 95.00, "Roberto Paredes", "En Cola");
            Operacion c2 = CrearOperacion("220", "Transferencia", 60.00, "María Ríos", "En Cola");
            cola.Adicionar(c1);
            cola.Adicionar(c2);
            db.InsertarOperacion(c1);
            db.InsertarOperacion(c2);

            Operacion r1 = CrearOperacion("310", "Transferencia", 45.00, "Agencia Rural Chivay", "Pendiente");
            Operacion r2 = CrearOperacion("320", "Pago QR", 30.00, "Agencia Rural Cotahuasi", "Pendiente");
            listaCircular.Adicionar(r1);
            listaCircular.Adicionar(r2);
            db.InsertarOperacion(r1);
            db.InsertarOperacion(r2);

            contador = 320;
            db.GuardarCuenta(titular, celular, saldo, contador);
        }

        private void IniciarNodosGrafo()
        {
            grafo = new GrafoAgencias(6);
            grafo.agencias[0] = "Sede Central";
            grafo.agencias[1] = "Cayma";
            grafo.agencias[2] = "Cerro Colorado";
            grafo.agencias[3] = "Rural Chivay";
            grafo.agencias[4] = "Rural Camaná";
            grafo.agencias[5] = "Rural Cotahuasi";
        }

        public void RestaurarRedAgencias()
        {
            IniciarNodosGrafo();
            grafo.AgregarEnlace(0, 1, 12);
            grafo.AgregarEnlace(0, 2, 15);
            grafo.AgregarEnlace(1, 2, 10);
            grafo.AgregarEnlace(1, 3, 45);
            grafo.AgregarEnlace(2, 4, 38);
            grafo.AgregarEnlace(2, 3, 52);
            grafo.AgregarEnlace(3, 5, 55);
            grafo.AgregarEnlace(4, 5, 48);
            db.GuardarEnlacesGrafo(grafo);
        }

        public void CortarEnlaceAgencias(int origen, int destino)
        {
            grafo.CortarEnlace(origen, destino);
            db.GuardarEnlacesGrafo(grafo);
        }

        public void Recargar(double monto)
        {
            saldo = saldo + monto;
            contador = contador + 10;
            RegistrarMovimiento(contador.ToString(), "Abono", "Cuenta Principal", monto);
            db.GuardarCuenta(titular, celular, saldo, contador);
        }

        public bool Transferir(string destino, double monto)
        {
            if (monto > saldo)
            {
                return false;
            }

            saldo = saldo - monto;
            contador = contador + 10;
            RegistrarMovimiento(contador.ToString(), "Transferencia", destino, monto);
            db.GuardarCuenta(titular, celular, saldo, contador);
            return true;
        }

        public void Encolar(string destino, double monto)
        {
            contador = contador + 10;
            Operacion op = CrearOperacion(contador.ToString(), "Transferencia", monto, destino, "En Cola");
            cola.Adicionar(op);
            db.InsertarOperacion(op);
            db.GuardarCuenta(titular, celular, saldo, contador);
        }

        public void AgregarReintento(string destino, double monto)
        {
            contador = contador + 10;
            Operacion op = CrearOperacion(contador.ToString(), "Transferencia", monto, destino, "Pendiente");
            listaCircular.Adicionar(op);
            db.InsertarOperacion(op);
            db.GuardarCuenta(titular, celular, saldo, contador);
        }

        public Operacion RevertirUltimo()
        {
            if (pila.EstaVacia())
            {
                return null;
            }

            Operacion ultima = pila.Sacar();
            if (ultima.tipo == "Abono")
            {
                saldo = saldo - ultima.monto;
            }
            else
            {
                saldo = saldo + ultima.monto;
            }

            EliminarDeRegistros(ultima.codigo);
            db.GuardarCuenta(titular, celular, saldo, contador);
            return ultima;
        }

        public void EliminarDeRegistros(string codigo)
        {
            NodoSimple ns = listaSimple.Buscar(codigo);
            if (ns != null)
            {
                listaSimple.Eliminar(ns);
            }

            NodoDoble nd = listaDoble.Buscar(codigo);
            if (nd != null)
            {
                listaDoble.Eliminar(nd);
            }

            arbol.Eliminar(codigo);
            db.EliminarOperacion(codigo);
        }

        // Retorna: 1 = procesada, 0 = cola vacía, -1 = sin saldo (pasó a reintentos)
        public int AtenderPrimeroCola(out Operacion op)
        {
            op = null;
            if (cola.EstaVacia())
            {
                return 0;
            }

            op = cola.Atender();
            if (saldo < op.monto)
            {
                op.estado = "Pendiente";
                listaCircular.Adicionar(op);
                db.ActualizarEstadoOperacion(op.codigo, "Pendiente");
                return -1;
            }

            saldo = saldo - op.monto;
            op.estado = "Procesada";
            listaSimple.Adicionar(op);
            listaDoble.Adicionar(op);
            pila.Poner(op);
            arbol.Insertar(op);

            db.ActualizarEstadoOperacion(op.codigo, "Procesada");
            db.GuardarCuenta(titular, celular, saldo, contador);
            return 1;
        }

        public void VaciarCola()
        {
            cola.frente = null;
            cola.final = null;
            db.EliminarPorEstado("En Cola");
        }

        public bool CompletarReintento(string codigo)
        {
            NodoCircular p = listaCircular.Buscar(codigo);
            if (p == null || saldo < p.info.monto)
            {
                return false;
            }

            Operacion op = p.info;
            listaCircular.Eliminar(p);
            saldo = saldo - op.monto;
            op.estado = "Procesada";

            listaSimple.Adicionar(op);
            listaDoble.Adicionar(op);
            pila.Poner(op);
            arbol.Insertar(op);

            db.ActualizarEstadoOperacion(op.codigo, "Procesada");
            db.GuardarCuenta(titular, celular, saldo, contador);
            return true;
        }

        public void EliminarReintento(string codigo)
        {
            NodoCircular p = listaCircular.Buscar(codigo);
            if (p != null)
            {
                listaCircular.Eliminar(p);
                db.EliminarOperacion(codigo);
            }
        }
    }
}
