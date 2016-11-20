﻿using Newtonsoft.Json;

namespace FirstREST.LibPrimavera.Model
{
    public class ContactListing : EntityListing
    {
        [JsonProperty(PropertyName = "title")]
        public string Titulo
        {
            get;
            set;
        }
    }
}