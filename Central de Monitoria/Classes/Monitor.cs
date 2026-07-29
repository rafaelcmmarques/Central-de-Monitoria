using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Central_de_Monitoria.Classes
{
    internal class Monitor : Pessoas
    {
        private string disciplina;
        private int quantidadeAtendimentos;

        public string Disciplina
        {
            get => disciplina;
            set => disciplina = value;
        }

        public int QuantidadeAtendimentos
        {
            get => quantidadeAtendimentos;
            private set => quantidadeAtendimentos = value;
        }

        public Monitor() : base()
        {
            this.quantidadeAtendimentos = 0;
        }

        public void RegistrarAtendimento()
        {
            this.quantidadeAtendimentos++;
        }

        public override void Cadastrar()
        {
            base.Cadastrar();

            bool disciValida = false;
            while (!disciValida)
            {
                Console.Write("\nDigite a Disciplina: ");
                Disciplina = Console.ReadLine();

                if (Disciplina.Trim().Length < 3)
                {
                    Console.WriteLine("ERRO: A disciplina deve conter ao menos 3 caracteres! [Exemplo: LP2]");
                }
                else
                {
                    disciValida = true;
                }
            }
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"\n[Monitor] Nome: {Nome} | Email {Email} | Disciplina: {Disciplina} | Atendimentos: {QuantidadeAtendimentos}");
        }
    }
}
