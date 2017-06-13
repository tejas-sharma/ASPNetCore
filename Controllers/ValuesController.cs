using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCore.Data;
using ASPNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ASPNetCore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ConfigurationContext _ctx;
        private readonly MyOptions _options;

        public ValuesController(IOptionsSnapshot<MyOptions> options, ConfigurationContext ctx)
        {
            _options = options.Value;
            _ctx = ctx;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { _options.Foo.Bar };
        }

        [HttpGet, Route("configs")]
        public IEnumerable<Configuration> GetConfigs()
        {
            return _ctx.Configurations.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
