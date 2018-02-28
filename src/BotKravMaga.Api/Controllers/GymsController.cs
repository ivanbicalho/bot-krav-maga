﻿using BotKravMaga.Api.Data;
using BotKravMaga.Api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BotKravMaga.Api.Controllers
{
    [RoutePrefix("api/gyms")]
    public class GymsController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage GetGyms()
        {
            var gyms = new DBGym().GetAll(); // Mock Database Request

            return Request.CreateResponse(gyms);
        }

        //[HttpGet]
        //[Route("search/{term}")]
        //public HttpResponseMessage GetGym(string term)
        //{
        //    var gyms = new DBGym().GetAll(term); // Mock Database Request

        //    return Request.CreateResponse(gyms);
        //}
    }
}