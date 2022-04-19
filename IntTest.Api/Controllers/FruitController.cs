using IntTest.Api.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace IntTest.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "apple", "banana"
        };

        private MyDbContext context;

        public FruitController(MyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var aaa = context.Fruits.ToList();
            List<string> list = new List<string>();
            aaa.ForEach(x => list.Add(x.Name));
            return list;
        }
    }
}
