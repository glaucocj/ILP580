using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaPessoa
{
    class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public static bool ValidaCNPJ (string numero)
        {
            if (numero == "") { return true; }
            if (numero.Length < 14) { return false; }
            int tamanho = numero.Length-2;
            int soma = 0;
            int fator = 5;
            int digito;
            for (int i = 0; i < tamanho; i++)
            {
                soma += int.Parse(numero.Substring(i,1))*fator;
                
                fator -= 1;

                if (fator == 1) { fator = 9; }
            }

            int resto = soma % 11;

            if (resto == 0 || resto == 1)
            {
                digito = 0;
            }
            else
            {
                digito = 11 - resto;
            }

            if (int.Parse(numero.Substring(12, 1)) != digito) { return false; }

            fator = 6;
            tamanho += 1;
            soma = 0;
            for (int i = 0; i < tamanho; i++)
            {
                soma += int.Parse(numero.Substring(i, 1)) * fator;

                fator -= 1;

                if (fator == 1) { fator = 9; }
            }

            resto = soma % 11;

            if (resto == 0 || resto == 1)
            {
                digito = 0;
            }
            else
            {
                digito = 11 - resto;
            }

            if (int.Parse(numero.Substring(13, 1)) != digito) { return false; }

            return true;
        }



    }

}
