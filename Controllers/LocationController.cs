﻿using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using FirstREST.LibPrimavera;
using FirstREST.LibPrimavera.Model;
using FirstREST.LibPrimavera.Integration;

namespace FirstREST.Controllers
{
    public class LocationController : ApiController
    {
        // GET api/location/
        // FEATURE: Listar distritos
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, LocationIntegration.List());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // GET api/location/{$distritoId}/
        // FEATURE: Listar concelhos
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var queryResult = LocationIntegration.View(id);

                if (queryResult == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, queryResult);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}