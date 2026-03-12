using classeheranca;
using System;
using System.Collections.Generic;

namespace classeheranca
{
    // Classe base (superclasse)
    internal class Animal
    {
        // propriedade da classe animal
        public string Nome { get; set; }

        // metodo que sera sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }

    // classe derivada (subclasse)
    internal class Cachorra : Animal
    {
        // sobrescrevendo o metodo EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine("A cachorra late: Au Au!");
        }
    }

    // Outra classe derivada
    internal class Gato : Animal
    {
        // sobrescrevendo o metodo EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine("O gato mia: Miau!");
        }
    }

}
    internal class program
    {
       static void Main(string[] args)
        {
        // Criando instancias das classes derivadas
        Animal meuCachorro = new Cachorra { Nome = "Rex" };
        Animal meuGato = new Gato { Nome = "Felix" };

        //utilizando polimorfismo: array de animais
        Animal[] animais = { meuCachorro, meuGato };

        foreach (var animal in animais)
        {
            animal.EmitirSom(); // Cada onjeto chama o metodo adequado de sua classe
        }

    }
    }




