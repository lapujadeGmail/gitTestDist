using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetGestionTaches.Models
{
    public class ElementRegistre
    {
        public int ID { get; set; }
        public String NomClasseExecutable { get; set; }
        public String Description { get; set; }
        public override string ToString()
        {
            return ID + " : " + NomClasseExecutable + " : " + Description;
        }
    }
}
