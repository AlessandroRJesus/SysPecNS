using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Endereco
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Tipo { get; set; }

        public Endereco()
        {
            Cliente = new(); 
        }
        //public Endereco(int id, Cliente Idcliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo)
        //{
        //    Id = id;
        //    Cliente = Idcliente;
        //    Cep = cep;
        //    Logradouro = logradouro;
        //    Numero = numero;
        //    Complemento = complemento;
        //    Bairro = bairro;
        //    Cidade = cidade;
        //    Uf = uf;
        //    Tipo = tipo;
        //}
        public Endereco(int id, Cliente Idcliente, string? cep, string? logradouro, string? numero, string? bairro, string? cidade, string? uf, string? tipo)
        {
            Id = id;
            Cliente = Idcliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo = tipo;
        }

        public Endereco(Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo)
        {
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo = tipo;
        }

        public void Inserir()
        {
            //Inserir o endereco do cliente no Banco de dados 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Cidade);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }
        public static Endereco ObterPorId(int id)
        {
            // puxar o Endereco do cliente pelo id no Banco de dados 
            Endereco endereco= new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select *from endereco where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                endereco = new(
                    Cliente.ObterPorId(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                    );
            }

            return endereco;
        }
        public static List<Endereco> ObterLista(string? cliente_id = "")
        {
            // lista do Endereco do cliente 
            List<Endereco> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if (cliente_id == "")
            {
                comandosSQL.CommandText = "select *from endereco order by cliente_id limit 10";
            }
            else
            {
                comandosSQL.CommandText = $"select *from endereco where cliente_id like '%{cliente_id}%' order by nome limit 10";
            }


            var dr = comandosSQL.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                    Cliente.ObterPorId(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                        )
                    );
            }

            return lista;
        }
        public void Atualizar()
        {
            // podera atualizar todos os campos da classe endereço 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_update";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spcep",Cep);
            cmd.Parameters.AddWithValue("splogradouro",Logradouro);
            cmd.Parameters.AddWithValue("spnumero",Numero);
            cmd.Parameters.AddWithValue("spcomplemento",Complemento);
            cmd.Parameters.AddWithValue("spbairro",Bairro);
            cmd.Parameters.AddWithValue("spcidade",Cidade);
            cmd.Parameters.AddWithValue("spuf",Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco",Tipo);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


    }
}