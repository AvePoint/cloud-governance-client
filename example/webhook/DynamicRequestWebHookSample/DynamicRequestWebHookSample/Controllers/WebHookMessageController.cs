using Microsoft.AspNetCore.Mvc;
using Cloud.Governance.Client.Api;
using Cloud.Governance.Client.Client;
using Cloud.Governance.Client.Model;

namespace Webhook;

[ApiController]
[Route("WebHookMessage")]
public class WebHookMessageController : ControllerBase
{
    [HttpPost("RunTest")]
    public ActionResult RunTest(HookMessage message)
    {
        //https://cdn.avepoint.com/assets/webhelp/avepoint-cloud-governance-administrator-guide/index.htm#!Documents/managewebhooks.htm
        if (message.TriggerType != "RequestCompleted")
        {
            return new OkResult();
        }
        if(message.ServiceName !="specific service name")
        {
            //filter service name
        }
        Configuration.Default.BasePath = "https://go-api.avepointonlineservices.com";

        Configuration.Default.AddApiKey("userPrincipalName", "xxx@xxx.space");

        Configuration.Default.AddApiKey("clientSecret", "bcWT...");

        var requestApi = new RequestsApi(Configuration.Default);
        var dynamicRequest = requestApi.GetDynamicRequest(message.RequestGuid);

        if (dynamicRequest.Metadatas != null)
        {
           
            //Get request metadata
            foreach (var dynamicRequestMetadata in dynamicRequest.Metadatas)
            {
                var metadataName = dynamicRequestMetadata.Name;
                var metadataValue = dynamicRequestMetadata.Value;
            }

            //get gallery metadata and team id
            CreateTeamGallery createTeamsGallery = null;
            if (dynamicRequest.ActivityGalleries != null)
            {
                foreach (var dynamicRequestActivityGallery in dynamicRequest.ActivityGalleries)
                {
                    if (dynamicRequestActivityGallery.GalleryType == "CreateTeam")
                    {
                        createTeamsGallery = requestApi.GetDynamicRequestCreateTeamsGallery(dynamicRequest.Id.Value, dynamicRequestActivityGallery.GalleryInternalName);
                    }
                    //dynamicRequestActivityGallery should be subclass , but it isn't now
                    foreach (var galleryMetadata in dynamicRequestActivityGallery.GalleryMetadata)
                    {
                        //get gallery metadata
                        var metadataName = galleryMetadata.Name;
                        var metadataValue = galleryMetadata.Value;
                    }
                }
            }

            //get teams object Id
            if(createTeamsGallery!=null)
            {
                var teamsObjectId = createTeamsGallery.ObjectId;
            }
        }

        return this.Ok();
    }
}