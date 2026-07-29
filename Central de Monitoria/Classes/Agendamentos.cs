using System;
using System.Collections.Generic;
using System.Text;

namespace Central_de_Monitoria.Classes
{
    internal class Agendamentos
    {
        private Estudante estudante;
        private Monitor monitor;
        private string data;
        private string horario;
        private string assunto;
        private bool concluido;

        public Estudante Estudante
        {
            get => estudante;
            set => estudante = value;
        }

        public Monitor Monitor
        {
            get => monitor;
            set => monitor = value;
        }

        public string Data
        {
            get => data;
            set => data = value;
        }

        public string Horario
        {
            get => horario;
            set => horario = value;
        }

        public string Assunto
        {
            get => assunto;
            set => assunto = value;
        }

        public bool Concluido
        {
            get => concluido;
            private set => concluido = value;
        }

        public Agendamentos(Estudante estudante, Monitor monitor, string data, string horario, string assunto)
        {
            Estudante = estudante;
            Monitor = monitor;
            Data = data;
            Horario = horario;
            Assunto = assunto;
            Concluido = false;
        }

        public void ConcluirAgendamento()
        {
            if (!Concluido)
            {
                Concluido = true; 
                Monitor.RegistrarAtendimento(); 
                Console.WriteLine("\nMonitoria concluída com sucesso!");
            }
            else
            {
                Console.WriteLine("\nEste agendamento já estava concluído!");
            }
        }

        public void ExibirResumo()
        {
            string status = Concluido ? "CONCLUÍDO" : "PENDENTE";
            Console.WriteLine($"\nSITUAÇÃO: {status}");
            Console.WriteLine($"\nDATA: {Data} às {Horario}h | ASSUNTO: {Assunto}");
            Console.WriteLine($"\nMONITOR: {Monitor.Nome} | DISCIPLINA: {Monitor.Disciplina}");
            Console.WriteLine($"\nESTUDANTE: {Estudante.Nome} | TURMA: {Estudante.Turma}");
        }
    }
}
