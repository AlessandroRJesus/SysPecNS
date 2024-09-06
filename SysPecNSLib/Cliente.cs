using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime? Data_nasc { get; set; }
        public DateTime? Data_cad { get; set; }
        public bool Ativo { get; set; }


        public Cliente()
        {
            Id = 0;
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
        }
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }

        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }
        public void Inserir()
        {
            //Inserir os clientes no Banco de dados 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            cmd.Parameters.AddWithValue("spdatacad", Data_cad);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }


        public static Cliente ObterPorId(int id)

        {
            //puxar o cliente do Banco de dados pelo ID
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select *from cliente where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                         dr.GetInt32(0),
                         dr.GetString(1),
                         dr.GetString(2),
                         dr.GetString(3),
                         dr.GetString(4),
                         dr.GetDateTime(5),
                         dr.GetDateTime(6),
                         dr.GetBoolean(7)
                         );
            }
            return cliente;



        }
        public static List<Cliente> ObterLista(string? nome = "")
        {
            // lista de cliente
            List<Cliente> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if (nome == "")
            {
                comandosSQL.CommandText = "select *from cliente order by nome limit 10";
            }
            else
            {
                comandosSQL.CommandText = $"select *from cliente where nome like '%{nome}%' order by nome limit 10";
            }


            var dr = comandosSQL.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                     dr.GetInt32(0),
                     dr.GetString(1),
                     dr.GetString(2),
                     dr.GetString(3),
                     dr.GetString(4),
                     dr.GetDateTime(5),
                     dr.GetDateTime(6),
                     dr.GetBoolean(7)
                      )
                    );
            }

            return lista;
        }
        public void Atualizar()
        {
            // alterar nome e email e etc  
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Arquivar(int id)
        {
            //arquivar cliente inativos
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update usuarios set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static void Restaurar(int id)
        {
            // restaurar usuários que estavam inativos 
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update usuarios set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


    }
}
