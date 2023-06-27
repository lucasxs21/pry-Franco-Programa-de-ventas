using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Franco_Programa_de_ventas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblvendedor_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnCargarventa_Click(object sender, EventArgs e)
        {
            try
            {

                Class1 Datos1 = new Class1();
                Datos1.RegistrarVenta(Convert.ToInt32(cmbVendedor.SelectedValue), Convert.ToInt32(cmbProducto.SelectedValue), dtp.Value, Convert.ToInt32(txtKilos.Text));
                MessageBox.Show("Se a cargado correctamente");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            cmbProducto.SelectedIndex = -1;
            txtKilos.Text = "0";
          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Class1 Datos = new Class1();
                Datos.CargarDatos(cmbProducto, cmbVendedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
                
            }
        }

        private void txtKilos_TextChanged(object sender, EventArgs e)
        {
            btnCargarventa.Enabled = true;
        }

        private void txtKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }
    }
}
