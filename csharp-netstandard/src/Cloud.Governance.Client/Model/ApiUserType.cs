

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
    
    public enum ApiUserType
    {
        User = 1,

        DistributionList = 2,

        Office365Group = 4,

        SharePointGroup = 8,

        Guest = 16,

        SecurityGroupOnly = 32,

        MailEnabledSecurityGroup = 64,

        Group = 100,

        UserAndGroup = 101,

        All = 111

    }

}
