using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.ServiceModel;
using WebServiceExample.DataClasses;
using WebServiceExample.Implementation;

namespace WebServiceExample
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService
    {

        public ResponseClass GetAccount(string firstname)
        {
            AccountService account = new AccountService();
            return account.GetAccount(firstname);
        }

        public ResponseClass GetCurrentTime()
        {
            AccountService account = new AccountService();
            return account.GetCurrentTime();
        }
    }
}
