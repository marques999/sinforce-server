﻿using System;
using Newtonsoft.Json;

namespace FirstREST.LibPrimavera.Model
{
    public class Representative
    {
        [JsonProperty(PropertyName = "id")]
        public string Identificador
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "name")]
        public string NomeCompleto
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

        [JsonProperty(PropertyName = "phone")]
        public string Telefone
        {
            get;
            set;
        }


        [JsonProperty(PropertyName = "picture")]
        public string Fotografia
        {
            get;
            set;
        }

        public void setPicture(byte[] pictureData)
        {
            Fotografia = Convert.ToBase64String(pictureData);
        }

        [JsonProperty(PropertyName = "mobile")]
        public string Telemovel
        {
            get;
            set;
        }
    }
}