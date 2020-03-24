using System;

namespace laboratorio1_francocruzat
{   
    class Person
    {

        string Nombre;
        string Apellido;
        public Person(string nombre,String apellido)
        { 
            Nombre = nombre;
            Apellido = apellido;
        }
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
            var persona = new Person("Bob","Kunga");
            int lanzada = persona.Lanzar();
            Console.WriteLine(lanzada);
        }
    }
}
