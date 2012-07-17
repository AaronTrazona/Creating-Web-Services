using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WebServiceExample.DataClasses
{
    [DataContract]
    public class Accounts
    {
        [DataMember]
        public int AccountID;
        [DataMember]
        public long FBUID;
        [DataMember]
        public string FirstName;
        [DataMember]
        public string LastName;
        [DataMember]
        public bool EmailVerified;
        [DataMember]
        public string Username;
        [DataMember]
        public string Password;
        [DataMember]
        public string Salt;
        [DataMember]
        public string AccessToken;
        [DataMember]
        public string Email;
        [DataMember]
        public string Address;
        [DataMember]
        public DateTime BirthDate;
        [DataMember]
        public string ProfilePicture;
        [DataMember]
        public string ConfirmationCode;
        [DataMember]
        public DateTime CreateDate;

        public static Accounts TblToData(tbl_Account tblaccounts)
        {
            try
            {
                if (tblaccounts == null) return null;

                Accounts account = new Accounts();

                account.AccountID = tblaccounts.AccountID;
                account.FBUID = tblaccounts.FBUID ?? 0;
                account.FirstName = tblaccounts.FirstName;
                account.LastName = tblaccounts.LastName;
                account.EmailVerified = tblaccounts.EmailVerified ?? false;
                account.Username = tblaccounts.Username;
                account.Password = tblaccounts.Password;
                account.Salt = tblaccounts.Salt;
                account.AccessToken = tblaccounts.AccessToken;
                account.Email = tblaccounts.Email;
                account.Address = tblaccounts.Address;
                account.BirthDate = tblaccounts.BirthDate ?? DateTime.Now;
                account.ProfilePicture = tblaccounts.ProfilePicture;
                account.ConfirmationCode = tblaccounts.ConfirmationCode;
                account.CreateDate = tblaccounts.CreateDate ?? DateTime.Now;

                return account;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

    }
}
