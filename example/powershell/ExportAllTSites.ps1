
$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "4.1.16")){
    Install-Module -Name $ModuleName -Force -MinimumVersion "4.1.16"
}

Import-Module -Name $ModuleName

$Configuration = Get-Configuration
$Configuration["BaseUrl"] = "API URL"
$Configuration["ApiKey"]["clientId"] = ""
$Configuration["ApiKey"]["clientSecret"] = ""
$Configuration["ApiKey"]["userPrincipalName"] = ""

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
