using System;
using System.Collections.Generic;
using System.Net;
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
        public Car() { }

        public Car(string name, string cpf, string model, Color color, string plate, string entrytime) : base(name, cpf)
        {
            Model = model;
            Color = color;
            Plate = plate;
            EntryTime = entrytime;
        }

       

        public Car(string exittime)
        {
            ExitTime = exittime;
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

        public void RegisterExit()
        {
            ExitTime= DateTime.Now.ToString();
        }
        
    }
}
