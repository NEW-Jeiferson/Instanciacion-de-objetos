using System;

namespace Repaso
{
    //Crea una clase Persona con nombre y edad. Instancia dos personas.

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }

    class Program
    {
        static void Main()
        {
            Persona persona1 = new Persona("Jose", 20);
           Console.WriteLine($"Nombre:  {persona1.Nombre} Edad: { persona1.Edad}");

            Persona persona2 = new Persona("Ana", 25);
            Console.WriteLine($"Nombre:  {persona2.Nombre} Edad: {persona2.Edad}");


        }
    }
}
