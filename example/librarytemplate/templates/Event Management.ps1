
#defined parameters
#param ($libraryName="test092001", $parentWeb = "https://m365x89003827.sharepoint.com/sites/benefits", $tenant="M365x89003827.onmicrosoft.com", $clientId="beae8b8b-324d-4d67-aa71-11d355ddf975", $thumbprint="93F6299729C2E1DF741602D0BB584D0A8293D6AE")
param ($libraryName, $parentWeb, $tenant, $clientId, $thumbprint)

function AddListContentType {
    param (
        $ContentTypeDescription, 
        $ContentTypeGroupName, 
        $ContentTypeName, 
        $FolderName
    )

    Connect-PnPOnline -Url $parentWeb -ClientId $clientId -Thumbprint $thumbprint -Tenant $tenant
    Write-Information "connect $parentWeb successfully"
    $LibraryTitle = $libraryName
 
    $targetWeb = Get-PnPWeb
    Write-Information "get target web $($targetWeb.Title) successfully"
    # Get Context
    $clientContext = Get-PnPContext

    # Get the list object where you need to add the content type
    $targetList = $targetWeb.Lists.GetByTitle($LibraryTitle)
    $listContentTypes = $targetList.ContentTypes
    # Load List object
    $clientContext.Load($targetList)
    $clientContext.Load($listContentTypes)
    $clientContext.ExecuteQuery()
    if (($listContentTypes | ForEach-Object Name) -contains $ContentTypeName) {
        Write-Information "the list  $LibraryTitle already contains the content type."
        return $result
    }
    Write-Information "get target list  $LibraryTitle successfully"

    Add-PnPFolder -Name $FolderName -Folder $LibraryTitle
    Write-Information "add foler $FolderName successfully"

    if ($ContentTypeName) {
        #Get the Parent content type
        $SiteContentType = Get-PnPContentType -Identity $ContentTypeName 
        if (!$SiteContentType) {
            Write-Information "content type $ContentTypeName doesn't exist"
            # Get site content type object
            Add-PnPContentType -Name $ContentTypeName -Description $ContentTypeDescription -Group $ContentTypeGroupName -ErrorAction Stop
            $SiteContentType = Get-PnPContentType -Identity $ContentTypeName -ErrorAction Stop
        }
        else {
            Write-Information "content type $ContentTypeName exists"
        }
        # Add content type to list
        $targetList.ContentTypes.AddExistingContentType($SiteContentType)
        $targetList.Update()
        $clientContext.ExecuteQuery()
    } 
}

$result = "success"
try {
    $ContentTypeDescription ="Base Content Type for Crescent Projects Template"
    $ContentTypeGroupName = "Document Content Types"
    $FolderName='Event Management'
    $ContentTypeName='Event Management'
 
    AddListContentType -ContentTypeDescription $ContentTypeDescription -ContentTypeGroupName $ContentTypeGroupName -ContentTypeName $ContentTypeName -FolderName $FolderName
}
catch {

    $result = $_.Exception.Message
    Write-Error "An error happened while running script, reason:$result"
}
finally {
    Disconnect-PnPOnline
}
$result