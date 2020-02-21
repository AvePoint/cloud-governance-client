namespace Example
{
    using Cloud.Governance.Client.Client;

    public class ExampleBase
    {
        static ExampleBase()
        {
            Configuration.Default.BasePath = "https://api_base_url";
            // Configure API key authorization: ClientId
            Configuration.Default.AddApiKey("clientId", "ceb5...");

            // Configure API key authorization: ClientSecret
            Configuration.Default.AddApiKey("clientSecret", "BtH...");

            // Configure API key authorization: UserPrincipalName
            Configuration.Default.AddApiKey("userPrincipalName", "someone@example.com");
        }
    }
}
