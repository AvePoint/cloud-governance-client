

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
    
    public enum ConflictSolutionType
    {
        Skip = 0,

        NotOverWrite = 1,

        Append = 2,

        OverWrite = 3,

        Replace = 4,

        Merge = 5,

        OverWritebyLastModifiedTime = 6,

        None = 7

    }

}
