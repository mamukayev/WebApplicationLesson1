using Microsoft.AspNetCore.Mvc;
using System;

 
namespace WebApplicationLesson1.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            var currentHour = DateTime.Now.Hour;
            if (currentHour >= 0 && currentHour < 6)
            {
                return "Доброй ночи";
            }
            
            if (currentHour >= 6 && currentHour < 12)
            {
                return "Доброе утро";
            }
            
            if (currentHour >= 12 && currentHour < 18)
            {
                return "Доброй день";
            }
            
             
            {
                return "Доброй вечер";
            }
            

        }
    }
}
