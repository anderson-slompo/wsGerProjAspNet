using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("ola")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody]Funcionario value)
        {
            if (ModelState.IsValid)
            {
                return Ok(value.ToString());
            }
            else
            {
                var query = from state in ModelState.Values
                            from error in state.Errors
                            select new { error.ErrorMessage, state.Value};

                var errorList = query.ToList();
                return Ok(ModelState.Values);
                //return Ok(errorList);
            }
            
        }

        [HttpPut]
        [Route("")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        [Route("")]
        public void Delete(int id)
        {
        }
        [HttpGet]
        [Route("bla")]
        public string blablabla()
        {
            return "blablabla";
        }
    }
}