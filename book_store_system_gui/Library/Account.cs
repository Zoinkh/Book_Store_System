using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store_system_gui.Library
{
    internal class Account
    {
        private static string name, 
            accountVar,
            passWord,
            gender
            ;
        private static DateTime birthDate;
        public void accountAndPasswordWrite(string account, string password, string fileName)
        {
            passWord = password;
            accountVar = account;
            //write account and password to certain file in the db
        }
        public bool accountAndPasswordVerification(string account, string password, string fileName)
        {
            //loop to cheack in password file for match account and passowrd
            //maybe bine account:passowrd to make it simple to check and store 
            //but we use sqlite so maybe just learn sql 
            foreach (var item in fileName)
            {
                if (accountVar == account && passWord == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
