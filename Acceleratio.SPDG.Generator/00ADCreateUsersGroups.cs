﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acceleratio.SPDG.Generator
{
    public partial class DataGenerator
    {
        public void CreateADUsersAndGroups()
        {
            if( workingDefinition.NumberOfUsersToCreate > 0  )
            {
                try
                {
                    Log.Write("Creating Active Directory users.");
                    AD.createUsers(workingDefinition.ADDomainName, workingDefinition.ADOrganizationalUnit, workingDefinition.NumberOfUsersToCreate);
                }
                catch(Exception ex)
                {
                    Errors.Log(ex);
                }
            }

            if ( workingDefinition.NumberOfSecurityGroupsToCreate > 0)
            {
                try
                {
                    Log.Write("Creating Active Directory groups.");
                    AD.createGroups(workingDefinition.ADDomainName, workingDefinition.ADOrganizationalUnit, workingDefinition.NumberOfSecurityGroupsToCreate);
                }
                catch (Exception ex)
                {
                    Errors.Log(ex);
                }

            }


        }
    }
}
