

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
    
    public enum TreeNodeType
    {
        Root = 0,

        WebApplication = 2,

        Tenant = 3,

        Container = 4,

        ManagedPath = 10,

        SiteCollection = 100,

        Site = 200,

        Sites = 201,

        Lists = 202,

        List = 300,

        DocumentLibrary = 310,

        Folder = 400,

        Folders = 401,

        Items = 402,

        Item = 500,

        File = 501,

        Team = 598,

        Yammer = 599,

        Group = 600,

        GuestUser = 601,

        PrivateChannel = 602,

        All = 1000,

        WebApplication_D = -5,

        BPOSDCA = -4,

        SelectAll = -3,

        None = -2,

        Farm = -1

    }

}
