Try
{
   $ModuleName="Cloud.Governance.Client"
   if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "5.9.1.0")){
    Install-Module -Name $ModuleName -Force -MinimumVersion "5.9.1.0"
   }

   Import-Module -Name $ModuleName

    $Configuration = Get-Configuration
    $Configuration["BaseUrl"] = "{Cloud Governance Modern API Endpoint}"

    # Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
    $Configuration["ApiKey"]["clientSecret"] = "eyJ..."
    # Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
    # Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
    # If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
    $Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"


    # please replace the following parameter values with yours

    $serviceName ="Service Name of Create Site collection Service"
    $siteName = "SiteName"
    $primaryContact = "user1@example.com"
    $secondaryContact = "user2@example.com"
    $metadataName ="Service Metadata Name"
    $metadataValue ="Metadata Value"

    #-----------------------------------------------------------

    #Get service Id by service Name
    $serviceId = Get-ServiceId -Name $serviceName

    #Get create site collection service detail
    $service = Get-CreateSiteService -Id $serviceId

    #Use the RequestTemplate to get a template request, so that we don't need create a new request
    $request = $service.RequestTemplate
    $request.SiteUrl.Name = $siteName
    $request.SiteTitle = $siteName
    $request.Summary = $siteName
    $request.PrimaryContact = New-ApiUser -LoginName $primaryContact
    $request.SecondaryContact = New-ApiUser -LoginName $secondaryContact
    #find the metadata by name
    $metadata = $request.Metadatas | Where-Object {$_.Name -eq $metadataName } |Select -First 1

    #update metadata value
    if($metadata -ne $null){
        $metadata.Value = $metadataValue
    }
    Submit-CreateSiteRequest -CreateSiteRequest  $request
}catch
{
 Write-Host $_
}
