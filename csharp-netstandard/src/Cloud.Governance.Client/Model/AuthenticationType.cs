

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    
    public enum AuthenticationType
    {
        LocalSystem = 0,

        WindowsIntegration = 1,

        ADIntegration = 2,

        ADFSIntegration = 3,

        Federation = 4,

        SharePointOnline = 6,

        SalesForce = 7,

        Yammer = 8,

        AzureAD = 9,

        Sandbox = 10,

        SharePoint = 11,

        Exchange = 12

    }

}
