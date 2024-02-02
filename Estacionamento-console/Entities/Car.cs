using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Estacionamento_console.Entities
{
    internal class Car : Driver
    {

        

        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }

        public Car() { }
        public Car(string nome, string cpf, string modelo, string cor, string placa) : base(nome, cpf)
        {
            Modelo = modelo;
            Cor = cor;
            Placa = placa;
        }


        public override string ToString()
        {
            return "Carro:"+ Modelo + "\n"+
                   "Cor :" + Cor + "\n" +
                   "Placa:"+ Placa +"\n" +
                   "Motorista:" + Nome + "\n" +
                   "CPF:" + Cpf;
        }





    }
}
