using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Produtos

    {
        public static List<Produtos> produtos;

        public string Nome { get; set; }
        public string viagem { get; set; }
        public status status { get; set; }
        public bool chapa { get; set; }


        public Produtos(string nome, string viagem, status status, bool chapa)
        {
            Nome = nome;
            this.viagem = viagem;
            this.status = status;
            this.chapa = chapa;
        }
    }
   
}
