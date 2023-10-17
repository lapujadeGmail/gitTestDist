using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetGestionTaches.Models
{
    class Edge : Executable
    {
        public override int Progression { get; set; }
        public override int PID { get; set; }
        public Edge()
        {
        }
        public void EdgeExe()
        {
            Console.WriteLine("+++++++++++ Démarrage de Edge dans le processus " + PID);
            Progression = 0;
            while (Progression<50)
            {
                Progression++;
                Console.WriteLine("Le processus Edge " + PID + " a le contrôle. Progression = "+Progression);
            }
            Console.WriteLine("********** Fin du processus Edge " + PID);
        }
        public override void Start()
        {
            EdgeExe();
        }
        public override void Stop()
        {
            Console.WriteLine("Fin du processus Edge "+PID);
        }
    }
}
