using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace pry_Franco_Programa_de_ventas
{
    internal class Class1
    {
        OleDbConnection conexion;
        OleDbCommand comando ;
        OleDbDataReader lector;

        public string ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.mdb;Persist Security Info=False;";

        public void Conectar()
        {


            try
            {
                conexion = new OleDbConnection();
                conexion.ConnectionString = ruta;
                conexion.Open();

            }
            catch (Exception error)
            {


            }

        }

        public void InsertData(string idVendedor, string idProduc, DateTime fecha, string kilos)
        {
            comando = new OleDbCommand();

            int vendedor = Convert.ToInt32(idVendedor);
            int Producto = Convert.ToInt32(idProduc);
            int kilos1 = Convert.ToInt32(kilos);
            try
            {

                conexion = new OleDbConnection();
                conexion.ConnectionString = ruta;

                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;


                comando.CommandText = "INSERT INTO Ventas(Cod_Vendedor,Cod_Producto,Fecha,Kilos) VALUES(" + vendedor + ", " + Producto  + 1 + "," + kilos1 + ")";

                //comando.Parameters.AddWithValue("@Cod_Vendedor", vendedor);
                //comando.Parameters.AddWithValue("@Cod_Producto", Producto);
                //comando.Parameters.AddWithValue("@Fecha", fecha);
                //comando.Parameters.AddWithValue("@Kilos", kilos1);

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        //public void InsertData(string codVendedor, string codProducto, DateTime fecha, string kilos)
        //{
        //    // Cadena de conexión a la base de datos Access
        //    string connectionString = ruta;

        //    // Consulta SQL para la inserción
        //    string query = "INSERT INTO Ventas (Cod_Vendedor, Cod_Producto, Fecha, Kilos) VALUES (@CodVendedor, @CodProducto, @Fecha, @Kilos)";

        //    // Crear la conexión y el comando
        //    using (OleDbConnection connection = new OleDbConnection(connectionString))
        //    using (OleDbCommand command = new OleDbCommand(query, connection))
        //    {
        //        // Agregar los parámetros con sus respectivos valores
        //        command.Parameters.AddWithValue("@CodVendedor", codVendedor);
        //        command.Parameters.AddWithValue("@CodProducto", codProducto);
        //        command.Parameters.AddWithValue("@Fecha", fecha);
        //        command.Parameters.AddWithValue("@Kilos", kilos);

        //        // Abrir la conexión y ejecutar el comando
        //        connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}



    }
}
