﻿using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FirstREST.Lib_Primavera.Model
{
    public class Account : Contact
    {
        [JsonProperty(PropertyName = "website")]
        public string Website
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "status")]
        public string Status
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "dateCreated")]
        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime DateCreated
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "taxNumber")]
        public string TaxNumber
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "currency")]
        public string Currency
        {
            get;
            set;
        }
    }
}