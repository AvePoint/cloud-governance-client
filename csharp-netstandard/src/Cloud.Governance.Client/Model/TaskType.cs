

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
    
    public enum TaskType
    {
        ApprovalTask = 0,

        ErrorHandlingTask = 1,

        SCExpired = 2,

        SCNoAccess = 3,

        ToDoTask = 4,

        UserExpired = 5,

        GroupExpired = 6,

        GroupInactivityThreshold = 7,

        AutoImportGroup = 8,

        AutoImportSite = 9,

        RenewGroup = 10,

        RenewSite = 11,

        RenewGuestUser = 12

    }

}
