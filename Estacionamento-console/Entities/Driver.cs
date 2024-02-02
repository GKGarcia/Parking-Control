using System;
using System.Collections.Generic;


namespace Estacionamento_console.Entities
{
    internal class Driver
    {

        public string Name { get; set; }
        public string Cpf { get; set; }

        public Driver() { } 
        public Driver(string name, string cpf)
        {
            Name = name;
            Cpf = cpf;
        }

        

        
        

    }
    
}
