namespace BilleteraCajaArequipa.Formularios
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpCuenta;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblTextoSaldo;
        private System.Windows.Forms.Label lblSaldoActual;

        private System.Windows.Forms.GroupBox grpTransferir;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblCelularDestino;
        private System.Windows.Forms.TextBox txtCelularDestino;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnReintento;

        private System.Windows.Forms.GroupBox grpRecarga;
        private System.Windows.Forms.Label lblRecarga;
        private System.Windows.Forms.TextBox txtRecarga;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Button btnRevertir;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMovimientos;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.TabPage tabCola;
        private System.Windows.Forms.TabPage tabGrafo;

        // Pestaña 1: Pila y Árbol
        private System.Windows.Forms.GroupBox grpPila;
        private System.Windows.Forms.Button btnVerUltimo;
        private System.Windows.Forms.ListBox lstPila;

        private System.Windows.Forms.GroupBox grpArbol;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResArbol;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.ListBox lstArbol;

        // Pestaña 2: Historial (Lista Simple y Doble)
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnInverso;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;

        // Pestaña 3: Cola y Lista Circular
        private System.Windows.Forms.GroupBox grpCola;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnProcesarTodo;
        private System.Windows.Forms.Button btnVaciarCola;
        private System.Windows.Forms.ListBox lstCola;

        private System.Windows.Forms.GroupBox grpCircular;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnEliminarReintento;
        private System.Windows.Forms.ListBox lstCircular;

        // Pestaña 4: Grafo
        private System.Windows.Forms.GroupBox grpGrafo;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblDestinoG;
        private System.Windows.Forms.ComboBox cmbDestinoG;
        private System.Windows.Forms.Button btnFloyd;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label lblMatriz;
        private System.Windows.Forms.ListBox lstMatriz;
        private System.Windows.Forms.Label lblResGrafo;
        private System.Windows.Forms.ListBox lstGrafo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpCuenta = new System.Windows.Forms.GroupBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblTextoSaldo = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.grpTransferir = new System.Windows.Forms.GroupBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblCelularDestino = new System.Windows.Forms.Label();
            this.txtCelularDestino = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnReintento = new System.Windows.Forms.Button();
            this.grpRecarga = new System.Windows.Forms.GroupBox();
            this.lblRecarga = new System.Windows.Forms.Label();
            this.txtRecarga = new System.Windows.Forms.TextBox();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.btnRevertir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.grpPila = new System.Windows.Forms.GroupBox();
            this.btnVerUltimo = new System.Windows.Forms.Button();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.grpArbol = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResArbol = new System.Windows.Forms.Label();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.lstArbol = new System.Windows.Forms.ListBox();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnInverso = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblActual = new System.Windows.Forms.Label();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.tabCola = new System.Windows.Forms.TabPage();
            this.grpCola = new System.Windows.Forms.GroupBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnProcesarTodo = new System.Windows.Forms.Button();
            this.btnVaciarCola = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.grpCircular = new System.Windows.Forms.GroupBox();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnEliminarReintento = new System.Windows.Forms.Button();
            this.lstCircular = new System.Windows.Forms.ListBox();
            this.tabGrafo = new System.Windows.Forms.TabPage();
            this.grpGrafo = new System.Windows.Forms.GroupBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblDestinoG = new System.Windows.Forms.Label();
            this.cmbDestinoG = new System.Windows.Forms.ComboBox();
            this.btnFloyd = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.lstMatriz = new System.Windows.Forms.ListBox();
            this.lblResGrafo = new System.Windows.Forms.Label();
            this.lstGrafo = new System.Windows.Forms.ListBox();
            this.grpCuenta.SuspendLayout();
            this.grpTransferir.SuspendLayout();
            this.grpRecarga.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMovimientos.SuspendLayout();
            this.grpPila.SuspendLayout();
            this.grpArbol.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            this.grpHistorial.SuspendLayout();
            this.tabCola.SuspendLayout();
            this.grpCola.SuspendLayout();
            this.grpCircular.SuspendLayout();
            this.tabGrafo.SuspendLayout();
            this.grpGrafo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCuenta
            // 
            this.grpCuenta.Controls.Add(this.lblTitular);
            this.grpCuenta.Controls.Add(this.lblCuenta);
            this.grpCuenta.Controls.Add(this.lblTextoSaldo);
            this.grpCuenta.Controls.Add(this.lblSaldoActual);
            this.grpCuenta.Location = new System.Drawing.Point(12, 12);
            this.grpCuenta.Name = "grpCuenta";
            this.grpCuenta.Size = new System.Drawing.Size(250, 115);
            this.grpCuenta.TabIndex = 0;
            this.grpCuenta.TabStop = false;
            this.grpCuenta.Text = "Cuenta";
            this.grpCuenta.Enter += new System.EventHandler(this.grpCuenta_Enter);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(14, 20);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(90, 13);
            this.lblTitular.TabIndex = 0;
            this.lblTitular.Text = "Sebastian Vargas";
            this.lblTitular.Click += new System.EventHandler(this.lblTitular_Click);
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(14, 38);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(90, 13);
            this.lblCuenta.TabIndex = 1;
            this.lblCuenta.Text = "Nro. 987 654 321";
            // 
            // lblTextoSaldo
            // 
            this.lblTextoSaldo.AutoSize = true;
            this.lblTextoSaldo.Location = new System.Drawing.Point(14, 62);
            this.lblTextoSaldo.Name = "lblTextoSaldo";
            this.lblTextoSaldo.Size = new System.Drawing.Size(87, 13);
            this.lblTextoSaldo.TabIndex = 2;
            this.lblTextoSaldo.Text = "Saldo disponible:";
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(12, 80);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(98, 25);
            this.lblSaldoActual.TabIndex = 3;
            this.lblSaldoActual.Text = "S/ 1000.00";
            this.lblSaldoActual.Click += new System.EventHandler(this.lblSaldoActual_Click);
            // 
            // grpTransferir
            // 
            this.grpTransferir.Controls.Add(this.lblDestino);
            this.grpTransferir.Controls.Add(this.txtDestino);
            this.grpTransferir.Controls.Add(this.lblCelularDestino);
            this.grpTransferir.Controls.Add(this.txtCelularDestino);
            this.grpTransferir.Controls.Add(this.lblMonto);
            this.grpTransferir.Controls.Add(this.txtMonto);
            this.grpTransferir.Controls.Add(this.btnEnviar);
            this.grpTransferir.Controls.Add(this.btnEncolar);
            this.grpTransferir.Controls.Add(this.btnReintento);
            this.grpTransferir.Location = new System.Drawing.Point(12, 135);
            this.grpTransferir.Name = "grpTransferir";
            this.grpTransferir.Size = new System.Drawing.Size(250, 235);
            this.grpTransferir.TabIndex = 1;
            this.grpTransferir.TabStop = false;
            this.grpTransferir.Text = "Transferir";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(14, 22);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(79, 13);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Destinatario (*):";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(14, 38);
            this.txtDestino.MaxLength = 40;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(222, 20);
            this.txtDestino.TabIndex = 1;
            // 
            // lblCelularDestino
            // 
            this.lblCelularDestino.AutoSize = true;
            this.lblCelularDestino.Location = new System.Drawing.Point(14, 66);
            this.lblCelularDestino.Name = "lblCelularDestino";
            this.lblCelularDestino.Size = new System.Drawing.Size(92, 13);
            this.lblCelularDestino.TabIndex = 2;
            this.lblCelularDestino.Text = "Celular destino (*):";
            // 
            // txtCelularDestino
            // 
            this.txtCelularDestino.Location = new System.Drawing.Point(14, 82);
            this.txtCelularDestino.MaxLength = 9;
            this.txtCelularDestino.Name = "txtCelularDestino";
            this.txtCelularDestino.Size = new System.Drawing.Size(222, 20);
            this.txtCelularDestino.TabIndex = 3;
            this.txtCelularDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelularDestino_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(14, 110);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(73, 13);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Importe S/ (*):";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(14, 126);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(222, 20);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.Text = "50.00";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(14, 156);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(222, 28);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(14, 192);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(108, 28);
            this.btnEncolar.TabIndex = 7;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnReintento
            // 
            this.btnReintento.Location = new System.Drawing.Point(128, 192);
            this.btnReintento.Name = "btnReintento";
            this.btnReintento.Size = new System.Drawing.Size(108, 28);
            this.btnReintento.TabIndex = 8;
            this.btnReintento.Text = "Reintento";
            this.btnReintento.Click += new System.EventHandler(this.btnReintento_Click);
            // 
            // grpRecarga
            // 
            this.grpRecarga.Controls.Add(this.lblRecarga);
            this.grpRecarga.Controls.Add(this.txtRecarga);
            this.grpRecarga.Controls.Add(this.btnAbonar);
            this.grpRecarga.Controls.Add(this.btnRevertir);
            this.grpRecarga.Location = new System.Drawing.Point(12, 378);
            this.grpRecarga.Name = "grpRecarga";
            this.grpRecarga.Size = new System.Drawing.Size(250, 148);
            this.grpRecarga.TabIndex = 2;
            this.grpRecarga.TabStop = false;
            this.grpRecarga.Text = "Recargar saldo";
            // 
            // lblRecarga
            // 
            this.lblRecarga.AutoSize = true;
            this.lblRecarga.Location = new System.Drawing.Point(14, 24);
            this.lblRecarga.Name = "lblRecarga";
            this.lblRecarga.Size = new System.Drawing.Size(66, 13);
            this.lblRecarga.TabIndex = 0;
            this.lblRecarga.Text = "Importe (S/):";
            // 
            // txtRecarga
            // 
            this.txtRecarga.Location = new System.Drawing.Point(14, 42);
            this.txtRecarga.Name = "txtRecarga";
            this.txtRecarga.Size = new System.Drawing.Size(222, 20);
            this.txtRecarga.TabIndex = 1;
            this.txtRecarga.Text = "100.00";
            // 
            // btnAbonar
            // 
            this.btnAbonar.Location = new System.Drawing.Point(14, 72);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(222, 28);
            this.btnAbonar.TabIndex = 2;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // btnRevertir
            // 
            this.btnRevertir.Location = new System.Drawing.Point(14, 108);
            this.btnRevertir.Name = "btnRevertir";
            this.btnRevertir.Size = new System.Drawing.Size(222, 28);
            this.btnRevertir.TabIndex = 3;
            this.btnRevertir.Text = "Revertir último (Pila)";
            this.btnRevertir.Click += new System.EventHandler(this.btnRevertir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMovimientos);
            this.tabControl1.Controls.Add(this.tabHistorial);
            this.tabControl1.Controls.Add(this.tabCola);
            this.tabControl1.Controls.Add(this.tabGrafo);
            this.tabControl1.Location = new System.Drawing.Point(274, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 514);
            this.tabControl1.TabIndex = 3;
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.Controls.Add(this.grpPila);
            this.tabMovimientos.Controls.Add(this.grpArbol);
            this.tabMovimientos.Location = new System.Drawing.Point(4, 22);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Size = new System.Drawing.Size(576, 488);
            this.tabMovimientos.TabIndex = 0;
            this.tabMovimientos.Text = "Movimientos";
            // 
            // grpPila
            // 
            this.grpPila.Controls.Add(this.btnVerUltimo);
            this.grpPila.Controls.Add(this.lstPila);
            this.grpPila.Location = new System.Drawing.Point(8, 8);
            this.grpPila.Name = "grpPila";
            this.grpPila.Size = new System.Drawing.Size(560, 205);
            this.grpPila.TabIndex = 0;
            this.grpPila.TabStop = false;
            this.grpPila.Text = "Últimos movimientos (Pila)";
            // 
            // btnVerUltimo
            // 
            this.btnVerUltimo.Location = new System.Drawing.Point(406, 18);
            this.btnVerUltimo.Name = "btnVerUltimo";
            this.btnVerUltimo.Size = new System.Drawing.Size(142, 24);
            this.btnVerUltimo.TabIndex = 0;
            this.btnVerUltimo.Text = "Ver última operación";
            this.btnVerUltimo.Click += new System.EventHandler(this.btnVerUltimo_Click);
            // 
            // lstPila
            // 
            this.lstPila.Location = new System.Drawing.Point(12, 48);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(536, 147);
            this.lstPila.TabIndex = 1;
            this.lstPila.SelectedIndexChanged += new System.EventHandler(this.lstPila_SelectedIndexChanged);
            // 
            // grpArbol
            // 
            this.grpArbol.Controls.Add(this.lblBuscar);
            this.grpArbol.Controls.Add(this.txtBuscar);
            this.grpArbol.Controls.Add(this.btnBuscar);
            this.grpArbol.Controls.Add(this.lblResArbol);
            this.grpArbol.Controls.Add(this.btnInOrden);
            this.grpArbol.Controls.Add(this.btnPreOrden);
            this.grpArbol.Controls.Add(this.btnPostOrden);
            this.grpArbol.Controls.Add(this.lstArbol);
            this.grpArbol.Location = new System.Drawing.Point(8, 220);
            this.grpArbol.Name = "grpArbol";
            this.grpArbol.Size = new System.Drawing.Size(560, 238);
            this.grpArbol.TabIndex = 1;
            this.grpArbol.TabStop = false;
            this.grpArbol.Text = "Consulta por código (Árbol Binario)";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 24);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Código:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(60, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(65, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "120";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(132, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 24);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblResArbol
            // 
            this.lblResArbol.AutoSize = true;
            this.lblResArbol.Location = new System.Drawing.Point(208, 24);
            this.lblResArbol.Name = "lblResArbol";
            this.lblResArbol.Size = new System.Drawing.Size(65, 13);
            this.lblResArbol.TabIndex = 3;
            this.lblResArbol.Text = "Sin consulta";
            // 
            // btnInOrden
            // 
            this.btnInOrden.Location = new System.Drawing.Point(12, 49);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(80, 24);
            this.btnInOrden.TabIndex = 4;
            this.btnInOrden.Text = "InOrden";
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(98, 49);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(80, 24);
            this.btnPreOrden.TabIndex = 5;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(184, 49);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(80, 24);
            this.btnPostOrden.TabIndex = 6;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // lstArbol
            // 
            this.lstArbol.Location = new System.Drawing.Point(12, 80);
            this.lstArbol.Name = "lstArbol";
            this.lstArbol.Size = new System.Drawing.Size(536, 147);
            this.lstArbol.TabIndex = 7;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.grpHistorial);
            this.tabHistorial.Location = new System.Drawing.Point(4, 22);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Size = new System.Drawing.Size(576, 488);
            this.tabHistorial.TabIndex = 1;
            this.tabHistorial.Text = "Historial";
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.btnNormal);
            this.grpHistorial.Controls.Add(this.btnInverso);
            this.grpHistorial.Controls.Add(this.btnEliminar);
            this.grpHistorial.Controls.Add(this.lstHistorial);
            this.grpHistorial.Controls.Add(this.lblActual);
            this.grpHistorial.Controls.Add(this.btnPrimero);
            this.grpHistorial.Controls.Add(this.btnAnterior);
            this.grpHistorial.Controls.Add(this.btnSiguiente);
            this.grpHistorial.Controls.Add(this.btnUltimo);
            this.grpHistorial.Location = new System.Drawing.Point(8, 8);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Size = new System.Drawing.Size(560, 450);
            this.grpHistorial.TabIndex = 0;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Historial (Lista Simple y Doble)";
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(12, 22);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(105, 25);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Orden normal";
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnInverso
            // 
            this.btnInverso.Location = new System.Drawing.Point(123, 22);
            this.btnInverso.Name = "btnInverso";
            this.btnInverso.Size = new System.Drawing.Size(105, 25);
            this.btnInverso.TabIndex = 1;
            this.btnInverso.Text = "Orden inverso";
            this.btnInverso.Click += new System.EventHandler(this.btnInverso_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(438, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 25);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.Location = new System.Drawing.Point(12, 54);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(536, 316);
            this.lstHistorial.TabIndex = 3;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(12, 382);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(40, 13);
            this.lblActual.TabIndex = 4;
            this.lblActual.Text = "Actual:";
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(12, 408);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(128, 28);
            this.btnPrimero.TabIndex = 5;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(148, 408);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(128, 28);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(284, 408);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(128, 28);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(420, 408);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(128, 28);
            this.btnUltimo.TabIndex = 8;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // tabCola
            // 
            this.tabCola.Controls.Add(this.grpCola);
            this.tabCola.Controls.Add(this.grpCircular);
            this.tabCola.Location = new System.Drawing.Point(4, 22);
            this.tabCola.Name = "tabCola";
            this.tabCola.Size = new System.Drawing.Size(576, 488);
            this.tabCola.TabIndex = 2;
            this.tabCola.Text = "Cola y Reintentos";
            // 
            // grpCola
            // 
            this.grpCola.Controls.Add(this.btnAtender);
            this.grpCola.Controls.Add(this.btnProcesarTodo);
            this.grpCola.Controls.Add(this.btnVaciarCola);
            this.grpCola.Controls.Add(this.lstCola);
            this.grpCola.Location = new System.Drawing.Point(8, 8);
            this.grpCola.Name = "grpCola";
            this.grpCola.Size = new System.Drawing.Size(560, 220);
            this.grpCola.TabIndex = 0;
            this.grpCola.TabStop = false;
            this.grpCola.Text = "Cola de transferencias (FIFO)";
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(12, 20);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(120, 25);
            this.btnAtender.TabIndex = 0;
            this.btnAtender.Text = "Atender primera";
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnProcesarTodo
            // 
            this.btnProcesarTodo.Location = new System.Drawing.Point(138, 20);
            this.btnProcesarTodo.Name = "btnProcesarTodo";
            this.btnProcesarTodo.Size = new System.Drawing.Size(120, 25);
            this.btnProcesarTodo.TabIndex = 1;
            this.btnProcesarTodo.Text = "Procesar todo";
            this.btnProcesarTodo.Click += new System.EventHandler(this.btnProcesarTodo_Click);
            // 
            // btnVaciarCola
            // 
            this.btnVaciarCola.Location = new System.Drawing.Point(438, 20);
            this.btnVaciarCola.Name = "btnVaciarCola";
            this.btnVaciarCola.Size = new System.Drawing.Size(110, 25);
            this.btnVaciarCola.TabIndex = 2;
            this.btnVaciarCola.Text = "Vaciar cola";
            this.btnVaciarCola.Click += new System.EventHandler(this.btnVaciarCola_Click);
            // 
            // lstCola
            // 
            this.lstCola.Location = new System.Drawing.Point(12, 52);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(536, 160);
            this.lstCola.TabIndex = 3;
            // 
            // grpCircular
            // 
            this.grpCircular.Controls.Add(this.btnCompletar);
            this.grpCircular.Controls.Add(this.btnSimular);
            this.grpCircular.Controls.Add(this.btnEliminarReintento);
            this.grpCircular.Controls.Add(this.lstCircular);
            this.grpCircular.Location = new System.Drawing.Point(8, 236);
            this.grpCircular.Name = "grpCircular";
            this.grpCircular.Size = new System.Drawing.Size(560, 222);
            this.grpCircular.TabIndex = 1;
            this.grpCircular.TabStop = false;
            this.grpCircular.Text = "Reintentos pendientes (Lista Circular)";
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(12, 20);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(120, 25);
            this.btnCompletar.TabIndex = 0;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(138, 20);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(120, 25);
            this.btnSimular.TabIndex = 1;
            this.btnSimular.Text = "Simular 3 vueltas";
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnEliminarReintento
            // 
            this.btnEliminarReintento.Location = new System.Drawing.Point(438, 20);
            this.btnEliminarReintento.Name = "btnEliminarReintento";
            this.btnEliminarReintento.Size = new System.Drawing.Size(110, 25);
            this.btnEliminarReintento.TabIndex = 2;
            this.btnEliminarReintento.Text = "Eliminar";
            this.btnEliminarReintento.Click += new System.EventHandler(this.btnEliminarReintento_Click);
            // 
            // lstCircular
            // 
            this.lstCircular.Location = new System.Drawing.Point(12, 52);
            this.lstCircular.Name = "lstCircular";
            this.lstCircular.Size = new System.Drawing.Size(536, 160);
            this.lstCircular.TabIndex = 3;
            // 
            // tabGrafo
            // 
            this.tabGrafo.Controls.Add(this.grpGrafo);
            this.tabGrafo.Location = new System.Drawing.Point(4, 22);
            this.tabGrafo.Name = "tabGrafo";
            this.tabGrafo.Size = new System.Drawing.Size(576, 488);
            this.tabGrafo.TabIndex = 3;
            this.tabGrafo.Text = "Red Agencias";
            // 
            // grpGrafo
            // 
            this.grpGrafo.Controls.Add(this.lblOrigen);
            this.grpGrafo.Controls.Add(this.cmbOrigen);
            this.grpGrafo.Controls.Add(this.lblDestinoG);
            this.grpGrafo.Controls.Add(this.cmbDestinoG);
            this.grpGrafo.Controls.Add(this.btnFloyd);
            this.grpGrafo.Controls.Add(this.btnPrim);
            this.grpGrafo.Controls.Add(this.btnCortar);
            this.grpGrafo.Controls.Add(this.btnRestaurar);
            this.grpGrafo.Controls.Add(this.lblMatriz);
            this.grpGrafo.Controls.Add(this.lstMatriz);
            this.grpGrafo.Controls.Add(this.lblResGrafo);
            this.grpGrafo.Controls.Add(this.lstGrafo);
            this.grpGrafo.Location = new System.Drawing.Point(8, 8);
            this.grpGrafo.Name = "grpGrafo";
            this.grpGrafo.Size = new System.Drawing.Size(560, 450);
            this.grpGrafo.TabIndex = 0;
            this.grpGrafo.TabStop = false;
            this.grpGrafo.Text = "Red de agencias Caja Arequipa (Grafo)";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(12, 25);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.Location = new System.Drawing.Point(58, 22);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(140, 21);
            this.cmbOrigen.TabIndex = 1;
            // 
            // lblDestinoG
            // 
            this.lblDestinoG.AutoSize = true;
            this.lblDestinoG.Location = new System.Drawing.Point(208, 25);
            this.lblDestinoG.Name = "lblDestinoG";
            this.lblDestinoG.Size = new System.Drawing.Size(46, 13);
            this.lblDestinoG.TabIndex = 2;
            this.lblDestinoG.Text = "Destino:";
            // 
            // cmbDestinoG
            // 
            this.cmbDestinoG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoG.Location = new System.Drawing.Point(258, 22);
            this.cmbDestinoG.Name = "cmbDestinoG";
            this.cmbDestinoG.Size = new System.Drawing.Size(140, 21);
            this.cmbDestinoG.TabIndex = 3;
            // 
            // btnFloyd
            // 
            this.btnFloyd.Location = new System.Drawing.Point(412, 20);
            this.btnFloyd.Name = "btnFloyd";
            this.btnFloyd.Size = new System.Drawing.Size(136, 25);
            this.btnFloyd.TabIndex = 4;
            this.btnFloyd.Text = "Ruta Floyd";
            this.btnFloyd.Click += new System.EventHandler(this.btnFloyd_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(12, 52);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(140, 25);
            this.btnPrim.TabIndex = 5;
            this.btnPrim.Text = "Árbol mínimo (Prim)";
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(160, 52);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(120, 25);
            this.btnCortar.TabIndex = 6;
            this.btnCortar.Text = "Cortar enlace";
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(288, 52);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(120, 25);
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.Text = "Restaurar red";
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.Location = new System.Drawing.Point(12, 86);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(107, 13);
            this.lblMatriz.TabIndex = 8;
            this.lblMatriz.Text = "Enlaces activos (ms):";
            // 
            // lstMatriz
            // 
            this.lstMatriz.Location = new System.Drawing.Point(12, 104);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(536, 160);
            this.lstMatriz.TabIndex = 9;
            // 
            // lblResGrafo
            // 
            this.lblResGrafo.AutoSize = true;
            this.lblResGrafo.Location = new System.Drawing.Point(12, 272);
            this.lblResGrafo.Name = "lblResGrafo";
            this.lblResGrafo.Size = new System.Drawing.Size(58, 13);
            this.lblResGrafo.TabIndex = 10;
            this.lblResGrafo.Text = "Resultado:";
            // 
            // lstGrafo
            // 
            this.lstGrafo.Location = new System.Drawing.Point(12, 290);
            this.lstGrafo.Name = "lstGrafo";
            this.lstGrafo.Size = new System.Drawing.Size(536, 147);
            this.lstGrafo.TabIndex = 11;
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(870, 538);
            this.Controls.Add(this.grpCuenta);
            this.Controls.Add(this.grpTransferir);
            this.Controls.Add(this.grpRecarga);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billetera Digital - Caja Arequipa";
            this.grpCuenta.ResumeLayout(false);
            this.grpCuenta.PerformLayout();
            this.grpTransferir.ResumeLayout(false);
            this.grpTransferir.PerformLayout();
            this.grpRecarga.ResumeLayout(false);
            this.grpRecarga.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabMovimientos.ResumeLayout(false);
            this.grpPila.ResumeLayout(false);
            this.grpArbol.ResumeLayout(false);
            this.grpArbol.PerformLayout();
            this.tabHistorial.ResumeLayout(false);
            this.grpHistorial.ResumeLayout(false);
            this.grpHistorial.PerformLayout();
            this.tabCola.ResumeLayout(false);
            this.grpCola.ResumeLayout(false);
            this.grpCircular.ResumeLayout(false);
            this.tabGrafo.ResumeLayout(false);
            this.grpGrafo.ResumeLayout(false);
            this.grpGrafo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
