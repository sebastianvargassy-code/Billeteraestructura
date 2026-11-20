using System;
using System.Windows.Forms;
using BilleteraCajaArequipa.Estructuras;
using BilleteraCajaArequipa.Modelos;
using BilleteraCajaArequipa.Nodos;

namespace BilleteraCajaArequipa.Formularios
{
    public partial class FormPrincipal : Form
    {
        Billetera miBilletera;
        NodoDoble actualHistorial;
        bool ordenInverso;
        string recorridoArbol;

        public FormPrincipal()
        {
            InitializeComponent();
            miBilletera = new Billetera();
            actualHistorial = miBilletera.listaDoble.fin;
            ordenInverso = false;
            recorridoArbol = "InOrden";

            CargarCombosGrafo();
            MostrarTodo();
        }

        private double LeerMonto(string texto)
        {
            try
            {
                return Convert.ToDouble(texto);
            }
            catch
            {
                return -1;
            }
        }

        private string Formatear(Operacion op)
        {
            return op.codigo + " | " + op.tipo + " | " + op.destino + " | S/ " + op.monto.ToString("0.00") + " | " + op.estado;
        }

        private string ObtenerCodigo(ListBox lista)
        {
            if (lista.SelectedItem == null)
            {
                return "";
            }
            string texto = lista.SelectedItem.ToString();
            int pos = texto.IndexOf(" |");
            if (pos > 0)
            {
                return texto.Substring(0, pos);
            }
            return "";
        }

        private void MostrarTodo()
        {
            lblTitular.Text = miBilletera.titular;
            lblCuenta.Text = "Nro. " + miBilletera.celular;
            lblSaldoActual.Text = "S/ " + miBilletera.saldo.ToString("0.00");

            MostrarPila();
            MostrarArbol();
            MostrarHistorial();
            MostrarActual();
            MostrarCola();
            MostrarCircular();
            MostrarEnlaces();
        }

        private void MostrarPila()
        {
            lstPila.Items.Clear();
            NodoSimple p = miBilletera.pila.cima;
            while (p != null)
            {
                lstPila.Items.Add(Formatear(p.info));
                p = p.sgte;
            }
        }

        private void MostrarArbol()
        {
            lstArbol.Items.Clear();
            if (recorridoArbol == "PreOrden")
            {
                RecorrerPreOrden(miBilletera.arbol.raiz);
            }
            else if (recorridoArbol == "PostOrden")
            {
                RecorrerPostOrden(miBilletera.arbol.raiz);
            }
            else
            {
                RecorrerInOrden(miBilletera.arbol.raiz);
            }
        }

        private void RecorrerInOrden(NodoArbol p)
        {
            if (p != null)
            {
                RecorrerInOrden(p.izq);
                lstArbol.Items.Add(Formatear(p.info));
                RecorrerInOrden(p.der);
            }
        }

        private void RecorrerPreOrden(NodoArbol p)
        {
            if (p != null)
            {
                lstArbol.Items.Add(Formatear(p.info));
                RecorrerPreOrden(p.izq);
                RecorrerPreOrden(p.der);
            }
        }

        private void RecorrerPostOrden(NodoArbol p)
        {
            if (p != null)
            {
                RecorrerPostOrden(p.izq);
                RecorrerPostOrden(p.der);
                lstArbol.Items.Add(Formatear(p.info));
            }
        }

        private void MostrarHistorial()
        {
            lstHistorial.Items.Clear();
            if (!ordenInverso)
            {
                NodoDoble p = miBilletera.listaDoble.inicio;
                while (p != null)
                {
                    lstHistorial.Items.Add(Formatear(p.info));
                    p = p.sgte;
                }
            }
            else
            {
                NodoDoble p = miBilletera.listaDoble.fin;
                while (p != null)
                {
                    lstHistorial.Items.Add(Formatear(p.info));
                    p = p.ant;
                }
            }
        }

        private void MostrarActual()
        {
            if (actualHistorial != null)
            {
                lblActual.Text = "Actual: " + Formatear(actualHistorial.info);
            }
            else
            {
                lblActual.Text = "Actual: Sin movimientos";
            }
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            NodoSimple p = miBilletera.cola.frente;
            while (p != null)
            {
                lstCola.Items.Add(Formatear(p.info));
                p = p.sgte;
            }
        }

