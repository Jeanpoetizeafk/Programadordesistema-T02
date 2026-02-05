using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classes
{
    //Definição de classe Carro

    internal class Carro
    {
        //Propriedades públicas: Pode ser acessada de fora da classe
        public string Marca { get; set; } // Publica a propriedade Marca

        // Propriedades privadas: Não pode ser acessada ou modificada de fora da classe

        private string Modelo { get; set; } // Privada, acessível apenas dentro da classe

        // Propriedade privada com um campo privado e um método getter e setter personalizado

        private int ano; // Campo privado


        public int Ano
        {
            get { return ano; } // Getter, para acessar o valor do campo privado
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year) // Verificação para garantir um valor válido
                {
                    ano = value;
                }
                else
                {
                    throw new ArgumentException("Ano inválido.");
                }
            }
        }
        // metodo publico para exibir onformacoes do carro
        public void Exibirinformaçoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }
        //metodo para calcular a idade do carro 
        public int CalcularIdade()
        {
            int anoatual = DateTime.Now.Year;
            return anoatual - Ano;
        }
        //metodo para definir o modelo do carro (com Exemplo de uso de propriedade privada)
        public void Definirmodelo(string modelo)
        {
            Modelo = modelo; // acessando a propriedade privada dentro da classe 
        }

    }
    internal class program
    {
        static void Main(string[] args)
        {
            // Criando um objeto da classe Carro
            Carro meucarro = new Carro();

            //Atribuindo valores as propriedades publicas e privadas
            meucarro.Marca = "Toyta";
            meucarro.Definirmodelo("Corolla"); // Usando metodo para definir o modelo, pois é privado
            meucarro.Ano = 2020; //A propriedade ano é publica mas com uma validaçao interna
        
        
            //Exibindo as informaçoes do carro
            meucarro.Exibirinformaçoes();

            // Calculando e exibindo a idade
            int idadecarro = meucarro.CalcularIdade();
            Console.WriteLine($"idade do carro: {idadecarro}");



            // Mantendo o console aberto 
            Console.WriteLine();




        }
    }


}
