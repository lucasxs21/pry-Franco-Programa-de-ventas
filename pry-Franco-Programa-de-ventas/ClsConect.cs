using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;


namespace pry_Franco_Programa_de_ventas
{
    internal class Class1
    {
         OleDbConnection conexion;
         OleDbCommand comando;
         OleDbDataReader lector;
        //public string ruta;
        public string ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.mdb;Persist Security Info=False;";

        public void Conectar()
        {
            //ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.mdb;Persist Security Info=False;";

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

        public void InsertData(int idVendedor, int idProduc, string fecha, int kilos)
        {
            string query = "INSERT INTO Ventas (Cod Vendedor,Cod Producto,Fecha,Kilos) values (@Cod Vendedor, @Cod Producto, @Fecha, @Kilos)";

            using (OleDbConnection conexion = new OleDbConnection(ruta))
            {
                conexion.Open();

                using (OleDbCommand comando = new OleDbCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Cod Vendedor", idVendedor);
                    comando.Parameters.AddWithValue("@Cod Producto", idProduc);
                    comando.Parameters.AddWithValue("@Fecha", fecha);
                    comando.Parameters.AddWithValue("@Kilos", kilos);

                    
                    comando.ExecuteNonQuery();
                    
                }
            }


        }

    }
}
