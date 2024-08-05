using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            linguagem linguagem = new linguagem();
            List<linguagem> ling = new List<linguagem>();
            Programador programador = new Programador();
            List<Programador> programadors = new List<Programador>();

            while (true)
            {
                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine("1- cadastrar linguagem");
                Console.WriteLine("2- cadastrar programador");
                Console.WriteLine("3- ver linguagens cadastradas");
                Console.WriteLine("4- ver programadores cadastradas");


                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1: 
                        Console.WriteLine("Digite o nome da linguagem: ");
                        linguagem.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o codigo da linguagem: ");
                        linguagem.codLinguagem = Console.ReadLine();
                        Console.WriteLine("Digite o tipo da linguagem: ");
                        linguagem.Tipo = Console.ReadLine();

                        ling.Add(linguagem);
                    break;

                    case 2:
                        Console.WriteLine("Digite o nome do programador: ");
                        programador.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o codigo do programador: ");
                        programador.Cod = Console.ReadLine();
                        Console.WriteLine("Digite a linguagem do programador: ");
                        programador.ling = Console.ReadLine();
                        Console.WriteLine("Digite os anos de experiencia: ");
                        programador.anosExp = Convert.ToInt32(Console.ReadLine());

                        programadors.Add(programador);
                    break;
                    case 3:

                        foreach (var item in ling)
                        {
                            Console.WriteLine($"{item.Nome} || {item.codLinguagem} || {item.Tipo}");
                        }
                        break;

                    case 4:

                        foreach(var item  in programadors)
                        {
                            Console.WriteLine($"{item.Nome} || {item.Cod} || {item.ling} || {item.anosExp} anos.");
                            if(item.anosExp <= 5 && item.ling == "php")
                                {
                                    Console.WriteLine($"{item.Nome} || {item.Cod} || {item.ling} || {item.anosExp} anos.");

                                }
                                else
                                {
                                    Console.WriteLine("Item nao encontrado:");
                                }
                        }
                        break;


                }
            }

        }
    }
}
