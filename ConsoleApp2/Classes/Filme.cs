using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Filme:EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private int AnoInicio { get; set; }
        private string Descricao { get; set; }
        private bool Excluido { get; set; }

        public Filme(int id, Genero genero, string titulo, int ano, string descricao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.AnoInicio = ano;
            this.Descricao = descricao;
            this.Excluido = false;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }
        
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }


        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.AnoInicio + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;

            return retorno;
        }

    }
}
