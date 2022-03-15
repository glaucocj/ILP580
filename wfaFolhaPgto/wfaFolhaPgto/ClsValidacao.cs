﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFolhaPgto
{
    class ClsValidacao
    {
        public static bool ConsisteLetras(Char entrada)
        {
            if (Char.IsLetter(entrada) || 
                entrada == (char)32 || entrada == (char) 46 ||
                entrada == (char)8)
                { return true; }
            else { return false; }
        }

        public static bool ConsisteNome (String nome)
        {
            if (nome == "") { return false; }
            else { return true; }
        }

        public static bool ConsisteNumReal(String entrada)
        {
            double numero;
            return Double.TryParse(entrada, out numero);
        }
        public static bool ConsisteNumInteiro(String entrada)
        {
            int numero;
            return int.TryParse(entrada, out numero);
        }

    }
}