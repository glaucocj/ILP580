using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCalculos
{
    class ClsValida
    {
        public static char ConsisteNum(char c)
        {
            if (((c < '0') || (c > '9')) && c != ',' && c != (char)8)
            {
                c = (char)0;
            }
            return c;
        }

        public static char SoUmaVirgula(string texto)
        {
            int i;
            i = texto.IndexOf(',');
            if (i >= 0)
            {
                return (char)0;
            }
            else
            {
                return (',');
            }
        }

        //public static char ConsisteNumReal (char c,string texto)
        //{

        //}
    }
}
