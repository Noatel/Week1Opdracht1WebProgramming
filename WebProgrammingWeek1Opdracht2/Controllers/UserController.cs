using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebProgrammingWeek1Opdracht2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string find(string Name)
        {
            int DisplayAmount = 0;
            string DisplayName = "";


            string[] Names =  {"jan","Jan","jan", "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian", "abby", "abigail", "adele", "adrian" };

            foreach(string nameList in Names)
            {
                if (nameList.ToLower().Contains(Name.ToLower()))
                {
                    DisplayAmount++;
                }
            }

            

            String message = string.Format("De naam {0} komt {1}x voor in de lijst", Name, DisplayAmount);
       
            return message;

        }
        public string findPerson(int id)
        {

            List<Models.Person> items = new List<Models.Person>();
            string[] Names = { "jan", "Jan", "jan", "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian", "abby", "abigail", "adele", "adrian" };
            foreach (string nameList in Names)
            {
                Models.Person person = new Models.Person(nameList, nameList + "@hotmail.com");
                items.Add(person);
            }


            string message = "";

            if (id <= items.Count) { 
                 Models.Person person = items.ElementAt(id);
                message = string.Format("Email = {0}",person.email);
            } else {
                message = string.Format("User with id of {0} not found", id);
            }


            return message;


        }

    }
}

