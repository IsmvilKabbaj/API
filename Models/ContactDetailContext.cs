using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    //Classe de contexte de base de données nécessaire pour coordonner les fonctionnalités 
    //d’EF Core (créer, lire, mettre à jour, supprimer) pour le modèle ContactDetail
    public class ContactDetailContext : DbContext
    {
        // Ajout du constructeur
        public ContactDetailContext(DbContextOptions<ContactDetailContext> options) : base(options)
        {

        }
        //Création d'une propriété DbSet<ContactDetail> pour le jeu d’entités
        public DbSet<ContactDetail> ContactDetails { get; set; }
    }
}
 