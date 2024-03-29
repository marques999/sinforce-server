﻿using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

using FirstREST.LibPrimavera;
using FirstREST.LibPrimavera.Model;
using FirstREST.LibPrimavera.Integration;

namespace FirstREST.Controllers
{
    public class ProposalsController : ApiController
    {
        // GET: api/proposals/{$proposalsId}/{$proposalNumber}
        // FEATURE: Listar proposttas da oportunidade
        public HttpResponseMessage Get(string id, short sid)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    return Request.CreateResponse(HttpStatusCode.OK, ProposalsIntegration.View(Authentication.GetRepresentative(null), id, sid));
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

        // GET: api/proposals/{$proposalsId}
        // FEATURE: Visualizar proposta
        public HttpResponseMessage Get(string id)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    return Request.CreateResponse(HttpStatusCode.OK, ProposalsIntegration.List(Authentication.GetRepresentative(null), id));
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

        // POST: api/proposals
        // FEATURE: Adicionar proposta
        public HttpResponseMessage Post([FromBody] Proposals jsonObject)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    var operationResult = ProposalsIntegration.Insert(Authentication.GetRepresentative(null), jsonObject);

                    if (operationResult == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, operationResult);
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

        // PUT: api/proposals/{$proposalsId}
        // FEATURE: Editar proposta existente
        public HttpResponseMessage Put(string id, [FromBody] Proposals jsonObject)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    var operationResult = ProposalsIntegration.Update(Authentication.GetRepresentative(null), HttpUtility.UrlDecode(id), jsonObject);

                    if (operationResult == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, operationResult);
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

        // DELETE: api/proposals/{$proposalsId}/{$proposalNumber}
        // FEATURE: Remover proposta existente
        public HttpResponseMessage Delete(string id, short sid)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    if (ProposalsIntegration.Delete(Authentication.GetRepresentative(null), HttpUtility.UrlDecode(id), sid))
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

        // DELETE: api/proposals/{$proposalsId}
        // FEATURE: Remover todas as propostas
        public HttpResponseMessage Delete(string id)
        {
            if (Authentication.VerifyToken("?"))
            {
                try
                {
                    if (ProposalsIntegration.DeleteAll(Authentication.GetRepresentative(null), HttpUtility.UrlDecode(id)))
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