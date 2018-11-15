using System;

namespace sistema_caracteristicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero m = new Mamifero();
            Humano h = new Humano();
            Baleia b = new Baleia();
            Felino f = new Felino();


            h.dormir();//Foi sobrescrita
            f.dormir();//Ainda eh o metodo da class Mamifero

        }
    }
}
