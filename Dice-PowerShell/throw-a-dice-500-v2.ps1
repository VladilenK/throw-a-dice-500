$setsLimit = 1000 
$stopPoint = 500

$setsResults = @()
for ($i = 0; $i -lt $setsLimit; $i++) {
    $pointsSum = 0
    while ($pointsSum -le $stoppoint) {
        $pointsSum += $(1..6 | Get-Random )
    }
    $setsResults += $pointsSum
}
Write-Host ":" $setsResults.Count

$setsResults | Group-Object | Select-Object Name, Count

