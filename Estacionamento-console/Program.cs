using Estacionamento_console.Entities;
using System;
using System.Collections.Generic;
namespace Estacionamento_console
{
    class Program
    {
        static void Main(string[] args) {

           List<Driver> list = new List<Driver>();
       
           int opcao = 0;  

            while (opcao != 6) {

                Console.WriteLine("BEM VINDO AO MENU ");
                Console.WriteLine("1- Cadastrar Motorista");
                Console.WriteLine("2- Veiculos Estacionados");
                Console.WriteLine("3- Registrar Saida de Veiculo");
                Console.WriteLine("4- Buscar Veiculos");
                Console.WriteLine("5- Listar Veiculos");
                Console.WriteLine("6- SAIR");
                Console.Write("Digite uma opção:");
                opcao =int.Parse(Console.ReadLine());

                Console.Clear();
                
              switch (opcao) {
                    case 1:

                        Console.WriteLine("CADASTRO DE MOTORISTA:");
                        Console.WriteLine();
                        Console.WriteLine("Digite o nome do motorista:");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do motorista:");
                        string Cpf = Console.ReadLine();
                        Console.WriteLine("Digite o modelo do veiculo:");
                        string Model = Console.ReadLine();
                        Console.WriteLine("Digite a cor do veiculo:");
                        string Color = Console.ReadLine();
                        Console.WriteLine("Digite a placa do veiculo");
                        string Plate = Console.ReadLine();

                        list.Add(new Car(Name, Cpf, Model, Color, Plate));

                        Console.WriteLine();
                        Console.WriteLine("Veiculo Cadastrado!");

                        Console.ReadKey();
                        Console.Clear();
                         break;
                    case 2:
                        
                        Console.WriteLine("VEICULOS ESTACIONADOS:");
                        Console.WriteLine();

                        foreach (Driver obj in list)
                        {
                            Console.WriteLine(obj);
                            Console.WriteLine();
                        }

                        Console.ReadKey();
                        Console.Clear();
                     break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                }



                }
        }
    }
}