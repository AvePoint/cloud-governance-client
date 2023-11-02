$ModuleName="Cloud.Governance.Client"
if( $null -eq  (Get-InstalledModule -Name $ModuleName -MinimumVersion "6.10.0")){
 Install-Module -Name $ModuleName -Force -MinimumVersion "6.10.0"
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
try {
    
$Urls = Import-CSV -Path "$PSScriptRoot\Urls.csv"
$TotalCount = $Urls.Count
$stopwatch =  [system.diagnostics.stopwatch]::StartNew()

$Filter = "(taskType eq 'SCNoAccess' or taskType eq 'GroupInactivityThreshold') and status eq 'Running'"
$Tasks = New-Object System.Collections.ArrayList
# get all tasks

$count = 0
$urlFilters = New-Object System.Collections.ArrayList
foreach($Url in $Urls)
{
    $count++;
    $urlFilters.Add("Url eq '$($Url.Url)'" )
    if($count%200 -eq 0 -or $count -eq $TotalCount){
        $urlFilterString = $urlFilters -join " or "
        $PageResult = Get-AllTasks  -Filter "$($Filter) and ($($urlFilterString))"
        if (($null  -ne $PageResult.Value) -and $PageResult.Value.Length -gt 0) {
            $Tasks.AddRange($PageResult.Value)
        }
    }
}

Write-Host("Finish to get tasks by urls, duration: $($stopwatch.Elapsed),count: $($Tasks.Count)")

  Write-Host("Begin to Continue Access Auto Task")

  foreach($task in $Tasks){
    $stopwatch1 =  [system.diagnostics.stopwatch]::StartNew()
    if($task.ServiceType -eq 3){
        Submit-ContinueAccessSiteAutoTask -Id $task.Id
    }else{
        Submit-ContinueAccessGroupAutoTask -Id $task.Id
    }
    $stopwatch1.Stop()
    Write-Host("Finish to Continue Access a Auto Task, duration: $($stopwatch1.Elapsed),url: $($task.Url)")
  }
  Write-Host("Finish to Continue Access all Auto Tasks, duration: $($stopwatch.Elapsed)")

} catch {
    Write-Host ("Exception occured when calling Get-AllTasks: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}