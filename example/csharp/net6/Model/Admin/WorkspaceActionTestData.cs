namespace NetFramework
{
    using Cloud.Governance.Client.Model;
    using System;

    public class WorkspaceActionTestData
    {
        public Guid ObjectId { get; set; }

        public WorkspaceType WorkspaceType { get; set; }

        public Boolean IsSite()
        {
            return this.WorkspaceType == WorkspaceType.Site;
        }

        public Boolean IsGroup()
        {
            return this.WorkspaceType == WorkspaceType.Group
                || this.WorkspaceType == WorkspaceType.Teams;
        }
    }
}
