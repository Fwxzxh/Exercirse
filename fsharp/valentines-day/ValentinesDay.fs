module ValentinesDay

type Approval =
    | Yes
    | No
    | Maybe

type Cuisine =
    | Korean
    | Turkish

type Genre =
    | Horror
    | Romance
    | Thriller
    | Crime

type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity): Approval = 
    match activity with
        | BoardGame -> No
        | Chill -> No
        | Movie (genere) -> 
            match genere with
                | Romance -> Yes
                | Horror -> No
                | Thriller -> No
                | Crime -> No
        | Restaurant (cusine) ->
            match cusine with
                | Korean -> Yes
                | Turkish -> Maybe
        | Walk (km) -> 
            match km with
                | a when a < 3  -> Yes
                | a when a < 5 -> Maybe
                | _ -> No