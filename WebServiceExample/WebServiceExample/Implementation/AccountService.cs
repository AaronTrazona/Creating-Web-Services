using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServiceExample;
using WebServiceExample.DataClasses;
using WebServiceExample.Repository;
using WebServiceExample.Inferface;

namespace WebServiceExample.Implementation
{
    public class AccountService : IAccountService
    {

        public ResponseClass GetAccount(string firstname)
        {
            ResponseClass account = new ResponseClass();
            Account_Repository accountRepo = new Account_Repository();
            try
            {
                account.response = Accounts.TblToData(accountRepo.GetAccount(firstname)).Email;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return account;
        }

        public ResponseClass GetCurrentTime()
        {
            ResponseClass response = new ResponseClass();
            Account_Repository accountRepo = new Account_Repository();
            try
            {
                response.response = accountRepo.GetCurrentTime().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}
