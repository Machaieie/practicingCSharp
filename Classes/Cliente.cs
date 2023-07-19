using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edwin_Work
{
    class Cliente
    {
        private string _Nome;
        private string _Apelido;
        private string _Telefone;
        private string _Email;
        private double _Saldo;


        public Cliente(string nome,string apelido,string telefone,string email, double saldo)
        {
            _Nome = nome;
            _Apelido = apelido;
            _Telefone = telefone;
            _Email = email;
            _Saldo = saldo;
        }

        public Cliente() { }
        public String Nome
        {
            get { return _Nome; }
            set { if (value != null)
                {
                     _Nome = value;
                } }
        }

        public String Apelido
        {
            get { return _Apelido; }
            set
            {
                if (value != null)
                {
                    _Apelido = value;
                }
            }
        }

        public String Telefone
        {
            get { return _Telefone; }
            set
            {
                if (value != null)
                {
                    _Telefone = value;
                }
            }
        }

        public String Email
        {
            get { return _Email; }
            set
            {
                if (value != null)
                {
                    _Email = value;
                }
            }
        }
        public double Saldo
        {
            get { return _Saldo; }
            set
            {
                if (value >0)
                {
                    _Saldo = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Nome: {_Nome} , Apelido: {_Apelido} , Telefone: {_Telefone} , Email: {_Email} , Saldo: {_Saldo}";
        }
        public void Depositar(double valor)
        {
            
        }

        public bool Sacar(double valor)
        {
            if (valor <= _Saldo)
            {
                Saldo -= valor;
                return true;
            }

            return false;
        }
    }
}
