module Bob

open System

let response (input: string): string = 

    // Function to strip all non letter characters.
    let onlyLetters stringToFilter = 
        stringToFilter 
        |> String.filter (fun x -> Char.IsLetter x)

    // Function to check if all characters are uppercase.
    let checkMayus stringToCheck =
        let letters =  onlyLetters stringToCheck
        match letters with
            | "" -> false
            | a when 
                a |> String.forall (fun x -> Char.IsUpper x) -> true
            | _ -> false

    let stripedInput = 
        input.Trim()

    match stripedInput with
        | "" -> "Fine. Be that way!"
        | a 
            when a.EndsWith '?' && 
                checkMayus a -> "Calm down, I know what I'm doing!"
        | a when a.EndsWith '?' -> "Sure."
        | a when 
            checkMayus a -> "Whoa, chill out!"
        | _ -> "Whatever."
