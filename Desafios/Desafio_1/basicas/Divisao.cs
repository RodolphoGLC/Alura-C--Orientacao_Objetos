﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.basicas
{
    public class Divisao
    {
        public double Calcular(double dividendo, double divisor) 
        {
            if(divisor== 0) 
            {
                return 0;
            }
            return dividendo / divisor;
        }
    }
}
