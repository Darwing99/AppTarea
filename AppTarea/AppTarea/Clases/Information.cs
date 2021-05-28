using System;
using System.Collections.Generic;
using System.Text;

namespace AppTarea.Clases
{



    class Information
    {
        public string nombre;
        public string apellidos;
        public double edad;
        public string correo;

        public Information() { }
        public Information(string nombre, string apellidos, double edad, string correo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.correo = correo;

        }

        //seter
        public void setNombre(string _nombre)
        {
            this.nombre = _nombre;
        }
        public void setApellido(string _apellidos)
        {
            this.apellidos = _apellidos;
        }
        public void setEdad(double _edad)
        {
            this.edad = _edad;
        }
        public void setCorreo(string _correo)
        {
            this.correo = _correo;
        }
        //getters
        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellidos;
        }
        public double getEdad()
        {
            return edad;
        }
        public string getCorreo()
        {
            return correo;
        }



    }
}
