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
            
            Car car = new Car();
            Driver driver = new Driver();

            string name;
            int opcao = 0;

            while (opcao != 6)
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
        }

     
    }
}