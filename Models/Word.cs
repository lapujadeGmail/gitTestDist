using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetGestionTaches.Models
{
    class Word : Executable
    {
        public override int PID { get; set; }
        public Word()
        {
        }
        public override int Progression { get; set; }
        public void WinWordExe ()
        {
            Console.WriteLine("+++++++++++ Démarrage de Word dans le processus " + PID);
            Progression = 0;
            while (Progression<50)
            {
                Progression++;
                Console.WriteLine("Le processus Word " + PID + " a le contrôle. Progression = " + Progression);
            }
            Console.WriteLine("***********  Fin du processus Word " + PID);
        }
        public override void Start()
        {
            WinWordExe();
        }
        public override void Stop()
        {
            Console.WriteLine("Word - Fin du processus "+PID);
        }
    }
}
