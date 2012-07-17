using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceExample.Repository
{
    public class Account_Repository
    {
        private ExampleDataClassesDataContext db = new ExampleDataClassesDataContext();

        public void Update()
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public tbl_Account GetAccount(string firstname)
        {
            tbl_Account account = null;
            try
            {
                account = db.tbl_Accounts.FirstOrDefault(a => string.Compare(a.FirstName, firstname,true)==0);
            }
            catch (Exception)
            {
                throw;
            }
            return account;
        }

        public DateTime GetCurrentTime()
        {
            
            try
            {
                return DateTime.Now;
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }
    }
}
