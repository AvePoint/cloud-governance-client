namespace Example
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;


    public class LockSiteRequestExample : ExampleBase
    {
        public Guid Submit()
        {

            try
            {
                var siteUrl = "https://xxxx.sharepoint.com/sites/CreateSiteCollectionaaa";
                var apiInstance = new RequestsApi(Configuration.Default);
                var lockSiteRequest = new LockSiteRequest
                {
                    Summary = "lock site",
                    ServiceId = new Guid("906d41ea-b79d-4541-97b7-df107a2dba7b"),
                    Action = SiteLifecycleActionType.Lock,
                    Department = "IT",
                    SiteUrl = siteUrl,
                    SiteId = new Guid("c3c8d93d-10d7-4a0b-98b1-37fd604711a9"),
                    LockType = SiteLockType.ReadOnly,
                    Metadatas = this.GetMetadatas()
                };

                // submit lock site request
                Guid result = apiInstance.SubmitLockSiteRequest(lockSiteRequest);
                Debug.WriteLine(result);
                return result;
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RequestsApi.SubmitLockSiteRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
                return Guid.Empty;
            }
        }

        private List<RequestMetadata> GetMetadatas()
        {
            var loginName = "someone@example.com";
            return new List<RequestMetadata>
                {
                    new RequestMetadata
                    {
                        Id = new Guid("2742cbb2-eb5a-4809-86fb-9c98feb46346"),
                        Type = MetadataFieldTypeNullable.AzureADProperty,
                        UpsOrAzureAdValue = new LookupValue
                        {
                            UserPropertyValue = "value",
                            UserPropertyDisplayValue = "value",
                            TargetUser = new ApiUser
                            {
                                LoginName = loginName,
                                DisplayName = "Sear Lin"
                            }
                        },
                    },
                    new RequestMetadata
                    {
                        Id = new Guid("311a2915-89c3-4769-b066-e98e987b8887"),
                        Type = MetadataFieldTypeNullable.UserProfileService,
                        UpsOrAzureAdValue = new LookupValue
                        {
                            UserPropertyValue = "value",
                            UserPropertyDisplayValue = "value",
                            TargetUser = new ApiUser
                            {
                                LoginName =loginName,
                                DisplayName = "Sear Lin"
                            }
                        },
                    },
                    new RequestMetadata
                    {
                        Id = new Guid("388dfe49-7550-4986-b663-0e69ffe005a6"),
                        Type = MetadataFieldTypeNullable.Hyperlink,
                        LinkValue = new LinkValue
                        {
                            Title = "AvePoint",
                            Address = "https://www.avepoint.com"
                        }
                    },
                    new RequestMetadata
                    {
                        Id = new Guid("5901e5a5-9634-4b41-88bc-33a2276061d2"),
                        Type = MetadataFieldTypeNullable.Terms,
                        TermsValue = new TermsValue
                        {
                            Value = new List<GuidModel>
                            {
                                new GuidModel
                                {
                                    Id = new Guid("1b134fb6-7940-4a01-b934-463c35dc109d"),
                                    Name = "Aisa"
                                }
                            }
                        }
                    },
                    new RequestMetadata
                    {
                        Id = new Guid("09d31429-a765-4a58-ba75-930279a9cd24"),
                        Type = MetadataFieldTypeNullable.PeoplePickerValue,
                        UserValue = new List<ApiUser>
                        {
                            new ApiUser
                            {
                                LoginName = loginName,
                                DisplayName = "Sear Lin"
                            }
                        }
                    },
                    new RequestMetadata
                    {
                        Id = new Guid("19eccba3-dc20-426d-98d4-bfbdd7696a95"),
                        Type = MetadataFieldTypeNullable.Choices,
                        ChoiceValue = new List<String>
                        {
                            "option1"
                        }
                    },
                    new RequestMetadata
                    {
                        Id = new Guid("1a9fc15d-a7b5-49c9-8d34-95802e208c28"),
                        Type = MetadataFieldTypeNullable.YesOrNo,
                        BooleanValue = true
                    },
                    new RequestMetadata
                    {
                        Id = new Guid("df72e4b5-50f7-4ebe-80fc-26c0b7d3f4e0"),
                        Type = MetadataFieldTypeNullable.MultiLineText,
                        SingleLineOrMultipleLineValue = "multiline text"
                    },
                    new RequestMetadata
                    {
                        Id = new Guid("1b57b2a6-90b8-4bb2-ad7b-b4c0bc255ee5"),
                        Type = MetadataFieldTypeNullable.SingleLineText,
                        SingleLineOrMultipleLineValue = "singleline text"
                    }
                };
        }
    }
}
