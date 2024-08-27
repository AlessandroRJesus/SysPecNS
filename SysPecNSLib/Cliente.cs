using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Cliente
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email  { get; set; }
        public DateTime? Data_nasc{ get; set; }
        public DateTime? Data_cad {  get; set; }
        public string? Ativo { get; set; }


        public Cliente()
        {
         
        }


        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad, string? ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }


    }

}
