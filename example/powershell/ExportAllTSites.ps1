
$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "1.0.5" -ErrorAction Ignore)){
    Write-Host "Begin to install module $ModuleName"
    Install-Module -Name $ModuleName -Force -MinimumVersion "1.0.5"
    Write-Host "Install module successfully"
}

Import-Module -Name $ModuleName

$Configuration = Get-Configuration
$Configuration["BaseUrl"] = ""
$Configuration["ApiKey"]["clientSecret"] = ""
$Configuration["ApiKey"]["userPrincipalName"] = ""

if($Configuration["BaseUrl"] -eq ""){
 $Configuration["BaseUrl"] = Read-Host -Prompt 'Input API URL'
}

if($Configuration["ApiKey"]["userPrincipalName"] -eq ""){
 $Configuration["ApiKey"]["userPrincipalName"] = Read-Host -Prompt 'Input UserPrincipalName'
}

if($Configuration["ApiKey"]["clientSecret"] -eq ""){
 $Configuration["ApiKey"]["clientSecret"] = Read-Host -Prompt 'Input Client Secret'
}



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
