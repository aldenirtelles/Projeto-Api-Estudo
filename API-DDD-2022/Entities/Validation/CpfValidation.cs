using Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Validation
{
    public class CpfValidation : ValidationAttribute
    { 
        public override bool IsValid(object value)
        {
            if (value == null) return false;

            string cpf = value.ToString().Replace("-","").Replace(".","");
            
            if (cpf.Length != 11) return false;

            int tamanho = 9;
            int mult1 = 10;
            int mult2 = 11;
            int soma = 0;
            int resto = 0;
            string digitos;
            string cpfCopia = cpf.Substring(0, 9);

            int.Parse(cpfCopia);

            for (int i = 0; i < tamanho; i++)
            {
                soma += int.Parse(cpfCopia[i].ToString()) * mult1;
                mult1--;
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            resto = 11 - resto;
            digitos = resto.ToString();

            cpfCopia += resto;


            for (int i = 0; i <= tamanho; i++)
            {
                soma += int.Parse(cpfCopia[i].ToString()) * mult2;
                mult2--;
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            resto = 11 - resto;
            digitos += resto.ToString();

            return cpf.EndsWith(digitos);
        }

        public bool ValidaCpf(string cpf)
        {
            if (cpf == null) return false;

            cpf = cpf.ToString().Replace("-", "").Replace(".", "");

            if (cpf.Length != 11) return false;

            int tamanho = 9;
            int mult1 = 10;
            int mult2 = 11;
            int soma = 0;
            int resto = 0;
            string digitos;
            string cpfCopia = cpf.Substring(0, 9);

            int.Parse(cpfCopia);

            for (int i = 0; i < tamanho; i++)
            {
                soma += int.Parse(cpfCopia[i].ToString()) * mult1;
                mult1--;
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            
            digitos = resto.ToString();

            cpfCopia += resto;

            soma = 0;

            for (int i = 0; i <= tamanho; i++)
            {
                soma += int.Parse(cpfCopia[i].ToString()) * mult2;
                mult2--;
            }

            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digitos += resto.ToString();

            return cpf.EndsWith(digitos);
        }
    }
}
