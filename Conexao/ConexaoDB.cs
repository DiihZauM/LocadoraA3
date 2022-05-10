using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraA3.Conexao
{
    public class ConexaoDB
    {
        SqlConnection cn = new SqlConnection(@"Server=localhost;Database=LocadoraDb;Uid=root;Pwd=Dizao@123;");
        public static string msg;

        public SqlConnection MyConectarBD()
        {

            try
            {
                cn.Open();
            }

            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;
        }

        public SqlConnection MyDesConectarBD()
        {

            try
            {
                cn.Close();
            }

            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;
        }
    }
}
