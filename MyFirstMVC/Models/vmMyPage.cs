using Models;
using Services;

namespace MyFirstMVC.Models
{
    public class vmMyPage
    {
        //ICoolLists service = null;

        public string Greetings { get; set; } = "Hello everyone!";
        public List<LatinSentence> Latin { get; set; }
       

        //public void OnGet()
        //{
            
        //    var seeder = new csSeedGenerator();

        //    Latin = service.LatinSentences.Take(5).ToList();
        //    //Latin = seeder.LatinSentences(10);
        //}
        //public vmMypage()
        //{
        //    //this.service = service;
        //    //return this;
        //}
    }
}
