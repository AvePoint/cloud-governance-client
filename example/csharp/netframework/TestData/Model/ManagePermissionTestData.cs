
using Cloud.Governance.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    public class ManagePermissionTestData
    {
        public String ServiceName { get; set; }

        public String ObjectUrl { get; set; }

        public String GrantUserLoginName { get; set; }

        public String PermissionLevels { get; set; }

        public String SpGroupNameChangeValue { get; set; }

        public String SpGroupNameOriginalValue { get; set; }

        public String SpGroupDescription { get; set; }

        public String SpGroupOwnerLoginName { get; set; }

        public String SpGroupMemberIdentityName { get; set; }

        public String SpGroupMemberDisplayName { get; set; }

        public String ObjectInfoLoginName { get; set; }

        public String Department { get; set; }

        public String UserLoginName { get; set; }

        public String UserDisplayName { get; set; }
    }
}
