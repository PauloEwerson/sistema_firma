using System;

namespace FirmaSistema
{
    public class Empregado
    {
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Matricula { get; private set; }
        public int Idade { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataContratacao { get; private set; }
        private double salarioMensal;
        private const double SALARIO_MINIMO = 1320.00;

        public double SalarioMensal
        {
            get 
            { 
              return salarioMensal;
            }
            private set
            {
                salarioMensal = value < SALARIO_MINIMO ? SALARIO_MINIMO : value;
            }
        }

        public Empregado(string primeiroNome, string sobrenome, string matricula, int idade, DateTime dataNascimento, double salarioMensal)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Matricula = matricula;
            Idade = idade;
            DataNascimento = dataNascimento;
            DataContratacao = DateTime.Now;
            SalarioMensal = salarioMensal < SALARIO_MINIMO ? SALARIO_MINIMO : salarioMensal;
        }

        /// <summary>
        /// Promove o empregado, concedendo um aumento de 10% no salário.
        /// </summary>
        public void Promover()
        {
            SalarioMensal *= 1.10;
        }

        /// <summary>
        /// Calcula e retorna o salário anual do empregado.
        /// </summary>
        public double CalcularSalarioAnual()
        {
            return SalarioMensal * 12;
        }
    }
}
