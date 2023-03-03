using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGnoss
{
    public class Empleado: Persona
    {
        private string departamento;
        private double salario;

        public Empleado() : base()
        {

            this.departamento = "";
            this.salario = 0.0;

        }


        public Empleado(Dni dni, string nombre, string apellidos, String fechaNac, string departamento, double salario) : base(dni, nombre, apellidos, fechaNac)
        {

            this.departamento = departamento;
            this.salario = salario;

        }


        public string Departamento { get => departamento; set => departamento = value; }
        public double Salario { get => salario; set => salario = value; }


       

        public override string ToString()
        {
            return base.ToString() + " " + this.departamento + " " + this.salario;
        }
    }
}


