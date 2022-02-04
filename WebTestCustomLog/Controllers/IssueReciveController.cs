using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using WebTestCustomLog.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebTestCustomLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueReciveController : ControllerBase
    {
        private static List<CommonAlertSchemaModel> issueList = new List<CommonAlertSchemaModel>();
        private static List<string> issuestring = new List<string>();

        // GET: api/<ValuesController>
        [HttpGet]
        public List<CommonAlertSchemaModel> Get()
        {
            return issueList;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public CommonAlertSchemaModel GetByName(string id)
        {
            //var webhookData = new List<WebhookReceiver>();
            //foreach (var item in issueList)
            //{
            //    webhookData = item.properties.webhookReceivers;
            //}
            return issueList.Find(it => it.schemaId == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post(CommonAlertSchemaModel issue)
        {
            issueList.Add(issue);
            return Ok(issueList);
        }

        // POST api/<ValuesController>
        //[HttpPost]
        //public async Task<ActionResult> Post()
        //{
        //    var result = await GetRequestBody();
        //    issuestring.Add(result);
        //    return Ok(result);
        //}

        //private async Task<string> GetRequestBody()
        //{
        //    if (Request.Body.CanRead)
        //    {
        //        using (var reader = new StreamReader(Request.Body, Encoding.UTF8))
        //        {
        //            return await reader.ReadToEndAsync();
        //        }
        //    }
        //    else { return string.Empty; }
        //}

        // PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
