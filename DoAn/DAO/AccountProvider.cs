using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    class AccountProvider
    {
        private static AccountProvider instance;
        public static AccountProvider Instance
        {
            get
            {
                if (AccountProvider.instance==null)
                {
                    AccountProvider.instance = new AccountProvider();
                };
                return AccountProvider.instance;
            }
            private set { AccountProvider.instance=value; }
        }
        private AccountProvider() { }

        public bool Login(string username,string password)
        {
            string query = @"exec usp_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] { username,password});
            return result.Rows.Count>0;
        }
    }
}
