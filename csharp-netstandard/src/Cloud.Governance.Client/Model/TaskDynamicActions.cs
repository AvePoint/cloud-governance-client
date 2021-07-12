

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
    
    public enum TaskDynamicActions
    {
        None = 0,

        Extend = 1,

        Archive = 2,

        ChangePolicy = 3,

        OffBoarding = 4,

        Delete = 5,

        ContinueAccess = 6,

        Claim = 7,

        Decline = 8,

        SpecifyContacts = 9,

        SpecifySecondaryContact = 10

    }

}
