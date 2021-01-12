

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
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SPListTemplateType
    {
        [EnumMember(Value = "0")]
        NoListTemplate = 0,

        [EnumMember(Value = "100")]
        GenericList = 100,

        [EnumMember(Value = "101")]
        DocumentLibrary = 101,

        [EnumMember(Value = "102")]
        Survey = 102,

        [EnumMember(Value = "103")]
        Links = 103,

        [EnumMember(Value = "104")]
        Announcements = 104,

        [EnumMember(Value = "105")]
        Contacts = 105,

        [EnumMember(Value = "106")]
        Events = 106,

        [EnumMember(Value = "107")]
        Tasks = 107,

        [EnumMember(Value = "108")]
        DiscussionBoard = 108,

        [EnumMember(Value = "109")]
        PictureLibrary = 109,

        [EnumMember(Value = "110")]
        DataSources = 110,

        [EnumMember(Value = "111")]
        WebTemplateCatalog = 111,

        [EnumMember(Value = "112")]
        UserInformation = 112,

        [EnumMember(Value = "113")]
        WebPartCatalog = 113,

        [EnumMember(Value = "114")]
        ListTemplateCatalog = 114,

        [EnumMember(Value = "115")]
        XMLForm = 115,

        [EnumMember(Value = "116")]
        MasterPageCatalog = 116,

        [EnumMember(Value = "117")]
        NoCodeWorkflows = 117,

        [EnumMember(Value = "118")]
        WorkflowProcess = 118,

        [EnumMember(Value = "119")]
        WebPageLibrary = 119,

        [EnumMember(Value = "120")]
        CustomGrid = 120,

        [EnumMember(Value = "121")]
        SolutionCatalog = 121,

        [EnumMember(Value = "122")]
        NoCodePublic = 122,

        [EnumMember(Value = "123")]
        ThemeCatalog = 123,

        [EnumMember(Value = "124")]
        DesignCatalog = 124,

        [EnumMember(Value = "125")]
        AppDataCatalog = 125,

        [EnumMember(Value = "130")]
        DataConnectionLibrary = 130,

        [EnumMember(Value = "140")]
        WorkflowHistory = 140,

        [EnumMember(Value = "150")]
        GanttTasks = 150,

        [EnumMember(Value = "151")]
        HelpLibrary = 151,

        [EnumMember(Value = "160")]
        AccessRequest = 160,

        [EnumMember(Value = "171")]
        TasksWithTimelineAndHierarchy = 171,

        [EnumMember(Value = "175")]
        MaintenanceLogs = 175,

        [EnumMember(Value = "200")]
        Meetings = 200,

        [EnumMember(Value = "201")]
        Agenda = 201,

        [EnumMember(Value = "202")]
        MeetingUser = 202,

        [EnumMember(Value = "204")]
        Decision = 204,

        [EnumMember(Value = "207")]
        MeetingObjective = 207,

        [EnumMember(Value = "210")]
        TextBox = 210,

        [EnumMember(Value = "211")]
        ThingsToBring = 211,

        [EnumMember(Value = "212")]
        HomePageLibrary = 212,

        [EnumMember(Value = "301")]
        Posts = 301,

        [EnumMember(Value = "302")]
        Comments = 302,

        [EnumMember(Value = "303")]
        Categories = 303,

        [EnumMember(Value = "402")]
        Facility = 402,

        [EnumMember(Value = "403")]
        Whereabouts = 403,

        [EnumMember(Value = "404")]
        CallTrack = 404,

        [EnumMember(Value = "405")]
        Circulation = 405,

        [EnumMember(Value = "420")]
        Timecard = 420,

        [EnumMember(Value = "421")]
        Holidays = 421,

        [EnumMember(Value = "499")]
        IMEDic = 499,

        [EnumMember(Value = "600")]
        ExternalList = 600,

        [EnumMember(Value = "700")]
        MySiteDocumentLibrary = 700,

        [EnumMember(Value = "850")]
        PagesLibrary = 850,

        [EnumMember(Value = "1100")]
        IssueTracking = 1100,

        [EnumMember(Value = "1200")]
        AdminTasks = 1200,

        [EnumMember(Value = "1220")]
        HealthRules = 1220,

        [EnumMember(Value = "1221")]
        HealthReports = 1221,

        [EnumMember(Value = "1230")]
        DeveloperSiteDraftApps = 1230,

        [EnumMember(Value = "-1")]
        InvalidType = -1

    }

}
