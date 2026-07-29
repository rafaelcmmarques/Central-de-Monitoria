using System;
using System.Collections.Generic;
using System.Text;

namespace Central_de_Monitoria.Classes
{
    internal class Estudante : Pessoas 
    {
        private string turma;
        private string prontuario;

        public string Turma
        {
            get => turma;
            set => turma = value;
        }

        public string Prontuario
        {
            get => prontuario;
            set => prontuario = value;
        }

        public Estudante() : base() { }

        public override void Cadastrar()
        {
            base.Cadastrar();

            bool turmaValida = false;
            while(!turmaValida)
            {
                Console.Write("\nDigite a Turma: ");
                Turma = Console.ReadLine();

                if (Turma.Trim().Length < 7)
                {
                    Console.WriteLine("ERRO: A turma deve conter ao menos 7 CARACTERES! [sigla do curso + n° -> Exemplo: CTII 217]");
                }
                else
                {
                    turmaValida = true;
                }
            }

            bool prontuarioValido = false;
            while (!prontuarioValido)
            {
                Console.Write("\nDigite o Prontuário: ");
                Prontuario = Console.ReadLine();

                if (Prontuario.Trim().Length < 3)
                {
                    Console.WriteLine("ERRO: O prontuário deve conter ao menos 3 CARACTERES! [CB + n° -> Exemplo: 'CB1']");
                }
                else
                {
                    prontuarioValido = true;
                }
            }
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"\n[Estudante] - Nome: {Nome} | Email: {Email } | Prontuário: {Prontuario} | Turma: {Turma}");
        }
    }
}
