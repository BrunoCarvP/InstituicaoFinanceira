using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace controleDeContas
{
    public class Conta
    {
        public Conta(long numero, Cliente titular, string banco)
        {
            Numero = numero;
            Titular = titular;
            banco = banco;

        }

        public long Numero { get; private set; }
        public decimal Saldo { get; set; }
        public string Banco { get; set; }
        public Cliente Titular { get; set; }




        public void Deposito(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }
        public void Saque(decimal valor)
        {
            if (valor > 0)
            {

                Saldo -= (valor + 0.10m);
            }
        }
        public void Transferencia(Conta contaDestino, decimal valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                contaDestino.Deposito(valor);
            }
        }

    }

}
