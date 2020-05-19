using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable()]
    public class Bloque : División
    {

        List<Persona> divisiones = new List<Persona>();

        public Bloque(string Name) : base(Name)
        {

        }

    }
}
