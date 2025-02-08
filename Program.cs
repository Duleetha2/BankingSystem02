using System.Text.Json;

namespace BankingSystem02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AccountTransactions> TransactionList = new List<AccountTransactions>();
            List<CreateAccount> NewUserDetailsList = new List<CreateAccount>();

            Console.Write("Do you Have already account in our bank :");
            String Answer = Console.ReadLine();
            if (Answer == "yes") 
            {
                int accountNumber = ToStr("Enter Account Number : ");
                int nicNumber = ToStr("Enter NIC Number : ");
                string userName = str("Enter User Name : ");
                int depositAmount = ToStr("Enter Deposit Amount : ");

                AccountTransactions user02 = new AccountTransactions(accountNumber, nicNumber, userName, depositAmount);

                TransactionList.Add(user02);

                string jsonWrite = JsonSerializer.Serialize(TransactionList);
                File.WriteAllText("AccountDetails.Json", jsonWrite);
            }
            else if (Answer == "no") 
            {
                Console.Write("-----------Application for start new Account in out bank------------\n\n");

                string firstName = str("Enter Your First Name : ");
                string lastName = str("Enter Your Last Name : ");
                int nicNumber = ToStr("Enter Your NIC Number : ");
                int age = ToStr("Enter Your Age : ");
                float depositAmount = ToFloat("Enter deposit Amount : ");


                CreateAccount user01 = new CreateAccount(firstName, lastName, nicNumber, age, depositAmount);

                if (user01.minimumAge())
                {
                    if (user01.minimunDep())
                    {
                        Console.WriteLine("You Have Successfully created Account.Thank you chosing our service.");
                        string jsonWrite = JsonSerializer.Serialize(NewUserDetailsList);
                        File.WriteAllText("NewUserDetails.Json", jsonWrite);
                    }
                }
                else
                {
                    Console.WriteLine("Unsuccessfull");
                }


                NewUserDetailsList.Add(user01);
                string jsonWrite = JsonSerializer.Serialize(NewUserDetailsList);

            }

            string jsonReader = File.ReadAllText("AccountDetails.Json");
            TransactionList = JsonSerializer.Deserialize<List<AccountDetails>>(JsonReader);

            Console.ReadLine();
        }

        static int ToStr(string massage) 
        {
            Console.Write(massage);
            string read = Console.ReadLine();
            return int.Parse(read);

        }

        static string str(string massage)
        {
            Console.Write(massage);
            string read = Console.ReadLine();
            return read;

        }

        static float ToFloat(string massage) 
        {
            Console.Write(massage);
            string read = Console.ReadLine();
            return float.Parse(read);
        }

    }
}
