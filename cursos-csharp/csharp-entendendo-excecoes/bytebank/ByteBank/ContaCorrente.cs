// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static double TaxaOperacao { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            private set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            //TaxaOperacao = 30 / TotalDeContasCriadas;
            if (agencia <= 0)
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            if (numero <= 0)
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));

            TotalDeContasCriadas++;
        }

        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Saldo insuficiente para saque no valor de " + valor);
                //return false;
            }

            _saldo -= valor;
            //return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
