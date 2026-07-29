using System;
using System.Collections.Generic;
using System.Text;

namespace Central_de_Monitoria.Classes
{
    internal class Pessoas
    {
        private string nome;
        private string email;

        // Properties públicas que controlam o acesso[cite: 10, 14]
        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public Pessoas() { }

        public virtual void Cadastrar()
        {
            bool nomeValido = false;
            while (!nomeValido)
            {
                Console.Write("\nDigite o nome: ");
                Nome = Console.ReadLine();

                if (Nome.Trim().Length < 2)
                {
                    Console.WriteLine("ERRO: O nome deve conter ao menos 2 CARACTERES!");
                }

                else
                {
                    nomeValido = true;
                }
            }

            bool emailValido = false;
            while (!emailValido)
            {

                Console.Write("\nDigite o email: ");
                Email = Console.ReadLine();

                if (Email.Trim().Length < 11 || !Email.Contains("@") || !Email.Contains("."))
                {
                    Console.WriteLine("ERRO: O email deve conter ao menos 11 CARACTERES, além de um '@' e um '.' [Exemplo: a@gmail.com ");
                }
                else
                {
                    emailValido = true;
                }
            }
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} | Email: {Email}");
        }
    }
}
