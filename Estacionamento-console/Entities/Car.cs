using System;
using System.Collections.Generic;


namespace Estacionamento_console.Entities
{
    internal class Car : Driver
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Plate { get; set; }

        public Car() { }

        public Car(string name, string cpf, string model, string color, string plate) : base(name, cpf)
        {
            Model = model;
            Color = color;
            Plate = plate;
        }

        public override string ToString()
        {
            return "Carro:" + Model + "\n" +
                   "Cor :" + Color + "\n" +
                   "Placa:" + Plate + "\n" +
                   "Motorista:" + Name + "\n" +
                   "CPF:" + Cpf;
        }
    }
}
