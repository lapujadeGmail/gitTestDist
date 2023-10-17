using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetGestionTaches.Models
{
    public abstract class Executable
    {
        public abstract int PID { get; set; }
        public abstract int Progression { get; set; }
        public abstract void Start();
        public abstract void Stop();
    }
}
