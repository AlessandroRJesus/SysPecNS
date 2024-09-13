using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    public static class Banco
    {
        /// <summary>
        /// Metodo abrir da classe banco é ultilizado para representar comando SQL
        /// no servidor, cujos dados foram informados na string de conecxão (strconn)
        /// </summary>
        /// <returns> Entrega um objeto de comandos na string de conexão informada </returns> 
        public static MySqlCommand Abrir()
        {
            string strconn = @"Server=10.91.45.20;database=syspecdb;user=root;password=root";
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new();
            try //tratamento de excessão
            {
                cn.Open();
                cmd.Connection = cn;
             
            }
            catch (Exception)
            {

                throw;
            }
   
            return cmd;
        } 
    }
}
