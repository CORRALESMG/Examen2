using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int n = Tabla.Rows.Add();
            Tabla.Rows[n].Cells[0].Value = Ventas;
            Tabla.Rows[n].Cells[1].Value = InventarioInicial;
            Tabla.Rows[n].Cells[2].Value = DevolucionSV;
            Tabla.Rows[n].Cells[3].Value = GastosC;
            Tabla.Rows[n].Cells[4].Value = RentaO;
            Tabla.Rows[n].Cells[5].Value = SueldoGerenteAdictivo;
            Tabla.Rows[n].Cells[6].Value = Publicidad;
            Tabla.Rows[n].Cells[7].Value = OtrosProductos;
            Tabla.Rows[n].Cells[8].Value = Impuestos;
            Tabla.Rows[n].Cells[9].Value = Compras;
            Tabla.Rows[n].Cells[10].Value = InventarioFinal;
            Tabla.Rows[n].Cells[11].Value = DevolucionSC;
            Tabla.Rows[n].Cells[12].Value = Rentadetienda;
            Tabla.Rows[n].Cells[13].Value = ComisionesVendedores;
            Tabla.Rows[n].Cells[14].Value = ServicioTV;
            Tabla.Rows[n].Cells[15].Value = EmpaquedeProductos;
            Tabla.Rows[n].Cells[16].Value = OtrosGastos;


            int Ventas, InventarioInicial, DevolucionSobreVenta, GastosdeCompra, RentasdeOficinas, SueldoGerenteAditivo, Publicidad, OtrosProductos, Impuestos, Compras, InventarioFinal, DevolucionsobreCompras, Rentasdetiendas, ComisionVendedores, Serviciostelefonicosventas, Empaquesdeproductos, OtrosGastos;
            Ventas = int.Parse(textVentas.Text);
            InventarioInicial = int.Parse(textInventarioI.Text);
            DevolucionSobreVenta = int.Parse(textDevolucionSV.Text);
            Ventas = int.Parse(textVentas.Text);
            Ventas = int.Parse(textVentas.Text);
            Ventas = int.Parse(textVentas.Text);
            Ventas = int.Parse(textVentas.Text);
            Ventas = int.Parse(textVentas.Text);
            Ventas = int.Parse(textVentas.Text);




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
