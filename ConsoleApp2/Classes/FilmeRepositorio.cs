using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Interfaces;
using ConsoleApp2;

namespace Filmes
{
    internal class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilmes = new List<Filme>();

        public void Atualiza(int id, Filme entidade)
        {
            listaFilmes[id] = entidade;
        }


        public void Exclui(int id)
        {
            listaFilmes[id].Excluir();
        }

        public void Insere (Filme entidade)
        {
            listaFilmes.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return listaFilmes;
        }

        public int ProximoId()
        {
            return listaFilmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilmes[id];
        }
    }
}
