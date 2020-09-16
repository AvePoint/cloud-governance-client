namespace NetFramework
{
    using Cloud.Governance.Client.Api;
    using Cloud.Governance.Client.Client;
    using Cloud.Governance.Client.Model;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Net;

    public class ExampleBase
    {
        public ServicesApi ServicesApi { get; set; }

        public ExampleBase()
        {
            Configuration.Default.BasePath = "Replace with Cloud Governance Modern API Endpoint";

            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "w/D...");

            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");

            this.ServicesApi = new ServicesApi(Configuration.Default);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public Guid GetServiceId(String serviceName)
        {
            var services = this.ServicesApi.GetMyServices(serviceName).Value;
            var service = services.Where(s => s.Name.EqualsIgnoreCase(serviceName)).FirstOrDefault();
            return service.Id;
        }

        public CreateSiteService GetCreateSiteService(String serviceName)
        {
            var serviceId = this.GetServiceId(serviceName);
            return this.ServicesApi.GetCreateSiteService(serviceId);
        }

        public CreateGroupService GetCreateGroupService(String serviceName)
        {
            var serviceId = this.GetServiceId(serviceName);
            return this.ServicesApi.GetCreateGroupService(serviceId);
        }

        public List<RequestMetadata> GetSampleMetadatas()
        {
            var loginName = "someone@example.com";
            var displayName = "displayname";
            return new List<RequestMetadata>
                {
                    new RequestMetadata
                    {
                        Name="metadataName1",
                        Type = MetadataFieldType.AzureADProperty,
                        UpsOrAzureAdValue = new LookupValue
                        {
                            UserPropertyValue = "value",
                            UserPropertyDisplayValue = "value",
                            TargetUser = new ApiUser
                            {
                                LoginName = loginName,
                                DisplayName = displayName
                            }
                        },
                    },
                    new RequestMetadata
                    {
                        Name="metadataName2",
                        Type = MetadataFieldType.UserProfileService,
                        UpsOrAzureAdValue = new LookupValue
                        {
                            UserPropertyValue = "value",
                            UserPropertyDisplayValue = "value",
                            TargetUser = new ApiUser
                            {
                                LoginName =loginName,
                                DisplayName = displayName
                            }
                        },
                    },
                    new RequestMetadata
                    {
                        Name="metadataName3",
                        Type = MetadataFieldType.Hyperlink,
                        LinkValue = new LinkValue
                        {
                            Title = "AvePoint",
                            Address = "https://www.avepoint.com"
                        }
                    },
                    new RequestMetadata
                    {
                        Name="metadataName4",
                        Type = MetadataFieldType.Terms,
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
                        Name="metadataName5",
                        Type = MetadataFieldType.PeoplePickerValue,
                        UserValue = new List<ApiUser>
                        {
                            new ApiUser
                            {
                                LoginName = loginName,
                                DisplayName = displayName
                            }
                        }
                    },
                    new RequestMetadata
                    {
                        Name="metadataName6",
                        Type = MetadataFieldType.Choices,
                        ChoiceValue = new List<String>
                        {
                            "option1"
                        }
                    },
                    new RequestMetadata
                    {
                        Name="metadataName7",
                        Type = MetadataFieldType.YesOrNo,
                        BooleanValue = true
                    },
                    new RequestMetadata
                    {
                        Name="metadataName8",
                        Type = MetadataFieldType.MultiLineText,
                        SingleLineOrMultipleLineValue = "multiline text"
                    },
                    new RequestMetadata
                    {
                        Name="metadataName9",
                        Type = MetadataFieldType.SingleLineText,
                        SingleLineOrMultipleLineValue = "singleline text"
                    }
                };
        }
    }
}
