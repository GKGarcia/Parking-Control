using System;
using System.Collections.Generic;


namespace Estacionamento_console.Entities
{
    internal class Driver
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Driver() { } 
        public Driver(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        

        
        

    }
    
}
