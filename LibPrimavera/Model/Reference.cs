﻿using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FirstREST.LibPrimavera.Model
{
    public class Reference
    {
        public Reference()
        {
        }

        public Reference(string entityId, string entityName)
        {
            Identificador = entityId;
            Descricao = entityName;
        }

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