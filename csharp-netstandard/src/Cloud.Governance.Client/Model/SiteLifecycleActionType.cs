

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
    
    public enum SiteLifecycleActionType
    {
        None = 0,

        Extend = 1,

        Delete = 2,

        Archive = 3,

        ChangePolicy = 4,

        Unlock = 5,

        Lock = 7,

        ChangeQuota = 8

    }

}
