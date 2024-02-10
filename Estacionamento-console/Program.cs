using Estacionamento_console.Entities;
using Estacionamento_console.Entities.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;


namespace Estacionamento_console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> list = new List<Car>();
            Car car = new Car();
            Driver driver = new Driver();

            string name; 

            int opcao = 0;

            while (opcao != 6)
            {

                Console.WriteLine("BEM VINDO AO MENU ");
                Console.WriteLine("1- Cadastrar Motorista");
                Console.WriteLine("2- Veiculos Estacionados");
                Console.WriteLine("3- Registrar Saida de Veiculo");
                Console.WriteLine("4- Buscar Veiculos");
                Console.WriteLine("5- Listar Veiculos");
                Console.WriteLine("6- SAIR");
                Console.Write("Digite uma opção:");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
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
                        Color Color = Enum.Parse<Color>(Console.ReadLine());
                        Console.WriteLine("Digite a placa do veiculo:");
                        string Plate = Console.ReadLine();
                        Console.WriteLine("Data e Horario de Entrada:");
                        string EntryTime = Console.ReadLine();

                        list.Add(new Car(Name,Cpf,Model,Color,Plate,EntryTime));


                        Console.WriteLine();
                        Console.WriteLine("Veiculo Cadastrado!");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        
                        Console.WriteLine("VEICULOS ESTACIONADOS:");
                        Console.WriteLine();

                       
                            foreach (var obj in list)
                            {

                                if (obj.ExitTime == null)
                                {
                                    Console.WriteLine(obj);
                                
                               
                                    Console.WriteLine();
                            }
                          
                            }
                       
                        

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do motorista ou a placa do carro:");
                        string Exit = Console.ReadLine();
                        Console.WriteLine();
                        foreach (var obj in list)
                        {
                            if (Exit == obj.Plate && obj.ExitTime == null || Exit == obj.Name && obj.ExitTime == null)
                            {
                                Console.WriteLine("MOTORISTA ENCONTRADO");
                                Console.WriteLine();
                                Console.WriteLine(obj);
                                Console.WriteLine();

                                Console.WriteLine("Tem certeza que deseja registrar a saida?(s/n)");
                                char decision = char.Parse(Console.ReadLine());
                                Console.WriteLine();

                                if (decision == 's'|| decision =='S')
                                {
                                    Console.WriteLine("Saida Registrada!");
                                    obj.RegisterExit();

                                }
                                else
                                {
                                    Console.WriteLine("Registro de saida cancelado!");
                                }

                                Console.ReadKey();
                                Console.Clear();

                            }
                        }
                        Console.WriteLine();

                        break;
                    case 4:

                        Console.WriteLine("Digite o nome do motorista ou a placa do carro:");
                        string search = Console.ReadLine();
                        foreach (var obj in list)
                        {
                            if (search == obj.Name || search == obj.Plate)
                            {
                                Console.WriteLine("Motorista Encontrado!");
                                Console.WriteLine(obj);
                            }
                            else
                            {
                                Console.WriteLine("Placa ou motorista invalidos!");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;
                    case 5:

                        Console.WriteLine("Lista de Veiculos:");
                        Console.WriteLine();

                        foreach (var obj in list)
                        {
                            if (obj.ExitTime!= null)
                            {
                                Console.WriteLine(obj);
                                Console.WriteLine("Horario de saida:" + obj.ExitTime);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Saidas de veiculos ainda não registrada!");
                            }
                          
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                }



            }
        }

     
    }
}