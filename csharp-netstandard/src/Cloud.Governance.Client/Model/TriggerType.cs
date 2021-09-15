

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
    
    public enum TriggerType
    {
        None = 0,

        RequestSubmitted = 1,

        RequestCompleted = 2,

        RequestCancelled = 4,

        TaskCreated = 8,

        TaskApproved = 16,

        TaskRejected = 32,

        ErrorTaskCreated = 64,

        TaskRetried = 128,

        TaskSkipped = 256,

        RenewalSuccess = 512,

        RenewalException = 1024,

        RenewalOverdue = 2048,

        FullyAutoImportSuccess = 4096,

        ConfirmDetailSuccess = 8192,

        ElectionCompleted = 16384,

        LifecycleInactiveTaskCreated = 32768,

        LifecycleLeaseTaskCreated = 65536,

        ElectionOverdue = 131072

    }

}
