$setsLimit = 1000 
$stopPoint = 500

$501s = 0
$502s = 0
$503s = 0
$504s = 0
$505s = 0
$506s = 0
for ($i = 0; $i -lt $setsLimit; $i++) {
    $pointsSum = 0
    while ($pointsSum -le $stoppoint) {
        $pointsSum += $(1..6 | Get-Random )
    }
    if ($pointsSum -eq 501) { $501s += 1 }
    if ($pointsSum -eq 502) { $502s += 1 }
    if ($pointsSum -eq 503) { $503s += 1 }
    if ($pointsSum -eq 504) { $504s += 1 }
    if ($pointsSum -eq 505) { $505s += 1 }
    if ($pointsSum -eq 506) { $506s += 1 }
}
Write-Host "501s:" $501s
Write-Host "502s:" $502s
Write-Host "503s:" $503s
Write-Host "504s:" $504s
Write-Host "505s:" $505s
Write-Host "506s:" $506s
