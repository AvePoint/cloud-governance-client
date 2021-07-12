

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
    
    public enum ThemeType
    {
        None = 0,

        NavyBlue = 1,

        LightBlack = 2,

        LightBlue = 3,

        Orange = 4,

        GrassGreen = 5,

        Pink = 6,

        EmeraldGreen = 7,

        Lilac = 8

    }

}
