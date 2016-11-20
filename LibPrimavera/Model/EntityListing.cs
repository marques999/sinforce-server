﻿using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FirstREST.LibPrimavera.Model
{
    public class EntityListing
    {
        [JsonProperty(PropertyName = "id")]
        public string Identificador
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "name")]
        public string Nome
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "address")]
        public string Localizacao
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "state")]
        public string Distrito
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "country")]
        public string Pais
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "email")]
        public string Email
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "mobile")]
        public string Telemovel
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "dateModified")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime ModificadoEm
        {
            get;
            set;
        }
    }
}