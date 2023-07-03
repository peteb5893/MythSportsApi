using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MythSportsApi.Models2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MythSportsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsEventController : ControllerBase
    {
        private readonly ILogger<SportsEventController> _logger;
        private readonly MythSportsDbContext _context;

        public SportsEventController(ILogger<SportsEventController> logger, MythSportsDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]        
        public async Task<ActionResult<IEnumerable<SportsEvent>>> GetSportsEvents()
        {
            try
            {
                return await _context.SportsEvent.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.StackTrace);
                return StatusCode(500, "Error retrieving data from the database");
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<SportsEvent>> GetSportsEventById(string id)
        {
            try
            {
                var sportsEvent = await _context.SportsEvent.FindAsync(id);

                if (sportsEvent == null)
                {
                    return NotFound();
                }

                return sportsEvent;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.StackTrace);
                return StatusCode(500, "Error retrieving data from the database");
            }
            
        }

        [HttpGet]
        [Route("import")]
        public async Task<ActionResult> Import()
        {
            try
            {
                // http request to data source
                const string DataSourceUrl = "https://myth.fra1.digitaloceanspaces.com/misc/528%20%281%29.json";
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, DataSourceUrl);
                var response = await client.SendAsync(request);

                // validate response (should validate against JSON schema to prevent bad data getting imported)
                response.EnsureSuccessStatusCode();

                // deserialize into objects (figure out the data structure from the json and deserialize to strongly typed objects)
                string res = await response.Content.ReadAsStringAsync();
                var jsonObj = JsonConvert.DeserializeObject<dynamic>(res);

                int insertedCount = 0;
                int totalCount = jsonObj.Count;

                // insert into db tables if it doesn't already exist
                for (var i = 0; i < totalCount; i++)
                {
                    var id = jsonObj[i].id.ToString();

                    var result = await _context.SportsEvent.FindAsync(id);

                    if (result == null)
                    {
                        _context.SportsEvent.Add(new SportsEvent()
                        {
                            Id = id,
                            JsonData = JsonConvert.SerializeObject(jsonObj[i])
                        });

                        insertedCount++;
                    }                    
                }

                // save changes
                await _context.SaveChangesAsync();

                // return message for success/failure            
                return StatusCode(201, $"Import Complete: Added {insertedCount} of {totalCount}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.StackTrace);
                return StatusCode(500, "Error importing the JSON data. Please check the input data and try again");
            }
        }        
    }        
}