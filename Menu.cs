using System;

namespace mkt_management
{
    public class Menu
    {
        public string Entrada()
        {
            Console.Clear();
            Console.WriteLine("Mercado Estrela\n");
            Console.WriteLine("\t1 - Adicionar produto");
            Console.WriteLine("\t2 - Listar produtos");
            Console.WriteLine("\t3 - Remover produto");
            Console.WriteLine("\t0 - Encerrar programa");
            Console.Write("\nSelecione uma opcao: ");

            string opcao = Console.ReadLine();
            return opcao;
        }

        public void SetColor(string color)
        {
            if (color == "green")    Console.ForegroundColor = ConsoleColor.Green;
            else if (color == "red")    Console.ForegroundColor = ConsoleColor.Red;
            else    Console.ForegroundColor = ConsoleColor.Gray;
        }
        
        public void Continuar()
        {
            SetColor("");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}