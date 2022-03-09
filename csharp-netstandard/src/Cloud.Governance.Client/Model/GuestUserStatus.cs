

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
    
    public enum GuestUserStatus
    {
        Active = 0,

        RenewalPreparing = 1,

        RenewalPending = 2,

        RenewalProcessing = 3,

        RenewalCompleted = 4,

        RenewalException = 5,

        RenewalOverdue = 6,

        Deleted = 7,

        Disabled = 8,

        RenewalDisabled = 9,

        AutoImportProcessInProgress = 10,

        AutoImportTaskException = 11,

        AutoImportComplete = 12,

        ElectionDisabled = 13

    }

}
