namespace WindowsFormsApp1
{
    partial class Ventana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textVentas = new System.Windows.Forms.TextBox();
            this.textInventarioI = new System.Windows.Forms.TextBox();
            this.textDevolucionSV = new System.Windows.Forms.TextBox();
            this.textRentaO = new System.Windows.Forms.TextBox();
            this.textGastosC = new System.Windows.Forms.TextBox();
            this.textSueldoGA = new System.Windows.Forms.TextBox();
            this.textOtrosProductos = new System.Windows.Forms.TextBox();
            this.textPublicidad = new System.Windows.Forms.TextBox();
            this.textCompras = new System.Windows.Forms.TextBox();
            this.textImpuestos = new System.Windows.Forms.TextBox();
            this.textInventarioF = new System.Windows.Forms.TextBox();
            this.textDevolucionSC = new System.Windows.Forms.TextBox();
            this.textRentadetienda = new System.Windows.Forms.TextBox();
            this.textComisionVendedores = new System.Windows.Forms.TextBox();
            this.textServiciosTV = new System.Windows.Forms.TextBox();
            this.textEmpaquesdeproductos = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox17OtrosGastos = new System.Windows.Forms.TextBox();
            this.Ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventarioInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevolucionSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GastosC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentaO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoGerenteAdictivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventarioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevolucionSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rentadetienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionesVendedores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicioTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpaquedeProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtrosGastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(697, 237);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Almacen Dos Hermanas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ventas,
            this.InventarioInicial,
            this.DevolucionSV,
            this.GastosC,
            this.RentaO,
            this.SueldoGerenteAdictivo,
            this.Publicidad,
            this.OtrosProductos,
            this.Impuestos,
            this.Compras,
            this.InventarioFinal,
            this.DevolucionSC,
            this.Rentadetienda,
            this.ComisionesVendedores,
            this.ServicioTV,
            this.EmpaquedeProductos,
            this.OtrosGastos});
            this.Tabla.Location = new System.Drawing.Point(7, 309);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(927, 312);
            this.Tabla.TabIndex = 3;
            this.Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventario Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Devolucion Sobre Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gastos de Compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Renta de Oficinas ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sueldo Gerente Aditivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Publicidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Otros Productos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Impuestos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Compras";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Inventario Final";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(356, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Devolucion sobre Compras";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(367, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Renta de tienda ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(356, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Comision Vendedores";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(569, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "servicio telefonico ventas";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(569, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Empaque de productos";
            // 
            // textVentas
            // 
            this.textVentas.Location = new System.Drawing.Point(53, 65);
            this.textVentas.Name = "textVentas";
            this.textVentas.Size = new System.Drawing.Size(100, 20);
            this.textVentas.TabIndex = 20;
            this.textVentas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textInventarioI
            // 
            this.textInventarioI.Location = new System.Drawing.Point(53, 109);
            this.textInventarioI.Name = "textInventarioI";
            this.textInventarioI.Size = new System.Drawing.Size(100, 20);
            this.textInventarioI.TabIndex = 21;
            // 
            // textDevolucionSV
            // 
            this.textDevolucionSV.Location = new System.Drawing.Point(53, 155);
            this.textDevolucionSV.Name = "textDevolucionSV";
            this.textDevolucionSV.Size = new System.Drawing.Size(100, 20);
            this.textDevolucionSV.TabIndex = 22;
            // 
            // textRentaO
            // 
            this.textRentaO.Location = new System.Drawing.Point(53, 264);
            this.textRentaO.Name = "textRentaO";
            this.textRentaO.Size = new System.Drawing.Size(100, 20);
            this.textRentaO.TabIndex = 23;
            // 
            // textGastosC
            // 
            this.textGastosC.Location = new System.Drawing.Point(53, 208);
            this.textGastosC.Name = "textGastosC";
            this.textGastosC.Size = new System.Drawing.Size(100, 20);
            this.textGastosC.TabIndex = 24;
            // 
            // textSueldoGA
            // 
            this.textSueldoGA.Location = new System.Drawing.Point(250, 65);
            this.textSueldoGA.Name = "textSueldoGA";
            this.textSueldoGA.Size = new System.Drawing.Size(100, 20);
            this.textSueldoGA.TabIndex = 25;
            // 
            // textOtrosProductos
            // 
            this.textOtrosProductos.Location = new System.Drawing.Point(250, 155);
            this.textOtrosProductos.Name = "textOtrosProductos";
            this.textOtrosProductos.Size = new System.Drawing.Size(100, 20);
            this.textOtrosProductos.TabIndex = 26;
            // 
            // textPublicidad
            // 
            this.textPublicidad.Location = new System.Drawing.Point(250, 110);
            this.textPublicidad.Name = "textPublicidad";
            this.textPublicidad.Size = new System.Drawing.Size(100, 20);
            this.textPublicidad.TabIndex = 27;
            // 
            // textCompras
            // 
            this.textCompras.Location = new System.Drawing.Point(250, 264);
            this.textCompras.Name = "textCompras";
            this.textCompras.Size = new System.Drawing.Size(100, 20);
            this.textCompras.TabIndex = 28;
            // 
            // textImpuestos
            // 
            this.textImpuestos.Location = new System.Drawing.Point(250, 213);
            this.textImpuestos.Name = "textImpuestos";
            this.textImpuestos.Size = new System.Drawing.Size(100, 20);
            this.textImpuestos.TabIndex = 30;
            // 
            // textInventarioF
            // 
            this.textInventarioF.Location = new System.Drawing.Point(469, 61);
            this.textInventarioF.Name = "textInventarioF";
            this.textInventarioF.Size = new System.Drawing.Size(100, 20);
            this.textInventarioF.TabIndex = 31;
            // 
            // textDevolucionSC
            // 
            this.textDevolucionSC.Location = new System.Drawing.Point(469, 110);
            this.textDevolucionSC.Name = "textDevolucionSC";
            this.textDevolucionSC.Size = new System.Drawing.Size(100, 20);
            this.textDevolucionSC.TabIndex = 32;
            // 
            // textRentadetienda
            // 
            this.textRentadetienda.Location = new System.Drawing.Point(469, 155);
            this.textRentadetienda.Name = "textRentadetienda";
            this.textRentadetienda.Size = new System.Drawing.Size(100, 20);
            this.textRentadetienda.TabIndex = 33;
            // 
            // textComisionVendedores
            // 
            this.textComisionVendedores.Location = new System.Drawing.Point(469, 195);
            this.textComisionVendedores.Name = "textComisionVendedores";
            this.textComisionVendedores.Size = new System.Drawing.Size(100, 20);
            this.textComisionVendedores.TabIndex = 34;
            // 
            // textServiciosTV
            // 
            this.textServiciosTV.Location = new System.Drawing.Point(672, 65);
            this.textServiciosTV.Name = "textServiciosTV";
            this.textServiciosTV.Size = new System.Drawing.Size(100, 20);
            this.textServiciosTV.TabIndex = 35;
            // 
            // textEmpaquesdeproductos
            // 
            this.textEmpaquesdeproductos.Location = new System.Drawing.Point(672, 117);
            this.textEmpaquesdeproductos.Name = "textEmpaquesdeproductos";
            this.textEmpaquesdeproductos.Size = new System.Drawing.Size(100, 20);
            this.textEmpaquesdeproductos.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(589, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Otros Gastos";
            // 
            // textBox17OtrosGastos
            // 
            this.textBox17OtrosGastos.Location = new System.Drawing.Point(672, 172);
            this.textBox17OtrosGastos.Name = "textBox17OtrosGastos";
            this.textBox17OtrosGastos.Size = new System.Drawing.Size(100, 20);
            this.textBox17OtrosGastos.TabIndex = 38;
            // 
            // Ventas
            // 
            this.Ventas.HeaderText = "Ventas";
            this.Ventas.Name = "Ventas";
            // 
            // InventarioInicial
            // 
            this.InventarioInicial.HeaderText = "Inventario Inicial";
            this.InventarioInicial.Name = "InventarioInicial";
            // 
            // DevolucionSV
            // 
            this.DevolucionSV.HeaderText = "Devolucion Sobre Venta";
            this.DevolucionSV.Name = "DevolucionSV";
            // 
            // GastosC
            // 
            this.GastosC.HeaderText = "Gastos de Compra";
            this.GastosC.Name = "GastosC";
            // 
            // RentaO
            // 
            this.RentaO.HeaderText = "Renta de Oficina";
            this.RentaO.Name = "RentaO";
            // 
            // SueldoGerenteAdictivo
            // 
            this.SueldoGerenteAdictivo.HeaderText = "Sueldo Gerente Aditivo";
            this.SueldoGerenteAdictivo.Name = "SueldoGerenteAdictivo";
            // 
            // Publicidad
            // 
            this.Publicidad.HeaderText = "Publicidad";
            this.Publicidad.Name = "Publicidad";
            // 
            // OtrosProductos
            // 
            this.OtrosProductos.HeaderText = "Otros Productos";
            this.OtrosProductos.Name = "OtrosProductos";
            // 
            // Impuestos
            // 
            this.Impuestos.HeaderText = "Impuestos";
            this.Impuestos.Name = "Impuestos";
            // 
            // Compras
            // 
            this.Compras.HeaderText = "Compras";
            this.Compras.Name = "Compras";
            // 
            // InventarioFinal
            // 
            this.InventarioFinal.HeaderText = "Inventario Final";
            this.InventarioFinal.Name = "InventarioFinal";
            // 
            // DevolucionSC
            // 
            this.DevolucionSC.HeaderText = "Devulocuin sobre compra";
            this.DevolucionSC.Name = "DevolucionSC";
            // 
            // Rentadetienda
            // 
            this.Rentadetienda.HeaderText = "Renta de tienda";
            this.Rentadetienda.Name = "Rentadetienda";
            // 
            // ComisionesVendedores
            // 
            this.ComisionesVendedores.HeaderText = "Comisiones Vendedores";
            this.ComisionesVendedores.Name = "ComisionesVendedores";
            // 
            // ServicioTV
            // 
            this.ServicioTV.HeaderText = "Servicio Telefonico Ventas";
            this.ServicioTV.Name = "ServicioTV";
            // 
            // EmpaquedeProductos
            // 
            this.EmpaquedeProductos.HeaderText = "Empaque de Productos";
            this.EmpaquedeProductos.Name = "EmpaquedeProductos";
            // 
            // OtrosGastos
            // 
            this.OtrosGastos.HeaderText = "Otros Gastos";
            this.OtrosGastos.Name = "OtrosGastos";
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 563);
            this.Controls.Add(this.textBox17OtrosGastos);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textEmpaquesdeproductos);
            this.Controls.Add(this.textServiciosTV);
            this.Controls.Add(this.textComisionVendedores);
            this.Controls.Add(this.textRentadetienda);
            this.Controls.Add(this.textDevolucionSC);
            this.Controls.Add(this.textInventarioF);
            this.Controls.Add(this.textImpuestos);
            this.Controls.Add(this.textCompras);
            this.Controls.Add(this.textPublicidad);
            this.Controls.Add(this.textOtrosProductos);
            this.Controls.Add(this.textSueldoGA);
            this.Controls.Add(this.textGastosC);
            this.Controls.Add(this.textRentaO);
            this.Controls.Add(this.textDevolucionSV);
            this.Controls.Add(this.textInventarioI);
            this.Controls.Add(this.textVentas);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Name = "Ventana";
            this.Text = "Estado de Resultado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textVentas;
        private System.Windows.Forms.TextBox textInventarioI;
        private System.Windows.Forms.TextBox textDevolucionSV;
        private System.Windows.Forms.TextBox textRentaO;
        private System.Windows.Forms.TextBox textGastosC;
        private System.Windows.Forms.TextBox textSueldoGA;
        private System.Windows.Forms.TextBox textOtrosProductos;
        private System.Windows.Forms.TextBox textPublicidad;
        private System.Windows.Forms.TextBox textCompras;
        private System.Windows.Forms.TextBox textImpuestos;
        private System.Windows.Forms.TextBox textInventarioF;
        private System.Windows.Forms.TextBox textDevolucionSC;
        private System.Windows.Forms.TextBox textRentadetienda;
        private System.Windows.Forms.TextBox textComisionVendedores;
        private System.Windows.Forms.TextBox textServiciosTV;
        private System.Windows.Forms.TextBox textEmpaquesdeproductos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox17OtrosGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventarioInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevolucionSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GastosC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentaO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoGerenteAdictivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtrosProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compras;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevolucionSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rentadetienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionesVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicioTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpaquedeProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtrosGastos;
    }
}

