using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STQ2.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        // DO NOT CHANGE ANY OF THE ABOVE CODE 


        // Uncomment and complete the function below

        [HttpPost]
        public ActionResult Add(/*Recieve Values */string idNumber , string dateBirth,string password,string passwordConfirm)
        {
            //check passwords and return stayus to variable passwordcheck of type bool
            bool passwordCheck;
            if (password == passwordConfirm)
                {
                passwordCheck = true;
            }
            else
                {
                passwordCheck = false;
            }

            //check ids and bday 

                //Recieve Birthdate
                DateTime Birthday = Convert.ToDateTime(dateBirth);

                string ShortenBirthday = Birthday.ToString("yyyyMMdd", CultureInfo.InvariantCulture);

                //Get First 2 values of Birthdate bbecause they are the first two digits of the Year 
                string Bday = ShortenBirthday.Substring(0, 2);

                //Add the 2 values to the front of the Id to create a valid date check parameter

                string ConstructedID = Bday + idNumber;

                //Shorten the Id cause we need to check the yyyyMMDD so the  first 8 values of new Contructed ID that has yy from Bday added

                string NewIDtocheck = ConstructedID.Substring(0, 8);



                //check that dates are the same

                if (ShortenBirthday== NewIDtocheck && passwordCheck == true)
                {
                    ViewBag.ValidationMessage = "Valid User!!!";
                }
                else
                {
                    ViewBag.ValidationMessage = "Not Valid User";

                }
            return View();

        }

        // Uncomment and complete the function above
    }
}