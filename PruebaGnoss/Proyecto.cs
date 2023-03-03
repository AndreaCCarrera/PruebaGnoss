using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGnoss
{
    public class Proyecto
    {

        private string nombre;
        private Cliente client;
        private List<Empleado> lista;

        public Proyecto()
        {
        this.nombre = "";
        this.client = new Cliente();
        this.lista = new List<Empleado>();

        }

        public Proyecto(string nombre, Cliente client)
        {

            this.client = client;
            this.nombre = nombre;
            this.lista = new List<Empleado>();

        }

    public string Nombre { get => nombre; set => nombre = value; }
    public Cliente Client { get => client; set => client = value; }
    internal List<Empleado> Lista { get => lista; set => lista = value; }
    public void Mostrar()
    {

            foreach (Empleado e in lista)
            {
                Console.WriteLine(e);

            }

        }

        public override string ToString() 
        {
            return this.nombre + " " + this.client;
        }
        

        public void Anadir(Empleado e)
        {

            lista.Add(e);

        }

        public void Borrar(Dni dni)
        {

            foreach (Empleado e in lista)
            {

                if (e.Dni == dni)
                {
                    lista.Remove(e);
                    break;

                }

            }



        }

        public void MostrarAula()
        {


            Console.WriteLine(ToString());
            Mostrar();
        }



    }
}

