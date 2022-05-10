using LocadoraA3.Controllers;
using LocadoraA3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraA3.Conexao
{
    public class conexaoDAO
    {
        ConexaoDB con = new ConexaoDB();

        public void CadCliente(Cliente cliente)
        {
            SqlCommand cm = new SqlCommand("Insert into cliente values (Default, @nome,@cpf,@endereco,@telefone,@email,@datanascimento,@senha)", con.MyConectarBD());
            cm.Parameters.Add("Nome", SqlDbType.VarChar).Value = cliente.nome;
            cm.Parameters.Add("CPF", SqlDbType.VarChar).Value = cliente.cpf;
            cm.Parameters.Add("Telefone", SqlDbType.VarChar).Value = cliente.telefone;
            cm.Parameters.Add("Email", SqlDbType.VarChar).Value = cliente.email;
            cm.Parameters.Add("Endereço", SqlDbType.VarChar).Value = cliente.endereco;
            cm.Parameters.Add("Endereço", SqlDbType.VarChar).Value = cliente.dataNascimento;
            cm.Parameters.Add("Endereço", SqlDbType.VarChar).Value = cliente.senha;

        }

    }
}
