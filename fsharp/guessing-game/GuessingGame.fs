module GuessingGame

let reply (guess: int): string = 
    match guess with
        | 42 -> "Correct"
        | 41 | 43 -> "So close"
        | a when a < 41 -> "Too low"
        | a when a > 43 -> "Too high"
        | _ -> ""
