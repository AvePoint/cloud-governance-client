

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
    
    public enum ApiRequestProgressStatus
    {
        None = 0,

        RequestSubmitted = 1,

        WaitingForApproval = 2,

        WaitingForSubmission = 3,

        Cancelled = 4,

        Rejected = 5,

        Completed = 6,

        CompletedWithException = 7,

        EncounterError = 8,

        InProgress = 9,

        FailedWithSubRequestException = 10

    }

}
