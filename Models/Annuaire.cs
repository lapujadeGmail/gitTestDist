using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionTaches.Models
{
    class Annuaire
    {
        readonly public GestionTachesContext context;
        public Annuaire(GestionTachesContext c)
        {
            context = c;
        }
        public GestionTachesContext GetContext() { return context; }
        public Utilisateur AddUtilisateur(String un, String n, String p)
        {
            Utilisateur newUser = new Utilisateur()
            {
                UserName = un, Nom = n,Prenom=p
            };
            context.Annuaire.Add(newUser);
            context.SaveChanges();
            return newUser;
        }

        public void RemoveUser(int id)
        {
            Utilisateur u = GetUtilisateur(id);
            context.Annuaire.Remove(u);
            context.SaveChanges();
        }
        public Utilisateur GetUtilisateur(int id)
        {
            return context.Annuaire.Find(id);
        }

        public void UpdateUtilisateur(Utilisateur u)
        {
            context.Attach(u).State = EntityState.Modified;
            context.SaveChanges();

        }

    }
}
