using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        public Produto Produto { get; set; }
        public double Quantidade {get; set;}
        public DateTime Data_Ultimo {get; set;}

        public Estoque()
        {
        }
        public Estoque(Produto produto, double quantidade, DateTime data_ultimo)
        {
            Produto = produto;
            Quantidade = quantidade;
            Data_Ultimo = data_ultimo;
        }
        public Estoque(double quantidade, DateTime data_ultimo)
        {
            Quantidade = quantidade;
            Data_Ultimo = data_ultimo;
        }


        public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"INSERT INTO estoques (produto_id, quantidade, data_ultimo_movimento) VALUES ('{Produto}','{Quantidade}', '{Data_Ultimo}'";
            cmd.CommandText = "sp_estoque_inserir";
            cmd.Parameters.AddWithValue("sp_produtoid", Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdata_ultimo", Data_Ultimo);
            cmd.Connection.Close();
        }
        public static Estoque ObterPorId(int produto_id)
        {
            Estoque estoque= new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select *from estoques where produto_id = {produto_id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                estoque = new(
                   Produto.ObterPorId(dr.GetInt32(0)),
                     dr.GetDouble(1),
                     dr.GetDateTime(2)
                     );
            }
            cmd.Connection.Close();
            return estoque;
        }
        public static List<Estoque> ObterLista(string? produto= "")
        {
          
            List<Estoque> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (produto == "")
            {
                cmd.CommandText = "select *from estoques order by produto_id limit 10";
            }
            else
            {
                cmd.CommandText = $"select *from estoques where n like '%{produto}%' order by produto_id limit 10";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                     Produto.ObterPorId(dr.GetInt32(0)),
                     dr.GetDouble(1),
                     dr.GetDateTime(2)
                      )
                    );
            }
            cmd.Connection.Close();
            return lista;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update estoques" + $"set quantidade = '{Quantidade}', data_ultimo_movimento = '{Data_Ultimo}' where produto_id = {Produto}";
            cmd.Connection.Close();
            cmd.ExecuteReader();
        }



    }

}
