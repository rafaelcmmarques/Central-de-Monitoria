using System;
using System.Collections.Generic;
using System.Text;

namespace Central_de_Monitoria.Classes
{
    internal class Menu
    {
        public static void Executar()
        {
            Console.BackgroundColor = ConsoleColor.White; 
            Console.ForegroundColor = ConsoleColor.Black;

            List<Pessoas> listPessoas = new List<Pessoas>();
            List<Agendamentos> listAgendamentos = new List<Agendamentos>();
            int op = -1;

            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("=== CENTRAL DE MONITORIA ===");
                
                Console.WriteLine("\n1. Cadastrar Estudante");
                Console.WriteLine("2. Cadastrar Monitor");
                Console.WriteLine("3. Agendar Monitoria");
                Console.WriteLine("4. Listar Estudantes");
                Console.WriteLine("5. Listar Monitores");
                Console.WriteLine("6. Listar Monitorias Agendadas");
                Console.WriteLine("0. Sair");

                Console.Write("\nEscolha uma opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                    {   
                        Console.Clear();
                        Console.WriteLine("=== CADASTRO DE ESTUDANTE ===");

                        Estudante newE = new Estudante();
                        newE.Cadastrar();

                        listPessoas.Add(newE);

                        Console.WriteLine("\nEstudante cadastrado com sucesso!");
                        Console.WriteLine("Pressione 'ENTER' para voltar ao menu...");

                        Console.ReadKey();
                        break;
                    }

                    case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("=== CADASTRO DE MONITOR ===");

                        Monitor newM = new Monitor();
                        newM.Cadastrar();

                        listPessoas.Add(newM);

                        Console.WriteLine("\nMonitor cadastrado com sucesso!");
                        Console.WriteLine("Pressione 'ENTER' para voltar ao menu...");

                        Console.ReadKey();
                        break;
                    }


                    case 3:
                    {
                            Console.Clear();
                            Console.WriteLine("=== AGENDAMENTO DE MONITORIA ===");

                            List<Estudante> alunos = new List<Estudante>();
                            List<Monitor> monitores = new List<Monitor>();

                            foreach (Pessoas p in listPessoas)
                            {
                                if (p is Estudante e) alunos.Add(e);
                                if (p is Monitor m) monitores.Add(m);
                            }

                            if (alunos.Count == 0 || monitores.Count == 0)
                            {
                                Console.WriteLine("\nErro: Cadastre estudantes e monitores primeiro!");
                            }
                            else
                            {
                                Console.WriteLine("\n");

                                for (int i = 0; i < alunos.Count; i++) 
                                Console.WriteLine($"{i + 1}. {alunos[i].Nome}");
                                Console.Write("Selecione o Estudante: ");
                                int selE = int.Parse(Console.ReadLine()) - 1;

                                Console.WriteLine("\n");

                                for (int i = 0; i < monitores.Count; i++) Console.WriteLine($"{i + 1}. {monitores[i].Nome}");
                                Console.Write("Selecione o Monitor: ");
                                int selM = int.Parse(Console.ReadLine()) - 1;

                                Console.Write("\nData [DD/MM/AA]: "); string d = Console.ReadLine();
                                Console.Write("\nHorário [HH:MM h]: "); string h = Console.ReadLine();
                                Console.Write("\nAssunto [Livre]: "); string a = Console.ReadLine();

                                listAgendamentos.Add(new Agendamentos(alunos[selE], monitores[selM], d, h, a));
                                Console.WriteLine("\nAgendamento realizado!");
                            }
                            Console.ReadKey();
                            break;
                        }

                    case 4:
                    {
                            Console.Clear();
                            Console.WriteLine("=== LISTA DE ESTUDANTES CADASTRADOS ===");

                            bool encontrou = false;
                            foreach (Pessoas p in listPessoas) 
                            {
                                if (p is Estudante)
                                {                       
                                    p.ExibirDados(); 
                                    encontrou = true;
                                }
                            }

                            if (!encontrou)
                            {
                                Console.WriteLine("\nNenhum estudante cadastrado no sistema.");
                            }

                            Console.WriteLine("\nPressione 'ENTER' para voltar ao menu...");

                            Console.ReadKey();
                            break;
                    }

                    case 5:
                    {
                            Console.Clear();
                            Console.WriteLine("=== LISTA DE MONITORES CADASTRADOS ===");

                            bool encontrou = false;
                            foreach (Pessoas p in listPessoas)
                            {
                                if (p is Monitor)
                                {
                                    p.ExibirDados();
                                    encontrou = true;
                                }
                            }

                            if (!encontrou)
                            {
                                Console.WriteLine("\nNenhum monitor cadastrado no sistema!");
                            }

                            Console.WriteLine("\nPressione 'ENTER' para voltar ao menu...");

                            Console.ReadKey();
                            break;
                    }

                    case 6:
                    {
                        Console.Clear();
                        Console.WriteLine("=== MONITORIAS AGENDADAS ===");

                        if (listAgendamentos.Count == 0)
                        {
                            Console.WriteLine("\nNenhuma monitoria agendada!");
                        }

                        else
                        {
                            for (int i = 0; i < listAgendamentos.Count; i++)
                            {
                                Console.WriteLine($"\nID DO AGENDAMENTO: {i + 1}");
                                listAgendamentos[i].ExibirResumo();
                            }

                            Console.Write("\nDeseja concluir algum agendamento? (S/N): ");
                            if (Console.ReadLine().ToUpper() == "S")
                            {
                                Console.Write("Digite o ID: ");
                                int id = int.Parse(Console.ReadLine()) - 1;
                            

                                if (id >= 0 && id < listAgendamentos.Count)
                                {
                                    listAgendamentos[id].ConcluirAgendamento();
                                }
                            }
                        }
                            
                        Console.WriteLine("\nPressione 'ENTER' para voltar ao menu...");

                        Console.ReadKey();
                        break;
                    }
                           
                    case 0:
                    { 
                        Console.Clear();
                        Console.WriteLine("Saindo da Central de Monitoria...");
                        break;
                    }

                    default:
                    {
                        Console.Clear();
                        Console.Write("OPÇÃO INVÁLIDA! Pressione 'ENTER' para Voltar..."); 
                        Console.ReadKey();
                        continue;
                    }
                }
                
               
            }
        }
    }
}
