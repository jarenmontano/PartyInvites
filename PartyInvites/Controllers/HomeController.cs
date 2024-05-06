/*HomeController
 * Author: Jaren Montano
 * Date: 12/1/2023
 * Purpose: The purpose is to 
 * route all of our data and views.
 * 
 */


using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Diagnostics;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
          
        }

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //default http get
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)  
        {
            if(ModelState.IsValid) {
				Repository.AddResponse(guestResponse);
				return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation erro
                return View();
            }
            
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r=> r.WillAttend == true));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}