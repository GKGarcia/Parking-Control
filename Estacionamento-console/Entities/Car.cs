using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using Estacionamento_console;
using Estacionamento_console.Entities.Enums;

namespace Estacionamento_console.Entities
{
    internal class Car : Driver
    {

        public string Model { get; set; }
        Color Color { get; set; }
        public string Plate { get; set; }
        public string EntryTime { get; set; }
        public string ExitTime { get; set; }
        List<Car> list = new List<Car>();


        public Car() { }

        public Car(string name, string cpf, string model, Color color, string plate) : base(name, cpf)
        {
            Model = model;
            Color = color;
            Plate = plate;
            Entrytime();
        }

        public void Menu()
        {
            Console.WriteLine("BEM VINDO AO MENU ");
            Console.WriteLine("1- Cadastrar Motorista");
            Console.WriteLine("2- Veiculos Estacionados");
            Console.WriteLine("3- Registrar Saida de Veiculo");
            Console.WriteLine("4- Buscar Veiculos");
            Console.WriteLine("5- Listar Veiculos");
            Console.WriteLine("6- SAIR");
            Console.Write("Digite uma opção:");
        }

        public void Entrytime()
        {
            EntryTime = DateTime.Now.ToString();
            Console.WriteLine(EntryTime);
        }

        public void RegisterExit()
        {
            ExitTime = DateTime.Now.ToString();
        }

        public void RegisterDriver()
        {
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
            Console.Write("Data e Horario de Entrada:");

            list.Add(new Car(Name, Cpf, Model, Color, Plate));

            Console.WriteLine();
            Console.WriteLine("Veiculo Cadastrado!");

            Console.ReadKey();
            Console.Clear();
        }

        public void ParkedVehicles()
        {
            int aux = list.Count;

            Console.WriteLine("VEICULOS ESTACIONADOS:");
            Console.WriteLine();

            if (list.Count != 0)
            {
                foreach (var obj in list)
                {
                    if (obj.ExitTime == null)
                    {
                        Console.WriteLine(obj);
                        Console.WriteLine();
                    }
                    else
                    {
                        aux--;
                    }
                    if (aux == 0)
                    {
                        Console.WriteLine("Nenhum veiculo estacionado!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nenhum veiculo estacionado!");
            }

            Console.ReadKey();
            Console.Clear();
        }

        public void Exit()
        {
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

                    if (decision == 's' || decision == 'S')
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
        }

        public void SearchVehicles()
        {
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
        }

        public void ListVehicles()
        {
            int aux = list.Count;

            Console.WriteLine("Lista de Veiculos:");
            Console.WriteLine();

            if (list.Count != 0)
            {
                foreach (var obj in list)
                {
                    if (obj.ExitTime != null)
                    {
                        Console.WriteLine(obj);
                        Console.WriteLine("Horario de saida:" + obj.ExitTime);
                        Console.WriteLine();
                    }
                    else
                    {
                        aux--;
                    }
                    if (aux == 0)
                    {
                        Console.WriteLine("Nenhuma Saida Registrada!");
                    }
                }
            }
            else 
            {
                Console.WriteLine("Nenhuma Saida Registrad!"); 
            }

            Console.ReadKey();
            Console.Clear();
        }

        public override string ToString()
        {
            return "Carro:" + Model + "\n" +
                   "Cor :" + Color + "\n" +
                   "Placa:" + Plate + "\n" +
                   "Motorista:" + Name + "\n" +
                   "CPF:" + Cpf + "\n" +
                   "Data e Horario de Entrada:" +
                   EntryTime;
        }




    }
}
