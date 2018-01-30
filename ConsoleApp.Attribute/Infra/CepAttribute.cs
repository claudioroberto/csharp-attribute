using System;
using System.Text.RegularExpressions;

namespace ConsoleApp.Atributos.Infra
{
    public class CepAttribute : Attribute
    {
        public override bool Match(object obj)
        {
            Regex regex = new Regex(@"^\d{8}");
            return regex.IsMatch((string)obj);
        }
    }
}
