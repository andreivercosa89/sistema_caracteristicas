using System;
namespace sistema_caracteristicas
{
    public class Humano : Mamifero
    {
      
        public void andar(){
            Console.WriteLine("Andando");
        }

        public void respirar()
        {
            Console.WriteLine("Respirando");
        }
        public override void dormir()
        {

            Console.WriteLine("Coxilando");
        }
        public Humano()
        {
        }
    }
}
