using Microsoft.AspNetCore.Mvc;


namespace WebApplication2.Controllers
{
    public class MoivesController : Controller
    {
       

        public IActionResult GetMovie(int id)
        {
            if (id < 10)
                return BadRequest();
            return Content($"your id ={id}", "text/html");

        }



        //public string GetMovie(int id )
        //{
        //    return "rr" ; 
        //}

        //public string Index()

        //{
        //    return "rawan";
        //}


    }
}
