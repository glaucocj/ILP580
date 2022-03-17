using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaOO
{
    class Conta
    {
        public int Conta_Nro { get; set; }

        public double Conta_Saldo { get; private set; }

        public double Conta_Limite { get; set; }

        public string Conta_Titular { get; set; }

        public int Conta_Tipo { get; set; }

        public void Sacar(double valor)
        {
            if(this.Conta_Tipo == 1)
            {
                if (this.Conta_Saldo < valor)
                {
                    throw new System.ArgumentException("Saldo Indisponível");
                }
                else
                {
                    this.Conta_Saldo -= valor;
                }
            }
            else if (this.Conta_Saldo + this.Conta_Limite < valor)
            {
                throw new System.ArgumentException("Saldo Indisponível");
            }

            else
            {
                double saldo_dif = this.Conta_Saldo + this.Conta_Limite;
                if (this.Conta_Saldo > valor) { this.Conta_Saldo -= valor; }
                else
                {
                    saldo_dif = valor - this.Conta_Saldo;
                    this.Conta_Saldo = 0;
                    this.Conta_Limite -= saldo_dif;
                }
            }
        }

    public void Depositar(double valor)
        {
            this.Conta_Saldo += valor;
        }


    }
}
