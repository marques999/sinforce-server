﻿using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FirstREST.Lib_Primavera.Model
{
    public class Account
    {
        [JsonProperty(PropertyName = "name")]
        public string Nome
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "address")]
        public Address Morada
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

        [JsonProperty(PropertyName = "website")]
        public string Website
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "phone")]
        public string Telefone
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "taxNumber")]
        public string NumContribuinte
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "currency")]
        public string Moeda
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "lastUpdated")]
        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime LastUpdated
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "createdAt")]
        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime CreatedAt
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "owner")]
        public UserReference Owner
        {
            get;
            set;
        }
    }
}