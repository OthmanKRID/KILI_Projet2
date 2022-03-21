using Kili.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
       /* [Fact]
        public void Creation_Compte_Verification()
        {
            // Nous supprimons la base si elle existe puis nous la créons
            using (Dal ctx = new Dal())
            {
                // Nous supprimons et créons la db avant le test
                ctx.DeleteCreateDatabase();
                // Nous créons un lieu de vacances
                ctx.CreerComptes("monusername", "monpassword", true, "monmail@gmail.com");
                       //        // Nous vérifions que le lieu a bien été créé
               List<UserAccount> comptes = ctx.ObtientToutesLesComptes();
               Assert.NotNull(comptes);
               Assert.Single(comptes);
               Assert.Equal("monusername", comptes[0].UserName);
               Assert.Equal("monpassword", comptes[0].Password);
               Assert.True(comptes[0].Actif);
               Assert.Equal("monmail@gmail.com", comptes[0].Mail);
            }
      }*/

        [Fact]
        public void Suppression_Compte_Verification()
        {
            // Nous supprimons la base si elle existe puis nous la créons
            using (Dal ctx = new Dal())
            {
                // Nous supprimons et créons la db avant le test
                ctx.DeleteCreateDatabase();
                // Nous créons un lieu de vacances
                int id = ctx.CreerComptes("monusername", "monpassword", true, "monmail@gmail.com");
                ctx.SupprimerComptes(id);
                //        // Nous vérifions que le lieu a bien été créé
                List<UserAccount> comptes = ctx.ObtientToutesLesComptes();
                Assert.Empty(comptes);

            }
        }
    }
}
