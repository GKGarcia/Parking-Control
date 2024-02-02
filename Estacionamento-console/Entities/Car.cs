using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento_console.Entities
{
    internal class Carro
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Placa { get; set; }
        public string ModeloCar { get; set; }
        public string Cor { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSaida { get; set; }

        public Carro(string nome, string cpf, string placa, string modeloCar, string cor, string horaEntrada, string horasaida)
        {
            Nome = nome;
            Cpf = cpf;
            Placa = placa;
            ModeloCar = modeloCar;
            Cor = cor;
            HoraEntrada = horaEntrada;
            HoraSaida = horasaida;
        }
    }
}
