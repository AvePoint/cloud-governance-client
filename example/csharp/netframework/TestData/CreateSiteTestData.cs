using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    public class CreateSiteTestData
    {
        public String SiteName { get; set; } = DateTime.Now.ToString("yyyyMMddHHmmss");

        public String Department { get; set; }

        public String PolicyName { get; set; }

        public String LanguageName { get; set; }

        public String ServiceName { get; set; }

        public String PrimaryAdminLoginName { get; set; }

        public String AdditionalAdminLoginNames { get; set; }

        public String PrimaryContactLoginName { get; set; }

        public String SecondaryContactLoginName { get; set; }

        public String TimeZoneName { get; set; }

        public String TemplateTitle { get; set; }

        public String GrantedUserLoginName { get; set; }

        public String GrantedUserPermissionLevelNames { get; set; }

        public String SharePointGroupName { get; set; }

        public String SharePointGroupMemberLoginNames { get; set; }

        public String MultiGeoLocatioinName { get; set; }

        public Dictionary<String, String> Metadata { get; set; }
    }
}
