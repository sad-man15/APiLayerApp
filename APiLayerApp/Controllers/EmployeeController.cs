using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APiLayerApp.Controllers
{
    public class EmployeeController : ApiController
    {

        [HttpGet]
        [Route("api/employees")]
        public HttpResponseMessage AllEmployee()
        {
            try
            {
                var data = EmployeeServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }catch(Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
           }
        [HttpGet]
        [Route("api/employees/{id}")]
        public HttpResponseMessage GetEmployee(int id)
        {
            try
            {
                var data = EmployeeServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

    }
}
