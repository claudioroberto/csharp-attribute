using ConsoleApp.Atributos.Infra;

namespace ConsoleApp.Atributos.Model
{
    public class Pessoa 
    {
        public string Codigo { get; set; }

        public string Nome { get; set; }

        [Cep]
        public string EndCep { get; set; }
    }
}
