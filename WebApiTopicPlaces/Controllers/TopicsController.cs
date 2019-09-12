using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApiTopicPlaces.Contexts;
using WebApiTopicPlaces.Controllers.Entities;

namespace WebApiTopicPlaces.Controllers
{
    [Route("api/Topics")]
    public class TopicsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TopicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        static List<string> strings = new List<string>(){
            "value1","value2","value 3" };


        // GET: api/Topics/5

        [HttpGet]
        [EnableCors("AllowOrigin")]
        public IActionResult GetTopic(string request)
        {
            var topiclist = _context.Topics.Where(T => T.Description.Contains(request));

            //Topic topic = new Topic();
            //topic.Description = "Restaurant La Docena";
            //topic.Name = "La docuenta";
            //topic.ImgPath = "rest.jpg";

            //List <Topic> topiclist = new List<Topic>();
            //topiclist.Add(topic);


            return Ok(topiclist);

    }
}

      
    
}