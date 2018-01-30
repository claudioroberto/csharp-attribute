using ConsoleApp.Atributos.Infra;
using ConsoleApp.Atributos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa()
            {
                Codigo = "1",
                Nome = "Claudio Roberto",
                EndCep = "87020-015"
            };

            foreach (var propriedade in pessoa.GetType().GetProperties())
            {
                foreach (var atributo in propriedade.GetCustomAttributes(true))
                {
                    switch (atributo.GetType().Name)
                    {
                        case "CepAttribute":
                            {
                                var resultado = (atributo as CepAttribute).Match(propriedade.GetValue(pessoa, null));
                                if (!resultado)
                                    Console.WriteLine("O Campo CEP está no formato inválido!!!");
                                break;
                            }

                        default:
                            break;
                    }
                }
            }

            Console.WriteLine("Validação Finalizada!!!");
            Console.ReadKey();
        }
    }
}
