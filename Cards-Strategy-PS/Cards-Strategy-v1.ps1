$numberOfCards = 8
$cards = @()
1..$numberOfCards | ForEach-Object { $cards = $cards + $(Get-Random -Minimum 1 -Maximum 100) }
# Get-BFMaxSumStrategy($cards) 
# $cards = 89, 99, 1, 2, 29, 7

Write-Host "Cards given: " $cards 
$restCards = $cards
$sumPlayer1 = 0
$sumPlayer2 = 0
for ($i = 0; $i -lt $cards.Count / 2; $i++) {
    # Write-Host $i
    $play1 = Get-BFMaxSumStrategy($restCards) 
    $sumPlayer1 += $play1.Value
    Write-Host "Player 1:  $($play1.Value) (Sum: $sumPlayer1) " -ForegroundColor Green
    $play2 = Get-BFMaxSumStrategy($play1.RestCards) 
    $sumPlayer2 += $play2.Value
    Write-Host " Player 2: $($play2.Value) (Sum: $sumPlayer2) " -ForegroundColor Blue
    $restCards = $play2.RestCards
}

