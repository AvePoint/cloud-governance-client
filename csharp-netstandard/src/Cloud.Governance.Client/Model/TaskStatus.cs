

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
    
    public enum TaskStatus
    {
        Created = 0,

        WaitingForActivation = 1,

        WaitingToRun = 2,

        Running = 3,

        WaitingForChildrenToComplete = 4,

        RanToCompletion = 5,

        Canceled = 6,

        Faulted = 7

    }

}
