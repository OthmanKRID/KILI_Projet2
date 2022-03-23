﻿using Kili.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using static Kili.Models.General.UserAccount;

namespace Kili.Models
{
    public class UserAccount_Services
    {
        private BddContext _bddContext;
        public UserAccount_Services()
        {
            _bddContext = new BddContext();
        }


        //Fonction permettant d'obtenir la liste de tout les UserAccount
       public List<UserAccount> ObtenirUserAccounts()
        {
            return _bddContext.UserAccounts.ToList();
        }

        //Fonction permettant d'obtenir un UserAccount à partir de son Id
        public UserAccount ObtenirUserAccount(int id)
        {
            return _bddContext.UserAccounts.Find(id);
        }

        //Fonction permettant d'obtenir un UserAccount à partir de son Id en format string
        public UserAccount ObtenirUserAccount(string idStr)
        {
            int id;
            if (int.TryParse(idStr, out id))
            {
                return this.ObtenirUserAccount(id);
            }
            return null;
        }

        //Fonction permettant d'encoder un mot de passe
        public static string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "Kili" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }

        //Fonction permettant de créer un UserAccount
        public int CreerUserAccount(string username, string password, string email, TypeRole role)
        {
            string motDePasse = EncodeMD5(password);
            UserAccount userAccount = new UserAccount() { UserName = username, Password = motDePasse, Mail = email, DateCreation = System.DateTime.Today, Actif = true, Role = role};
            _bddContext.UserAccounts.Add(userAccount);
            _bddContext.SaveChanges();
            return userAccount.Id;
        }

        public int CreerAdmin(string username, string password, string email)
        {
            return CreerUserAccount(username, password, email, TypeRole.Admin);      
        }


        public void ModifierUserAccount(int id, string username, string password, string email, TypeRole role)
        {
            UserAccount userAccount = _bddContext.UserAccounts.Find(id);

            if (userAccount != null)
            {
                userAccount.UserName = username;
                userAccount.Password = password;
                userAccount.Mail = email;
                userAccount.Role = role;
                _bddContext.SaveChanges();
            }
        }

        public void SupprimerUserAccount(int id)
        {
            UserAccount userAccount = _bddContext.UserAccounts.Find(id);

            if (userAccount != null)
            {
                _bddContext.UserAccounts.Remove(userAccount);
                _bddContext.SaveChanges();
            }
        }

        public void DésactiverUserAccount(int id)
        {
            UserAccount userAccount = _bddContext.UserAccounts.Find(id);

            if (userAccount != null)
            {
                userAccount.Actif = false;
                _bddContext.SaveChanges();
            }
        }

        public UserAccount Authentifier(string username, string password)
        {
            string motDePasse = EncodeMD5(password);
            UserAccount user = this._bddContext.UserAccounts.FirstOrDefault(u => u.UserName == username && u.Password == motDePasse);
            return user;
        }


        public void Dispose()
        {
            _bddContext.Dispose();
        }

    }
}
