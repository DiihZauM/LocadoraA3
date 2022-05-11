using LocadoraA3.Controllers;
using LocadoraA3.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraA3.Conexao
{
    public class conexaoDAO
    {
        ConexaoDB con = new ConexaoDB();

        public void CadCliente(Cliente cliente)
        {
            MySqlCommand cm = new MySqlCommand("Insert into cliente values (Default, @nome,@cpf,@endereco,@email,@telefone,@datanascimento,@senha)", con.MyConectarBD());
            cm.Parameters.Add("nome", MySqlDbType.VarChar).Value = cliente.nome;
            cm.Parameters.Add("cpf", MySqlDbType.VarChar).Value = cliente.cpf;
            cm.Parameters.Add("telefone", MySqlDbType.VarChar).Value = cliente.telefone;
            cm.Parameters.Add("email", MySqlDbType.VarChar).Value = cliente.email;
            cm.Parameters.Add("Endereco", MySqlDbType.VarChar).Value = cliente.endereco;
            var data = cliente.dataNascimento.ToString(CultureInfo.CreateSpecificCulture("pt-BR"));
            var hora = data.Split(" ");
            var dataeua = DateTime.Parse(hora[0]);
            cm.Parameters.Add("datanascimento", MySqlDbType.VarChar).Value = Convert.ToDateTime( hora[0]).ToString("yyyy/MM/dd");
            cm.Parameters.Add("senha", MySqlDbType.VarChar).Value = cliente.senha;
            cm.ExecuteNonQuery();
            

        }

        public void login(Cliente cliente)
        {
            MySqlCommand lg = new MySqlCommand ("select email, senha from Cliente ")
            
        }


    }
}
