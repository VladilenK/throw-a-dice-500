function Get-BFMaxSumStrategy {
    param ($cards)
    $myStrategy = @{Value = $null; Sum = $null; RestCards = @() }
    if ($cards.Count -lt 1 ) { 
        # Write-Error "Cards count less than 1"
        # return
    }
    if ($cards.Count -eq 1 ) { 
        $myStrategy.Value = $cards | Select-Object -First 1
        $myStrategy.Sum = $myStrategy.Value
        $myStrategy.RestCards = @()
    }
    if ($cards.Count -eq 2 ) { 
        $myChoice = $cards | Measure-Object -Maximum | Select-Object -ExpandProperty Maximum
        $myStrategy.Value = $myChoice
        $myStrategy.Sum = $myStrategy.Value
        $restCards = @() + $($cards | Where-Object { $_ -ne $myChoice })
        $myStrategy.RestCards = $restCards
    }
    if ($cards.Count -gt 2 ) { 
        # Option 1: left card 
        $myOpt1, $restCards1 = $cards
        $otherPlayerBestStrat1 = Get-BFMaxSumStrategy($restCards1) 
        $myRestStrat1 = Get-BFMaxSumStrategy($otherPlayerBestStrat1.RestCards) 
        # right card 
        $myOpt2 = $cards[-1]
        $restCards2 = $cards[0..($cards.Length - 2)]
        $otherPlayerBestStrat2 = Get-BFMaxSumStrategy($restCards2) 
        $myRestStrat2 = Get-BFMaxSumStrategy($otherPlayerBestStrat2.RestCards) 
        if ( ($myRestStrat1.Sum + $myOpt1) -gt ($myRestStrat2.Sum + $myOpt2)) {
            $myStrategy.Value = $myOpt1
            $myStrategy.Sum = $myRestStrat1.Sum + $myOpt1
            $myStrategy.RestCards = $restCards1
        }
        else {
            $myStrategy.Value = $myOpt2
            $myStrategy.Sum = $myRestStrat2.Sum + $myOpt2
            $myStrategy.RestCards = $restCards2
        }
    }
    return $myStrategy
}
