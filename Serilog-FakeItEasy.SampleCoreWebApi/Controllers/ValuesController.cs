using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Serilog_FakeItEasy.SampleCoreWebApi.Data;

namespace Serilog_FakeItEasy.SampleCoreWebApi.Controllers
{
    /// <summary>
    /// This is a test controller that allows for "real life" testing of Serilog logging
    /// </summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<ValueEntity> Get()
        {
            Log.Information("Get list of values");
            return MockValueData.GetValues();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ValueEntity Get(int id)
        {
            ValueEntity valueEntity = null;
            try
            {
                Log.Information("Get Value by Id [{Id}]", id);
                valueEntity = MockValueData.GetValues().Single(a => a.Id == id);
            }
            catch (Exception exception)
            {
                LogException(exception);
            }

            return valueEntity;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            try
            {
                Log.Information("Save new value [{Value}]", value);
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
            }
            catch (Exception exception)
            {
                LogException(exception);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            try
            {
                Log.Information("Upste value [{Value}]", value);
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
            }
            catch (Exception exception)
            {
                LogException(exception);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                Log.Information("Delete value by Id [{Id}]", id);
                //check to see if value with id exists
                var valueEntity = MockValueData.GetValues().Single(a => a.Id == id);
                if (valueEntity == null) throw new InvalidDataException($"Value with id {id} not found.");
            }
            catch (Exception exception)
            {
                LogException(exception);
            }
        }

        #region Helpers

        private static void LogException(Exception exception)
        {
            Log.Error(exception, "{Message}", exception.Message);
        }

        #endregion
    }
}
