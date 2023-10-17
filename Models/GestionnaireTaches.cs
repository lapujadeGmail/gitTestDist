using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjetGestionTaches.Models
{
    class GestionnaireTaches
    {
        public Dictionary<int, Tache> TachesEnCours = new Dictionary<int, Tache>();
        public void AjouterTache(Utilisateur p, ElementRegistre e, String d)
        {
            Tache newTache = new Tache(p, e, d);
            TachesEnCours.Add(newTache.PID,newTache);
        }
        public Tache AjouterTache(Utilisateur p, ElementRegistre e)
        {
            Tache newTache = new Tache(p, e);
            TachesEnCours.Add(newTache.PID, newTache);
            return newTache;
        }
        public bool SupprimerTache(int PID)
        {
            TachesEnCours[PID].Processus.Abort();
            return TachesEnCours.Remove(PID);
        }
        public Dictionary<int, Tache> GetTaches()
        {
            return TachesEnCours;
        }
        public Tache GetTache(int PID)
        {
            return TachesEnCours[PID];
        }
        public int NbTaches()
        {
            return TachesEnCours.Count;
        }
    }
}
