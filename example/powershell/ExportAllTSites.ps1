
$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "4.7.5")){
    Install-Module -Name $ModuleName -Force -MinimumVersion "4.7.5"
}


$Configuration = Get-Configuration
$Configuration["BaseUrl"] = "{Cloud Governance Modern API Endpoint}"

# Configure API key clientSecret: Navigate to AvePoint Cloud Governance Settings > API Authentication Management to Obtain a client secret.
$Configuration["ApiKey"]["clientSecret"] = "eyJ..."
# Configure API key userPrincipalName: The value of the userPrincipalName parameter is the login name of a delegated user that will be used to invoke the AvePoint Cloud Governance API. 
# Make sure the user's account has been added to AvePoint Online Services and has the license for AvePoint Cloud Governance.
# If you calls the Admin api, make sure the user's role is Service Administrator for AvePoint Cloud Governance.
$Configuration["ApiKey"]["userPrincipalName"] = "someone@example.com"

$Top = 1000

try {
    $TotalSites = New-Object System.Collections.ArrayList
    $NextToken = ""
    $StopWatch = [System.Diagnostics.Stopwatch]::StartNew()
    $StopWatch.Start()  

    do {
        
        $PageResult = Export-ManagedTeams -NextToken $NextToken -Top $Top
        if ($null  -ne $PageResult.value) {
            $TotalSites.AddRange($PageResult.value)
        }
          
        Write-Host("Count:" + $TotalSites.Count)
        $NextToken = $PageResult.nexttoken
    } while ( $null -ne $NextToken) 
    
    $Result = $TotalSites | Select-Object -Property * -ExpandProperty AllMetadata -ExcludeProperty AllMetadata  
    $Result | Export-Csv -Path "AllSites.csv" -NoTypeInformation -Encoding UTF8

    $StopWatch.Stop()
    Write-Host "Elapsed:" + $StopWatch.Elapsed
}
catch {
    Write-Host ($_.Exception)
}
