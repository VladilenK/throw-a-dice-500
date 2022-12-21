$setsLimit = 1000
$stopPoint = 100

$101s = 0
$102s = 0
$103s = 0
for ($i = 0; $i -lt $setsLimit; $i++) {
    $pointsSum = 0
    while ($pointsSum -le $stoppoint) {
        $pointsSum += $(Get-Random -Minimum 1 -Maximum 6)
    }
    if ($pointsSum -eq 101) { $101s += 1 }
    if ($pointsSum -eq 102) { $102s += 1 }
    if ($pointsSum -eq 103) { $103s += 1 }
}
Write-Host "101s:" $101s
Write-Host "102s:" $102s
Write-Host "103s:" $103s


