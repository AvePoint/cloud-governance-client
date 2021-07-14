$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "4.7.4")){
    Install-Module -Name $ModuleName -Force -MinimumVersion "4.7.4"
}


Import-Module -Name $ModuleName

$Configuration = Get-Configuration

# You can find the Modern API Endpoint in Cloud Governance admin user guide for your environment.
$Configuration["BaseUrl"] = "{Cloud_Governance_Modern_API_Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."

# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"

try {

    $TotalSites = New-Object System.Collections.ArrayList
    $NextToken = ""
    $Filter = "type eq 'Group' or type eq 'Teams' "

    do {
        
        $PageResult = Get-Workspaces -NextToken $NextToken -VarFilter $Filter
        if (($null  -ne $PageResult.value) -and $PageResult.value.Length -gt 0) 
        {
           $TotalSites.AddRange($PageResult.value)
        }
          
        Write-Host("Count:" + $TotalSites.Count)
        $NextToken = $PageResult.nexttoken
    } while ( $null -ne $NextToken) 
    
    $Result = $TotalSites | Select-Object -Property *  
    $Result | Export-Csv -Path "AllGroupsAndTeams.csv" -NoTypeInformation -Encoding UTF8
}
catch {
    Write-Host ($_.Exception)
    Write-Host ($_.ErrorDetails.Message)
}