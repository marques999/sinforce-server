﻿using System.ComponentModel;

namespace FirstREST.LibPrimavera.Model
{
    public enum EntityType
    {
        [Description("N")]
        Unknown = -1,
        [Description("C")]
        Customer,
        [Description("L")]
        Lead,
        [Description("X")]
        Contact
    }
}