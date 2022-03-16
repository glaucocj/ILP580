using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFolhaPgto
{
    class ClsValidacao
    {
        public static bool ConsisteLetras(Char entrada,Char ultimo)
        {
            if (Char.IsLetter(entrada) || 
                entrada == (char)32 || entrada == (char) 46 ||
                entrada == (char)8 || entrada ==(char)13) {
                if (ultimo != entrada || 
                    ((ultimo != (char)32 && entrada !=(char)32) && (ultimo != (char)46 && entrada != (char)46))
                    )
                {
                    return true;
                }
                return false;
            }
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
            Double.TryParse(entrada, out numero);
            if (numero > 0)  return true;
            else return false;
        }
        public static bool ConsisteNumInteiro(String entrada)
        {
            int numero;
            int.TryParse(entrada, out numero);
            if (numero > 0) return true;
            else return false;
        }

    }
}
