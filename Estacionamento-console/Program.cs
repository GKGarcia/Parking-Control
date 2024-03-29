﻿using Estacionamento_console.Entities;
using Estacionamento_console.Entities.Enums;
using System;
using System.Collections;
using System.Collections.Generic;



namespace Estacionamento_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            Driver driver = new Driver();


            int opcao = 0;

           
                while (opcao != 6)
                {
                try
                {
                    car.Menu();
                    opcao = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (opcao)
                    {
                        case 1:

                            car.RegisterDriver();

                            break;
                        case 2:

                            car.ParkedVehicles();

                            break;
                        case 3:

                            car.Exit();

                            break;
                        case 4:

                            car.SearchVehicles();

                            break;
                        case 5:

                            car.ListVehicles();

                            break;

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            
        }
    }

} 

