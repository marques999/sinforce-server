﻿using System;
using System.Collections.Generic;

using Interop.GcpBE900;

using FirstREST.Lib_Primavera.Model;

namespace FirstREST.Lib_Primavera.Integration
{
    public class OpportunityIntegration
    {
        public static List<Opportunity> GetOpportunities()
        {
            if (PriEngine.InitializeCompany(Properties.Settings.Default.Company.Trim(), Properties.Settings.Default.User.Trim(), Properties.Settings.Default.Password.Trim()) == false)
            {
                return null;
            }

            return new List<Opportunity>();
        }

        public static Opportunity GetOpportunity(string paramId)
        {
            if (PriEngine.InitializeCompany(Properties.Settings.Default.Company.Trim(), Properties.Settings.Default.User.Trim(), Properties.Settings.Default.Password.Trim()) == false)
            {
                return null;
            }

            if (PriEngine.Clientes.Existe(paramId) == false)
            {
                return null;
            }

            return null;
        }

        public static bool UpdateOpportunity(string leadId, Opportunity myLead)
        {
            if (PriEngine.InitializeCompany(Properties.Settings.Default.Company.Trim(), Properties.Settings.Default.User.Trim(), Properties.Settings.Default.Password.Trim()) == false)
            {
                throw new DatabaseException("LeadIntegration");
            }

            if (PriEngine.Clientes.Existe(leadId) == false)
            {
                return false;
            }

            return true;
        }

        public static bool CreateOpportunity(string leadId, Opportunity leadModel)
        {
            if (PriEngine.InitializeCompany(Properties.Settings.Default.Company.Trim(), Properties.Settings.Default.User.Trim(), Properties.Settings.Default.Password.Trim()) == false)
            {
                throw new DatabaseException("LeadIntegration");
            }

            return true;
        }
    }
}