        private void MostrarCircular()
        {
            lstCircular.Items.Clear();
            if (miBilletera.listaCircular.inicio == null)
            {
                return;
            }

            NodoCircular p = miBilletera.listaCircular.inicio;
            do
            {
                lstCircular.Items.Add(Formatear(p.info));
                p = p.sgte;
            } while (p != miBilletera.listaCircular.inicio);
        }

        private void CargarCombosGrafo()
        {
            cmbOrigen.Items.Clear();
            cmbDestinoG.Items.Clear();
            for (int i = 0; i < miBilletera.grafo.n; i++)
            {
                cmbOrigen.Items.Add(miBilletera.grafo.agencias[i]);
                cmbDestinoG.Items.Add(miBilletera.grafo.agencias[i]);
            }
            cmbOrigen.SelectedIndex = 0;
            cmbDestinoG.SelectedIndex = miBilletera.grafo.n - 1;
        }

        private void MostrarEnlaces()
        {
            lstMatriz.Items.Clear();
            for (int i = 0; i < miBilletera.grafo.n; i++)
            {
                for (int j = i + 1; j < miBilletera.grafo.n; j++)
                {
                    int peso = miBilletera.grafo.matriz[i, j];
                    if (peso < GrafoAgencias.INF)
                    {
                        lstMatriz.Items.Add(miBilletera.grafo.agencias[i] + " <-> " + miBilletera.grafo.agencias[j] + " : " + peso + " ms");
                    }
                }
            }
        }

        // Validación de campos obligatorios del destinatario

        private void txtCelularDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidarDestinatario(out string destinatarioCompleto)
        {
            destinatarioCompleto = "";
            string nombre = txtDestino.Text.Trim();
            string celular = txtCelularDestino.Text.Trim();

            if (nombre == "")
            {
                MessageBox.Show("El nombre del destinatario es obligatorio.");
                txtDestino.Focus();
                return false;
            }

            if (nombre.Length < 3)
            {
                MessageBox.Show("Ingrese un nombre de destinatario válido (mínimo 3 letras).");
                txtDestino.Focus();
                return false;
            }

            for (int i = 0; i < nombre.Length; i++)
            {
                if (char.IsDigit(nombre[i]))
                {
                    MessageBox.Show("El nombre del destinatario no puede contener números.");
                    txtDestino.Focus();
                    return false;
                }
            }

            if (celular == "")
            {
                MessageBox.Show("El celular del destinatario es obligatorio.");
                txtCelularDestino.Focus();
                return false;
            }

            if (celular.Length != 9 || celular[0] != '9')
            {
                MessageBox.Show("El celular del destinatario debe tener 9 dígitos y empezar con 9.");
                txtCelularDestino.Focus();
                return false;
            }

            for (int i = 0; i < celular.Length; i++)
            {
                if (!char.IsDigit(celular[i]))
                {
                    MessageBox.Show("El celular solo debe contener números.");
                    txtCelularDestino.Focus();
                    return false;
                }
            }

            string miCelular = miBilletera.celular.Replace(" ", "");
            if (celular == miCelular)
            {
                MessageBox.Show("No puede transferir a su propio número de cuenta.");
                txtCelularDestino.Focus();
                return false;
            }

            destinatarioCompleto = nombre + " (" + celular + ")";
            return true;
        }

        private void LimpiarDestinatario()
        {
            txtDestino.Clear();
            txtCelularDestino.Clear();
            txtDestino.Focus();
        }

        // Billetera

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string destino;
            if (!ValidarDestinatario(out destino))
            {
                return;
            }

            double monto = LeerMonto(txtMonto.Text);
            if (monto <= 0)
            {
                MessageBox.Show("Ingrese un importe válido.");
                txtMonto.Focus();
                return;
            }

