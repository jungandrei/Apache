using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco
{
    public class Cadastro
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtor para não
        public Cadastro(int numero, string titular) 
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        //Construtor para sim
        public Cadastro(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia - 5.00;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
