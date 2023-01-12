using Desafio_1.basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Operacoes
    {
        public Soma Soma { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }
        public Divisao Divisao { get; private set; }

        public Operacoes() 
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Multiplicacao = new Multiplicacao();
            this.Divisao = new Divisao();
        }
    }
}
