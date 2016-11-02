﻿using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FirstREST.LibPrimavera.Model
{
    public class Customer : Contact
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

        [JsonProperty(PropertyName = "debt")]
        public double Debito
        {
            get;
            set;
        }


        [JsonProperty(PropertyName = "pending")]
        public double Pending
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

    public class CustomerListing : ContactListing
    {
        [JsonProperty(PropertyName = "status")]
        public string Status
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "debt")]
        public double Debito
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "pending")]
        public double Pending
        {
            get;
            set;
        }
    }
}