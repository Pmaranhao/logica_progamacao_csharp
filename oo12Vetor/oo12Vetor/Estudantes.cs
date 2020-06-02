using System;
using System.Collections.Generic;
using System.Text;

namespace oo12Vetor
{
    class Estudantes
    {
        public string Nome { get; set; }
        public string Email { get; set; }
      
        public Estudantes(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", "
                   + Email;
        }
    }
}
