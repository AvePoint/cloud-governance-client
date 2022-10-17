
#defined parameters
param ($libraryName,$parentWeb,$metadatas,$tenant,$clientId,$thumbprint)

$result="success"
try
{
    $libraryManagementMetadataValue=$metadatas.'Library management'
    $FolderName=$libraryManagementMetadataValue
    $ContentTypeName=$libraryManagementMetadataValue

    $ContentTypeDescription ="Base Content Type for Crescent Projects Template"
    $ContentTypeGroupName = "Document Content Types"

    #Connect PnpOnline via app only token
    Connect-PnPOnline -Url $parentWeb -ClientId $clientId -Thumbprint $thumbprint -Tenant $tenant
 
    # Get Context
    $clientContext = Get-PnPContext

    # Get the library object
    $targetWeb = Get-PnPWeb
    $targetLibrary = $targetWeb.Lists.GetByTitle($libraryName)
 
    # Load List object
    $clientContext.Load($targetLibrary)
    $clientContext.ExecuteQuery()

    #if folder name is not null, create folder
    if($FolderName)
    {
        Add-PnPFolder -Name $FolderName -Folder $libraryName -ErrorAction Stop
    }

    #if content type name is not null, get or create content type
    if($ContentTypeName)
    {
        #Get the content type, if not exists, create a new one
        $SiteContentType = Get-PnPContentType -Identity $ContentTypeName 
        if(!$SiteContentType){
            # create a content type
            Add-PnPContentType -Name $ContentTypeName -Description $ContentTypeDescription -Group $ContentTypeGroupName -ErrorAction Stop
            $SiteContentType = Get-PnPContentType -Identity $ContentTypeName -ErrorAction Stop
        }
        # Add content type to library
        $targetLibrary.ContentTypes.AddExistingContentType($SiteContentType)
        $targetLibrary.Update()
        $clientContext.ExecuteQuery()
    } 
}
catch
{
    $result=$_.Exception.Message
}
finally
{
    Disconnect-PnPOnline
}
$result