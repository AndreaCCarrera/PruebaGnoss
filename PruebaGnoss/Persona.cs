using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGnoss
{
    public class Persona
    {
            private Dni dni;
            private string nombre;   
            private string apellidos;
            private string fechaNac;
              

            public Persona()
            {
                this.dni = new Dni();
                this.nombre = "";
                this.apellidos = "";
                this.fechaNac = "";
                
            
            }

            public Persona(Dni dni, string nombre, string apellidos, string fechaNac)
            {
                this.dni = dni;
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.fechaNac = fechaNac;
           
               
            }

            public Dni Dni { get => dni; set => dni = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellidos { get => apellidos; set => apellidos = value; }
            public string FechaNac { get => fechaNac; set => fechaNac = value; }

        public override string ToString() 
            {
                return this.dni+" "+this.nombre+" "+this.apellidos+" "+this.fechaNac;
            }


        }
    }