            if (miBilletera.Transferir(destino, monto))
            {
                actualHistorial = miBilletera.listaDoble.fin;
                LimpiarDestinatario();
                MostrarTodo();
                MessageBox.Show("Transferencia enviada a " + destino);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente.");
            }
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            string destino;
            if (!ValidarDestinatario(out destino))
            {
                return;
            }

            double monto = LeerMonto(txtMonto.Text);
            if (monto <= 0)
            {
                MessageBox.Show("Ingrese un importe válido.");
                txtMonto.Focus();
                return;
            }

            miBilletera.Encolar(destino, monto);
            LimpiarDestinatario();
            MostrarTodo();
            tabControl1.SelectedTab = tabCola;
            MessageBox.Show("Agregado a la cola.");
        }

        private void btnReintento_Click(object sender, EventArgs e)
        {
            string destino;
            if (!ValidarDestinatario(out destino))
            {
                return;
            }

            double monto = LeerMonto(txtMonto.Text);
            if (monto <= 0)
            {
                MessageBox.Show("Ingrese un importe válido.");
                txtMonto.Focus();
                return;
            }

            miBilletera.AgregarReintento(destino, monto);
            LimpiarDestinatario();
            MostrarTodo();
            tabControl1.SelectedTab = tabCola;
            MessageBox.Show("Agregado a reintentos.");
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            double monto = LeerMonto(txtRecarga.Text);
            if (monto <= 0)
            {
                MessageBox.Show("Ingrese un importe válido.");
                return;
            }

            miBilletera.Recargar(monto);
            actualHistorial = miBilletera.listaDoble.fin;
            MostrarTodo();
            MessageBox.Show("Recarga realizada.");
        }

        private void btnRevertir_Click(object sender, EventArgs e)
        {
            Operacion ultima = miBilletera.RevertirUltimo();
            if (ultima == null)
            {
                MessageBox.Show("La pila está vacía.");
                return;
            }

            actualHistorial = miBilletera.listaDoble.fin;
            MostrarTodo();
            MessageBox.Show("Operación #" + ultima.codigo + " revertida.");
        }

        // Pila y Árbol

        private void btnVerUltimo_Click(object sender, EventArgs e)
        {
            Operacion tope = miBilletera.pila.VerTope();
            if (tope == null)
            {
                MessageBox.Show("La pila está vacía.");
                return;
            }

            MessageBox.Show(Formatear(tope), "Última operación");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NodoArbol p = miBilletera.arbol.Buscar(txtBuscar.Text.Trim());
            if (p != null)
            {
                lblResArbol.Text = Formatear(p.info);
            }
            else
            {
                lblResArbol.Text = "No encontrada";
            }
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            recorridoArbol = "InOrden";
            MostrarArbol();
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            recorridoArbol = "PreOrden";
            MostrarArbol();
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            recorridoArbol = "PostOrden";
            MostrarArbol();
        }

        // Historial (Lista Simple y Doble)

        private void btnNormal_Click(object sender, EventArgs e)
        {
            ordenInverso = false;
            MostrarHistorial();
        }

