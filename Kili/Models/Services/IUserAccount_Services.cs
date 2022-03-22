using Kili.Models.General;
using System;
using System.Collections.Generic;

namespace Kili.Models.Services
{
    public interface IUserAccount_Services : IDisposable
    {
        List<UserAccount> ObtenirUserAccounts();
        UserAccount ObtenirUserAccount(int id);
        UserAccount ObtenirUserAccount(string idStr);
        int CreerUserAccount(string username, string password, string email, TypeRole role);
        int CreerAdmin(string username, string password, string email);
        void ModifierUserAccount(int id, string username, string password, string email, TypeRole role);
        void SupprimerUserAccount(int id);
        void DésactiverUserAccount(int id);
        UserAccount Authentifier(string username, string password);


    }
}
