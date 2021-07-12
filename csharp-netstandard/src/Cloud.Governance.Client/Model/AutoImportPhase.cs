

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
    
    public enum AutoImportPhase
    {
        Confirmed = 0,

        Processing = 1,

        PendingInition = 2,

        ApplyInformationException = 3,

        Overdue = 4,

        PendingRenewal = 5,

        RenewalExpired = 6,

        RenewalProcessing = 7,

        RenewalException = 8,

        Locked = 9,

        RenewalCanceled = 10,

        RenewalPreparing = 11,

        Invalid = 12,

        Archived = 13,

        Escalation = 14,

        ITRenewalCanceled = 15

    }

}