        private void btnInverso_Click(object sender, EventArgs e)
        {
            ordenInverso = true;
            MostrarHistorial();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            actualHistorial = miBilletera.listaDoble.inicio;
            MostrarActual();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (actualHistorial != null && actualHistorial.ant != null)
            {
                actualHistorial = actualHistorial.ant;
                MostrarActual();
            }
            else
            {
                MessageBox.Show("Ya está en el primero.");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (actualHistorial != null && actualHistorial.sgte != null)
            {
                actualHistorial = actualHistorial.sgte;
                MostrarActual();
            }
            else
            {
                MessageBox.Show("Ya está en el último.");
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            actualHistorial = miBilletera.listaDoble.fin;
            MostrarActual();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = ObtenerCodigo(lstHistorial);
            if (codigo == "")
            {
                MessageBox.Show("Seleccione un movimiento de la lista.");
                return;
            }

            miBilletera.EliminarDeRegistros(codigo);
            actualHistorial = miBilletera.listaDoble.fin;
            MostrarTodo();
            MessageBox.Show("Eliminado #" + codigo);
        }

        // Cola y Lista Circular

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Operacion op;
            int res = miBilletera.AtenderPrimeroCola(out op);

            if (res == 0)
            {
                MessageBox.Show("La cola está vacía.");
            }
            else if (res == -1)
            {
                MostrarTodo();
                MessageBox.Show("Sin saldo para #" + op.codigo + ". Pasó a reintentos.");
            }
            else
            {
                actualHistorial = miBilletera.listaDoble.fin;
                MostrarTodo();
                MessageBox.Show("Procesada #" + op.codigo);
            }
        }

        private void btnProcesarTodo_Click(object sender, EventArgs e)
        {
            if (miBilletera.cola.EstaVacia())
            {
                MessageBox.Show("La cola está vacía.");
                return;
            }

            while (!miBilletera.cola.EstaVacia())
            {
                Operacion op;
                miBilletera.AtenderPrimeroCola(out op);
            }

            actualHistorial = miBilletera.listaDoble.fin;
            MostrarTodo();
            MessageBox.Show("Cola procesada.");
        }

        private void btnVaciarCola_Click(object sender, EventArgs e)
        {
            miBilletera.VaciarCola();
            MostrarCola();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            string codigo = ObtenerCodigo(lstCircular);
            if (codigo == "")
            {
                MessageBox.Show("Seleccione un reintento de la lista.");
                return;
            }

            if (miBilletera.CompletarReintento(codigo))
            {
                actualHistorial = miBilletera.listaDoble.fin;
                MostrarTodo();
                MessageBox.Show("Completado #" + codigo);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente.");
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (miBilletera.listaCircular.inicio == null)
            {
                MessageBox.Show("No hay reintentos.");
                return;
            }

            string texto = "";
            NodoCircular p = miBilletera.listaCircular.inicio;
            int vuelta = 1;
            int conta = 0;
            int limite = miBilletera.listaCircular.Contar() * 3;

            do
            {
                conta = conta + 1;
                texto = texto + "Vuelta " + vuelta + ": " + Formatear(p.info) + "\n";
                p = p.sgte;
                if (p == miBilletera.listaCircular.inicio)
                {
                    vuelta = vuelta + 1;
                }
            } while (conta < limite);

            MessageBox.Show(texto, "Simulación Lista Circular");
        }

        private void btnEliminarReintento_Click(object sender, EventArgs e)
        {
            string codigo = ObtenerCodigo(lstCircular);
            if (codigo == "")
            {
                MessageBox.Show("Seleccione un reintento de la lista.");
                return;
            }

            miBilletera.EliminarReintento(codigo);
            MostrarCircular();
        }

        // Grafo

        private void btnFloyd_Click(object sender, EventArgs e)
        {
            lstGrafo.Items.Clear();
            lstGrafo.Items.Add("Ruta mínima (Floyd-Warshall):");
            lstGrafo.Items.Add(miBilletera.grafo.RutaMinimaFloyd(cmbOrigen.SelectedIndex, cmbDestinoG.SelectedIndex));
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            int total;
            string[] aristas = miBilletera.grafo.ArbolMinimoPrim(out total);

            lstGrafo.Items.Clear();
            lstGrafo.Items.Add("Árbol mínimo (Prim):");
            for (int i = 0; i < aristas.Length; i++)
            {
                if (aristas[i] != null)
                {
                    lstGrafo.Items.Add(aristas[i]);
                }
            }
            lstGrafo.Items.Add("Total: " + total + " ms");
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex == cmbDestinoG.SelectedIndex)
            {
                MessageBox.Show("Seleccione dos agencias distintas.");
                return;
            }

            miBilletera.CortarEnlaceAgencias(cmbOrigen.SelectedIndex, cmbDestinoG.SelectedIndex);
            MostrarEnlaces();
            btnFloyd_Click(sender, e);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            miBilletera.RestaurarRedAgencias();
            MostrarEnlaces();
            lstGrafo.Items.Clear();
            lstGrafo.Items.Add("Red restaurada.");
        }

        private void lstPila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSaldoActual_Click(object sender, EventArgs e)
        {

        }

        private void grpCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void lblTitular_Click(object sender, EventArgs e)
        {

        }
    }
}
