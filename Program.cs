using System;

namespace mkt_management
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string opcao;
            bool repetir = true;

            do
            {
                opcao = menu.Entrada();

                switch (opcao)
                {
                    case "1":
                        menu.SetColor("green");
                        Console.WriteLine("Produto Adicionado");
                        menu.Continuar();
                        break;
                    case "2":
                        menu.SetColor("green");
                        Console.WriteLine("Lista de produtos");
                        menu.Continuar();
                        break;
                    case "3":
                        menu.SetColor("green");
                        Console.WriteLine("Produto removido");
                        menu.Continuar();
                        break;
                    case "0":
                        repetir = false;
                        Console.Clear();
                        break;
                    default:
                        menu.SetColor("red");
                        Console.WriteLine("Operação inválida");
                        menu.Continuar();
                        break;
                }
            } while (repetir == true);
        }
    }
}
