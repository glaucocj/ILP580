﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFolhaPgto
{
    class Taxas
    {
        public static double CalculaINSS(double salBruto)
        {
            if (salBruto <= 965.67) return (salBruto * 0.08);
            else if (salBruto <= 1609.45) return (salBruto * 0.09);
            else if (salBruto <= 3218.9) return (salBruto * 0.11);
            else return (354.08);
        }

        public static double CalculaIR(double salBruto, int qtdDependentes)
        {
            double baseCalculo = salBruto-CalculaINSS(salBruto)-(189.59*qtdDependentes);
            if (baseCalculo <= 1903.98) return (0);
            else if (baseCalculo <= 2826.65) return (baseCalculo * 0.075);
            else if (baseCalculo <= 3751.05) return (baseCalculo * 0.15);
            else if (baseCalculo <= 4664.68) return (baseCalculo * 0.225);
            else return (baseCalculo * 0.275);
        }
    }
}
