using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Usuario
    {
      
        public int Id {get; set;}
        public string? Nome { get; set;}
        public string? Email { get; set;}
        public string? Senha { get; set;}
        public Nivel Nivel { get; set;}
        public bool Ativo { get; set;}


      
        public Usuario()
        {
            Nivel = new();
        }


        public Usuario( string? nome, string? email, string? senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        public Usuario(string? nome, string? email, string? senha, Nivel nivel, bool ativo)
        {
           
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        public Usuario(int id, string? nome, string? email, string? senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        public void Inserir() 
        {
            //Inserir os Usuarios no Banco de dados 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                Id = dr.GetInt32(0);
            }
        }
        /// <summary>
        /// Obter por id é um método estatico que retorna 
        /// um objeto usuario completo baseado no id informado
        /// </summary>
        /// <param name ="id">id do usuario buscado </param>
        /// <returns> objeto usuario com todos os campos</returns>

        public static Usuario ObterPorId(int id)
        {
            // puxar o usuario do Banco de dados pelo id
            Usuario usuario = new();
            var cmd = Banco.Abrir();  
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = $"select *from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            { 
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }

            return usuario;
        }
        public static List<Usuario> ObterLista()
        {
            // lista de usuarios 
            List<Usuario> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            comandosSQL.CommandText = "select *from usuarios order by nome limit 10";
            var dr = comandosSQL.ExecuteReader();
            while(dr.Read()) 
            {
                lista.Add(
                    new (
                         dr.GetInt32(0),
                         dr.GetString(1),
                         dr.GetString(2),
                         dr.GetString(3),
                         Nivel.ObterPorId(dr.GetInt32(4)),
                         dr.GetBoolean(5)
                        )
                    );
            }
            
            return lista;
        }

        public static Usuario EfetuarLogin(string email, string senha)
        {

            // O usuario terá que efetuar Login
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select *from usuarios where email = '{email}' and senha = md5('{senha}')";
           var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                       dr.GetInt32(0),
                       dr.GetString(1),
                       dr.GetString(2),
                       dr.GetString(3),
                       Nivel.ObterPorId(dr.GetInt32(4)),
                       dr.GetBoolean(5)
                      );



            }
            
            return usuario;

        }

        public void Atualizar()
        {
            // O Usuario poderar alterar nome e senha e o nivel 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            //cmd.Parameters.Add("spid",MySqlDbType.Int32).value = Id;
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Arquivar(int id)
        {
            //arquivar usuarios inativos
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update usuarios set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery ();
            cmd.Connection.Close ();    

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
