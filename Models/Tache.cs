using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using System.Threading;

namespace ProjetGestionTaches.Models
{
    class Tache
    {
        public static int DernierPID{get;set;}
        public int PID { get; set; }
        public Utilisateur Proprietaire { get; set; }
        public ElementRegistre Entry { get; set; }
        public Thread Processus{ get; set; }
        public String Description { get; set; }
        public Executable Executable { get; set; }
      
        public Tache()
        {
            Proprietaire = null;
            Entry = null;
            Processus = null;
            Description = null;
        }
        public Tache(Utilisateur p, ElementRegistre e, String d)
        {
            PID = DernierPID++;
            Proprietaire = p;
            Entry = e;
            Description = d;
        }
        public Tache(Utilisateur p, ElementRegistre e)
        {
            PID = DernierPID++;
            Proprietaire = p;
            Entry = e;
            Description = "PID : "+PID+ " - "+e.Description + " démarré par " + p.UserName;
            Start();
        }
        public void Start()
        {
            String nomClasse = Entry.NomClasseExecutable;
            Type[] lesTypes = Assembly.GetCallingAssembly().GetTypes();
            foreach (Type t in lesTypes)
            {
                if (nomClasse == t.Name)
                {
                    Executable = (Executable)Activator.CreateInstance(t);
                    Executable.PID = PID;
                    //Executable.Start();
                    Processus = new Thread(new ThreadStart(Executable.Start));
                    Processus.Start();                   
                }
            }
        }
        public override String ToString()
        {
            return "Processus "+PID+" Exécutable : "+Entry.NomClasseExecutable+" Appartenant à : "+Proprietaire.UserName;
        }
    }

}
