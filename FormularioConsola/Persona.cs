using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioConsola
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string email;
        private double monto;
        

        public Persona()
        {

        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApellido()
        {
            return apellido;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public double getMonto()
        {
            return monto;
        }

        public void setMonto(double monto)
        {
            this.monto = monto;
        }
    }
}
