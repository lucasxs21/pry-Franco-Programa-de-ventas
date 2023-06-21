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
                Datos1.InsertData(cmbVendedor.Text.ToString(), cmbProducto.Text.ToString(),DateTime.Now, txtKilos.Text.ToString());
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }              
                
          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Class1 Datos = new Class1();
                Datos.Conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
                
            }
        }
    }
}
