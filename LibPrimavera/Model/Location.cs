﻿using Newtonsoft.Json;

namespace FirstREST.LibPrimavera.Model
{
    public class Location
    {
        [JsonProperty(PropertyName = "id")]
        public string Identificador
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "name")]
        public string Descricao
        {
            get;
            set;
        }
    }
}