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
        OleDbConnection miConexionBD;
        OleDbCommand miComandoBD;
        OleDbDataReader miLectorBD;
        public string ruta;
        public void Conectar()
        {
            ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.mdb;Persist Security Info=False;";
          
            try
            {              
                miConexionBD.ConnectionString= ruta;
                miComandoBD.Connection.Open();
              
            }
            catch (Exception error)
            {
              
            }



        }



    }
}
