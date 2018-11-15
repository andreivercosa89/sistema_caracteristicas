using System;
namespace sistema_caracteristicas
{
    public class Mamifero
    {
        public string nome{ get; set; }
        public string tamanho { get; set; }

        public void mamar(){
            Console.WriteLine("Mamando");
        }
        public void respirar(){
            Console.WriteLine("Respirando");
        }

        public virtual void dormir()
        {
            Console.WriteLine("Dormindo");
        }

        public Mamifero()
        {
        }
    }
}
