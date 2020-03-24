using System;

namespace laboratorio1_francocruzat
{   
    class Person
    {
        string Nombre;
        string Apellido;
        public int Lanzar()
        {
            var rand = new Random();
            int numero = rand.Next(0, 3);
            return numero;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var persona = new Person();
            int lanzada = persona.Lanzar();
            Console.WriteLine(lanzada);
        }
    }
}
