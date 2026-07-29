# 📚 Central de Monitoria

Documentação do Sistema de Agendamentos e Atendimentos Acadêmicos em C# (.NET).

---

## 1. Visão Geral do Projeto
A **Central de Monitoria** é uma aplicação de console desenvolvida em C# (.NET) projetada para otimizar e organizar a gestão de monitorias em instituições de ensino. O sistema permite o cadastramento de estudantes e monitores, o agendamento de sessões de estudo com data, horário e assunto, e a gestão de status das monitorias prestadas.

O projeto serve como uma demonstração prática e robusta dos pilares fundamentais da **Programação Orientada a Objetos (POO)**, incluindo herança, polimorfismo, encapsulamento e tratamento/validação de entradas do usuário em ambiente de terminal.

---

## 2. Funcionalidades Principais
* **Cadastro de Estudantes:** Registro de alunos com armazenamento seguro e validação de nome, e-mail acadêmico, turma e prontuário.
* **Cadastro de Monitores:** Registro de monitores de disciplinas acadêmicas, com acompanhamento em tempo real da quantidade de atendimentos efetuados.
* **Agendamento de Monitorias:** Interface interativa para associar estudantes a monitores disponíveis, registrando data, horário e conteúdo a ser abordado.
* **Listagem e Consultas:** Exibição organizada de todos os estudantes e monitores cadastrados no sistema.
* **Conclusão e Registro de Atendimentos:** Painel de monitorias agendadas com funcionalidade para marcar atendimentos como concluídos, incrementando automaticamente as estatísticas do monitor responsável.

---

## 3. Arquitetura e Estrutura de Classes

| Classe | Relação POO | Descrição e Responsabilidades |
| :--- | :--- | :--- |
| **`Program`** | Ponto de Entrada | Classe principal que contém o método `Main()`, responsável por inicializar o fluxo da aplicação invocando o Menu. |
| **`Menu`** | Controladora (UI) | Gerencia a interface do terminal, exibindo opções estilizadas, capturando entradas do teclado e orquestrando as listas de dados. |
| **`Pessoas`** | Classe Base (Superclasse) | Contém os atributos compartilhados `Nome` e `Email`. Oferece métodos virtuais (`Cadastrar`, `ExibirDados`) prontos para sobrescrita. |
| **`Estudante`** | Subclasse de `Pessoas` | Especialização que adiciona os atributos `Turma` e `Prontuario`, incluindo rotinas específicas de validação no formulário. |
| **`Monitor`** | Subclasse de `Pessoas` | Especialização que adiciona a `Disciplina` lecionada e o contador de `QuantidadeAtendimentos` prestados. |
| **`Agendamentos`** | Classe de Domínio | Realiza a associação entre um `Estudante` e um `Monitor`, gerenciando data, hora, assunto e alteração de status para concluído. |

---

## 4. Regras de Negócio e Validações

* **Validação de Nome:** Deve conter no mínimo 2 caracteres para evitar preenchimentos vazios ou inválidos.
* **Validação de E-mail:** Exige no mínimo 11 caracteres e a presença obrigatória dos caracteres `@` e `.`.
* **Validação de Turma:** Mínimo de 7 caracteres (Ex: `"CTII 217"`), garantindo o padrão do código do curso e sala.
* **Validação de Prontuário:** Mínimo de 3 caracteres no padrão institucional (Ex: `"CB1"` ou `"SP30101"`).

> 💡 **Destaque de Funcionalidade: Controle de Atendimentos**  
> Sempre que uma monitoria é finalizada na opção *"Listar Monitorias Agendadas"*, o método `ConcluirAgendamento()` altera a situação do agendamento para **CONCLUÍDO** e aciona automaticamente o método `RegistrarAtendimento()` do monitor correspondente, incrementando seu histórico estatístico.

---

## 5. Mapeamento dos Arquivos do Projeto

* `Program.cs`: Ponto de entrada que chama o menu principal da aplicação.
* `Classes/Menu.cs`: Loop principal com `switch-case` contendo as opções do sistema e customização do console.
* `Classes/Pessoas.cs`: Superclasse base com propriedades e validação para dados pessoais.
* `Classes/Estudante.cs`: Classe com propriedades de turma e prontuário e sobrescrita de cadastro.
* `Classes/Monitor.cs`: Classe contendo disciplina e lógica de contagem de atendimentos realizados.
* `Classes/Agendamentos.cs`: Objeto de ligação que une Aluno + Monitor com data/hora e regras de término.
* `Central de Monitoria.csproj`: Arquivo de configuração e compilação do projeto C#.

---

## 6. Instruções de Instalação e Execução

### Pré-requisitos
Certifique-se de ter o **.NET 10.0** (ou superior) instalado em seu ambiente.

### Passos no Terminal
1. Clone este repositório do GitHub:
   ```bash
   git clone https://github.com/rafaelcmmarques/central-de-monitoria.git
   ```

2. Acesse a pasta do projeto:
   ```bash
   cd central-de-monitoria
   ```

3. Execute a aplicação via CLI do .NET:
   ```bash
   dotnet run
   ```

---

## 7. Tecnologias Utilizadas

* **Linguagem:** C#
* **Plataforma:** .NET 10.0
* **Tipo de Projeto:** Console Application (CLI)

---

## 8. Autor e Licença

Desenvolvido por **RAFAEL C. M. MARQUES**.

Este projeto está sob a licença [MIT](LICENSE) — sinta-se à vontade para usar, estudar e modificar.
