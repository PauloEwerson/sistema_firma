using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaSistema
{
    public class Firma
    {
        private List<Empregado> empregados;

        public Firma()
        {
            empregados = new List<Empregado>();
        }

        /// <summary>
        /// Adiciona um novo empregado à lista de empregados da firma.
        /// </summary>
        public void CadastrarEmpregado(Empregado empregado)
        {
            empregados.Add(empregado);
        }

        /// <summary>
        /// Retorna uma lista de todos os empregados cadastrados na firma.
        /// </summary>
        public List<Empregado> ListarTodosEmpregados()
        {
            return empregados;
        }

        /// <summary>
        /// Promove um empregado, concedendo um aumento de 10% no salário.
        /// </summary>
        public void PromoverEmpregado(string nome, string sobrenome)
        {
            var empregado = empregados.FirstOrDefault(e => e.PrimeiroNome == nome && e.Sobrenome == sobrenome);
            if (empregado != null)
            {
                empregado.Promover();
            }
        }

        /// <summary>
        /// Demite um empregado, removendo-o da lista de empregados da firma.
        /// </summary>
        public void DemitirEmpregado(string nome, string sobrenome)
        {
            var empregado = empregados.FirstOrDefault(e => e.PrimeiroNome == nome && e.Sobrenome == sobrenome);
            if (empregado != null)
            {
                empregados.Remove(empregado);
            }
        }

        /// <summary>
        /// Retorna o salário anual de um empregado específico.
        /// </summary>
        public double ListarSalarioAnual(string nome, string sobrenome)
        {
            var empregado = empregados.FirstOrDefault(e => e.PrimeiroNome == nome && e.Sobrenome == sobrenome);
            if (empregado != null)
            {
                return empregado.CalcularSalarioAnual();
            }
            return 0;
        }
    }
}
