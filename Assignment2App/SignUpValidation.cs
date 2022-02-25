using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2App
{
    /*
     * Used in CollaboratorSignUp.xaml.cs
     * Validate user input in user sign up
     */
    public class SignUpValidation
    {
        //validate user input first and last name
        public bool CollaboratorName(string firstname, string lastname)
        {
            string BadUserName = "";
            string BadLastName = "";


            if (firstname == BadUserName || lastname == BadLastName)
            {
                return true;
            }
            else
                return false;
        }

        //validate user input contact details
        public bool CollaboratorContact(string Conatact)
        {
            string BadContact = "";
            int ValidContactLength = 10;
            bool InvalidContactCheckDigits = false;

            if (Conatact == BadContact || Conatact.Length != ValidContactLength || CheckDigits(Conatact) == InvalidContactCheckDigits)
            {
                return true;
            }
            else
                return false;

        }

        //validate user input city
        public bool CollaboratorCity(int Citylist)
        {
            int InvalidCity = -1;

            if (Citylist == InvalidCity)
            {
                return true;
            }
            else
            return false;
        }

        //validate user input Availibity
        public bool CollaboratorAvailability(bool radio100km, bool radio50km, bool radio25km, bool radio10km)
        {
            bool Empty = false; 

            if (radio100km == Empty && radio50km == Empty && radio25km == Empty && radio10km == Empty)
            {
                return true;
            }
            else
                return false;
        }

        //validate user input Radious
        public bool CollaboratorHelpRadius(bool radio6pm, bool radio6am, bool radio24hour)
        {
            bool Empty = false;

            if (radio6pm == Empty && radio6am == Empty && radio24hour == Empty)
            {
                return true;
            }
            else
                return false;
        }

        //Checks for digits used in collaborator contact function
        bool CheckDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }


    }
}
