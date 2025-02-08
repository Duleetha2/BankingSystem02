using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem02
{
    internal class CreateAccount
    {
        public string FirtstName { get; set; }
        public string LastName { get; set; }
        public int NicNumber { get; set; }
        public int Age { get; set; }
        public float DepositAmount { get; set; }

        public CreateAccount(string firtstName, string lastName, int nicNumber, int age, float depositAmount)
        {
            FirtstName = firtstName;
            LastName = lastName;
            NicNumber = nicNumber;
            Age = age;
            DepositAmount = depositAmount;
        }

        public bool minimumAge() 
        {
            if(Age < 18) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool minimunDep()
        {
            if (DepositAmount < 1000) 
            { 
                return false ;
            }
            else
            {
                return true;
            }
        }
    }
}
