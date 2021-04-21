using System;

namespace FormularioConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            Console.Write("Ingresa tu nombre: ");
            per.setNombre(Console.ReadLine());
            Console.Write("Ingresa tu apellido: ");
            per.setApellido(Console.ReadLine());
            Console.Write("Ingresa tu edad: ");
            per.setEdad(Int16.Parse(Console.ReadLine()));
            Console.Write("Ingresa tu email: ");
            per.setEmail(Console.ReadLine());
            Console.Write("Ingresa el monto que desees: ");
            per.setMonto(Double.Parse(Console.ReadLine()));

            Console.WriteLine("\n");

            Console.WriteLine("Nombre: " + per.getNombre() + "  \nApellido: " + per.getApellido() +
                " \nEdad: " + per.getEdad() + " \nEmail: " + per.getEmail() + " \nMonto: "
                + per.getMonto());
            
            
        }
    }
}
