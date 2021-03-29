
namespace NetFramework
{
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CreateGuestUserTestData
    {
        public String ServiceName { get; set; }
        public String PrimaryContactLoginName { get; set; }
        public String SecondaryContactLoginName { get; set; }
        public String DisplayName { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String WelcomeMessage { get; set; }
        public String InviteGroup { get; set; }
    }
}
