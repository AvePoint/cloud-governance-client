$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "6.10.0")){
    Install-Module -Name $ModuleName -Force -MinimumVersion "6.10.0"
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

$Top = 3000

try {
    $TotalSites = New-Object System.Collections.ArrayList
    $NextToken = ""
    $StopWatch = [System.Diagnostics.Stopwatch]::StartNew()
    $StopWatch.Start()  
    $Filter = "type eq 'site'"
    do {
        
        $PageResult = Get-WorkspaceReport -NextToken $NextToken -Top $Top -Filter $Filter
        if ($null  -ne $PageResult.value) {
            $TotalSites.AddRange($PageResult.value)
        }
          
        Write-Host("Count:" + $TotalSites.Count)
        $NextToken = $PageResult.nexttoken
    } while ( $null -ne $NextToken) 
    
    $Result = $TotalSites | Select-Object -Property * -ExpandProperty Metadata -ExcludeProperty Metadata
    $Result | Export-Csv -Path "AllSites.csv" -NoTypeInformation -Encoding UTF8

    $StopWatch.Stop()
    Write-Host "Elapsed:" + $StopWatch.Elapsed
}
catch {
    Write-Host ($_.Exception)
}
