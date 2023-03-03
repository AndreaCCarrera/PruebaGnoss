using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGnoss
{
    public class Cliente: Persona
    {

        private int id;
        private double presupuesto;


        public Cliente() : base()

        {
            this.id = 0;
            this.presupuesto = 0.0;

        }

        public Cliente(Dni dni, string nombre, string apellidos, String fechaNac, int id, double presupuesto) : base(dni, nombre, apellidos, fechaNac)

        {
            this.id = id;
            this.presupuesto = presupuesto;

        }

  

        public int Id { get => id; set => id = value; }
        public double Presupuesto { get => presupuesto; set => presupuesto = value; }

        public override string ToString()
        {
            return base.ToString() + " " + this.id + " " + this.presupuesto;
        }

    }
}


