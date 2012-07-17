using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServiceExample.DataClasses;

namespace WebServiceExample.Inferface
{
    public interface IAccountService
    {
        ResponseClass GetAccount(string firstname);

        ResponseClass GetCurrentTime();
    }
}
