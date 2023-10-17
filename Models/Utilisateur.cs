﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetGestionTaches.Models
{
    class Utilisateur
    {
        // j'ajoute des modifs pour tester git
        public int ID { get; set; }
        [Required]
        public String UserName { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public string Adresse { get; set; }

        public override string ToString()
        {
            return ID+" : "+UserName + " ( " + Nom + " , " + Prenom + " )";
        }
    }
}
