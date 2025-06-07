using System;
//ejercicio de repaso 96
namespace Repaso
{
    //Crea un sistema de gestión de estudiantes usando herencia, encapsulación y polimorfismo

    public class Estudiante
    {
        // Atributos privados para encapsulación
        private string _nombre;
        private string _grado;
        private int _edad;

        // Propiedades públicas para acceder a los atributos privados
        public string Nombre
        {
            get { return _nombre; }

            set { _nombre = value; }
        }

        public string Grado
        {
            get { return _grado; }

            set { _grado = value; }
        }

        public int Edad
        {
            get { return _edad; }

            set { _edad = value; }
        }

        // Método virtual para permitir polimorfismo
        public virtual void Bienvenida()
        {
            Console.WriteLine($"Bienvenido");
        }
    }

    public class EstudiantePrimaria : Estudiante
    {
        public override void Bienvenida()
        {
            Console.WriteLine($"Bienvenida: {Nombre} (Primaria de {Grado} con {Edad} years)");
        }
    }
    
    public class EstudianteSecundaria : Estudiante
    {
        public override void Bienvenida()
        {
            Console.WriteLine($"Bienvenida: {Nombre}(Secundaria de {Grado} con {Edad} years )");
        }
    }

    class program
    {
        static void Main()
        {
            // Crear instancias de estudiantes y mostrar sus bienvenidas
            EstudiantePrimaria primaria = new EstudiantePrimaria();
            primaria.Nombre = "Maria";
            primaria.Grado = "Tercero";
            primaria.Edad = 8;
            primaria.Bienvenida();

            EstudianteSecundaria secundaria = new EstudianteSecundaria();
            secundaria.Nombre = "Sofia";
            secundaria.Grado = "Sexto Bachiller";
            secundaria.Edad = 17;
            secundaria.Bienvenida();

            Console.ReadLine();
        }
    }

}
