using System;

namespace Filmes
{
    class Program
    {
        private static FilmeRepositorio repositorio = new FilmeRepositorio();
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");

            Console.WriteLine();

            string opcao = Console.ReadLine().ToUpper();

            Console.WriteLine();

            return opcao;
        }

        private static void ListarFilmes()
        {
            Console.WriteLine("Listar Filmes");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado");
                return;
            }

            foreach (var filme in lista)
            {
                var excluido = filme.RetornaExcluido();
                Console.WriteLine("{0} - {1} - {2}", filme.RetornaId, filme.RetornaTitulo, excluido ? "Excluido" : "");
            }
        }

        private static void Main(string[] args)
        {
            string opcao = ObterOpcaoUsuario();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        ListarFilmes();
                        break;/*

                    case "2":
                        InserirFilme();
                        break;

                    case "3":
                        AtualizarFilme();
                        break;

                    case "4":
                        Excluir();
                        break;

                    case "5":
                        VisualizarFilme();
                        break;*/

                    case "C":
                        Console.Clear();
                        break;

                }
                opcao = ObterOpcaoUsuario();

            }
        }
    }
}
