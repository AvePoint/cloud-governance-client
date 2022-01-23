#
# Cloud Governance Api
# Contact: support@avepoint.com
#

function Get-FunctionsToExport {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true)]
        [ValidateNotNullOrEmpty()]
        [Alias('FullName')]
        $Path
    )

    Process {
        $Token = $null
        $ParserErr = $null

        $Ast = [System.Management.Automation.Language.Parser]::ParseFile(
            $Path,
            [ref]$Token,
            [ref]$ParserErr
        )

        if ($ParserErr) {
            throw $ParserErr
        } else {
            foreach ($name in 'Begin', 'Process', 'End') {
	            foreach ($Statement in $Ast."${name}Block".Statements) {
		            if (
                        [String]::IsNullOrWhiteSpace($Statement.Name) -or
                        $Statement.Extent.ToString() -notmatch
                        ('function\W+{0}' -f $Statement.Name)
                    ) {
			            continue
		            }

		            $Statement.Name
	            }
            }
        }
    }
}

$ScriptDir = Split-Path $script:MyInvocation.MyCommand.Path
$FunctionPath = 'Api', 'Model', 'Client' | ForEach-Object {Join-Path "$ScriptDir\src\Cloud.Governance.Client\" $_}

$Manifest = @{
    Path = "$ScriptDir\src\Cloud.Governance.Client\Cloud.Governance.Client.psd1"

    Author = 'AvePoint,Inc'
    CompanyName = 'AvePoint,Inc'
    Description = 'A PowerShell client for AvePoint Cloud Governance public REST endpoints providing the functionalities of Cloud Governance.'

    ModuleVersion = '5.1.1'

    RootModule = 'Cloud.Governance.Client.psm1'
    Guid = 'B2610EE7-A791-4A00-8B5C-E0D47E25325B' # Has to be static, otherwise each new build will be considered different module

    PowerShellVersion = '5.0'
    
    IconUri = 'https://res.cdn.avepointonlineservices.com/onlineproductlogo/myhub.png'

    LicenseUri = 'https://licenses.nuget.org/MIT'

    Tags = @('AvePoint','CloudGovernance', 'API', 'MyHub', 'Ave')

    ProjectUri = 'https://github.com/AvePoint/cloud-governance-client'

    FunctionsToExport = $FunctionPath | Get-ChildItem -Filter *.ps1 | Get-FunctionsToExport


    VariablesToExport = @()
    AliasesToExport = @()
    CmdletsToExport = @()

}

New-ModuleManifest @Manifest
