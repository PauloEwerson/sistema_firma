using System;

namespace FirmaSistema
{
    class Program
    {
        static Firma firma = new Firma();

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Gerenciamento de Firma");
                Console.WriteLine("1. Cadastrar empregado");
                Console.WriteLine("2. Listar todos empregados");
                Console.WriteLine("3. Promover empregado");
                Console.WriteLine("4. Demitir empregado");
                Console.WriteLine("5. Listar salário anual de um empregado");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        CadastrarEmpregado();
                        break;
                    case 2:
                        ListarEmpregados();
                        break;
                    case 3:
                        PromoverEmpregado();
                        break;
                    case 4:
                        DemitirEmpregado();
                        break;
                    case 5:
                        ListarSalarioAnual();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != 0);
        }

        static void CadastrarEmpregado()
        {
            Console.Write("Digite o primeiro nome: ");
            string primeiroNome = Console.ReadLine();

            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Digite a matrícula: ");
            string matricula = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a data de nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite o salário mensal: ");
            double salarioMensal = double.Parse(Console.ReadLine());

            var empregado = new Empregado(primeiroNome, sobrenome, matricula, idade, dataNascimento, salarioMensal);
            firma.CadastrarEmpregado(empregado);

            Console.WriteLine($"Empregado {primeiroNome} {sobrenome} cadastrado com sucesso!");
        }

        static void ListarEmpregados()
        {
            var empregados = firma.ListarTodosEmpregados();
            foreach (var empregado in empregados)
            {
                Console.WriteLine($"Nome: {empregado.PrimeiroNome} {empregado.Sobrenome}, Matrícula: {empregado.Matricula}, Salário: {empregado.SalarioMensal.ToString("C")}");
            }
        }

        static void PromoverEmpregado()
        {
            Console.Write("Digite o primeiro nome do empregado a ser promovido: ");
            string primeiroNome = Console.ReadLine();

            Console.Write("Digite o sobrenome do empregado a ser promovido: ");
            string sobrenome = Console.ReadLine();

            firma.PromoverEmpregado(primeiroNome, sobrenome);

            Console.WriteLine($"{primeiroNome} {sobrenome} promovido com sucesso!");

        }

        static void DemitirEmpregado()
        {
            Console.Write("Digite o primeiro nome do empregado a ser demitido: ");
            string primeiroNome = Console.ReadLine();

            Console.Write("Digite o sobrenome do empregado a ser demitido: ");
            string sobrenome = Console.ReadLine();

            firma.DemitirEmpregado(primeiroNome, sobrenome);

            Console.WriteLine($"{primeiroNome} {sobrenome} demitido com sucesso!");
        }

        static void ListarSalarioAnual()
        {
            Console.Write("Digite o primeiro nome do empregado: ");
            string primeiroNome = Console.ReadLine();

            Console.Write("Digite o sobrenome do empregado: ");
            string sobrenome = Console.ReadLine();

            double salarioAnual = firma.ListarSalarioAnual(primeiroNome, sobrenome);

            Console.WriteLine($"Salário anual de {primeiroNome} {sobrenome}: {salarioAnual.ToString("C")}");
        }
    }
}
