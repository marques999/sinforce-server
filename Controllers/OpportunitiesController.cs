﻿using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;

using FirstREST.LibPrimavera;
using FirstREST.LibPrimavera.Model;
using FirstREST.LibPrimavera.Integration;

namespace FirstREST.Controllers
{
    public class OpportunitiesController : ApiController
    {
        // GET api/opportunities/
        // FEATURE: Listar oportunidades
        public HttpResponseMessage Get()
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    return Request.CreateResponse(HttpStatusCode.OK, OpportunityIntegration.List(Authentication.GetRepresentative(null)));
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden);
            }
        }

        // GET api/opportunities/{$opportunityId}/
        // FEATURE: Visualizar oportunidade
        public HttpResponseMessage Get(string id)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    var queryResult = OpportunityIntegration.View(Authentication.GetRepresentative(null), id);

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
            else
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden);
            }
        }

        // POST api/opportunities/
        // FEATURE: Adicionar oportunidade
        public HttpResponseMessage Post([FromBody] Opportunity jsonObject)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    if (OpportunityIntegration.Insert(Authentication.GetRepresentative(null), jsonObject))
                    {
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden);
            }
        }

        // POST api/opportunities/{$opportunityId}/
        // FEATURE: Modificar oportunidade existente
        public HttpResponseMessage Post(string id, [FromBody] Opportunity jsonObject)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    if (OpportunityIntegration.Update(Authentication.GetRepresentative(null), id, jsonObject))
                    {
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden);
            }
        }

        // DELETE api/opportunities/{$opportunityId}/
        // FEATURE: Remover oportunidade
        public HttpResponseMessage Delete(string id)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    if (OpportunityIntegration.Delete(Authentication.GetRepresentative(null), id))
                    {
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden);
            }
        }
    }
}