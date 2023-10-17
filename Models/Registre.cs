using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetGestionTaches.Models
{
    class Registre
    {
        readonly GestionTachesContext context;
        public Registre(GestionTachesContext c)
        {
            context = c;
        }
        public GestionTachesContext GetContext() { return context; }
        public void AddElementRegistre(String nomClasse, String desc)
        {
            ElementRegistre newEl = new ElementRegistre()
            {
                NomClasseExecutable = nomClasse,
                Description = desc
            };
            context.Registre.Add(newEl);
            context.SaveChanges();
        }

        public void RemoveElementRegistre(int id)
        {
            ElementRegistre e = GetElementRegistre(id);
            context.Registre.Remove(e);
            context.SaveChanges();
        }

        public ElementRegistre GetElementRegistre(int id)
        {
            return context.Registre.Find(id);
        }

        public void UpdateElementRegistre(ElementRegistre e)
        {
            context.Attach(e).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
