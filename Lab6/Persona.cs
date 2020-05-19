using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable()]
    public class Persona 
    {
        private string Name { get; set; }
        private string LastName { get; set; }
        private int Rut { get; set; }
        private string Position { get; set; }
        public Persona(string Name,string LastName,int Rut,string Position)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Rut = Rut;
            this.Position = Position;
        }

        public string get_name()
        {
            return Name + " " + LastName;
        }
        public string get_position()
        {
            return Position;
        }
    }
}
