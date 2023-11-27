module Allergies

open System

type Allergen =
    | Eggs
    | Peanuts
    | Shellfish
    | Strawberries
    | Tomatoes
    | Chocolate
    | Pollen
    | Cats

let getScore allergen =
    match allergen with
        | Eggs -> 1
        | Peanuts -> 2
        | Shellfish -> 4
        | Strawberries -> 8
        | Tomatoes -> 16
        | Chocolate -> 32
        | Pollen -> 64
        | Cats -> 128

let allergicTo codedAllergies allergen = 
    let score = getScore allergen
    if codedAllergies >= score then
        true
    else
        false


let list codedAllergies = 
    failwith "You need to implement this function."