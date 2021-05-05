using System;
namespace WebScrapper
{
    public class Person
    {
        string _ssn = "SSN";
        string _passportData = "PassPortData";
        string _driver = "DriverNumber";
        string _firstName = "Bethany";
        string _lastName = "Hampton";


        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted. Try again");
                    return;
                }
               
                 _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted. Try again");
                    return;
                }

                _lastName = value;
            }
        }

        public bool HasDocuments {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _driver.Length > 0;
            }

        }
    }
}
