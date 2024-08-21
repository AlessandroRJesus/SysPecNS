using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



namespace SysPecNSLib
{
    public class Nivel
    {
        //atributo (campo)
        //private int id;
       // private string nome;
        //private string sigla;

        

        //propriedades

        public int Id {  get; set; } 
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

       // métodos de acesso (get e set)
       
        //public int Id { get => id; set => id = value; }

        
        //métodos construtores

        public Nivel() { }

        public Nivel(string nome, string sigla) // sobrecarga de métodos 
        { 
            Nome = nome;
            Sigla = sigla;
        } 
        public Nivel (int id, string nome, string sigla)
        { 
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        //métodos (requisitos)
        /// <summary>
        /// Método para inserir registro de nivel na base de dados
        /// </summary>
        public void Inserir() 
        {
            //conectado com  o banco de dados
            var cmd = Banco.Abrir(); 
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert niveis (nome, sigla) values ('{Nome}','{Sigla}')";
            cmd.ExecuteNonQuery();
        }
        public static Nivel ObterPorId(int  id) 
        {
            Nivel nivel = new Nivel();
            // consulta no banco e retornar o nivel
            var cmd = Banco.Abrir();
            //cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText = $"select * from niveis where id = {id};";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }

            return nivel;
        }

        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new List<Nivel>();
            // consulta para retornar a lista de niveis 
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select *from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                lista.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));
            }
            return lista;
        }
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update niveis set nome = '{Nome}',sigla = '{Sigla}' where id = {id}";
            if (cmd.ExecuteNonQuery() > 0)
                return true;        
            else
                return false;
        }
        public void Excluir(int id)
        {
            
        }

    }
}
