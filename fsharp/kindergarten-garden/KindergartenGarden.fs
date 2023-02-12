module KindergartenGarden

type Plant =
    | Grass
    | Violets
    | Clover
    | Radishes

let studentList = 
    ["Alice"; "Bob"; "Charlie"; "David"; 
    "Eve"; "Fred"; "Ginny"; "Harriet"; 
    "Ileana"; "Josepth"; "Larry"]

let plants diagram student = 
    let kidIndex = 
        studentList 
        |> Seq.findIndex (fun elm -> elm = student)
        
    let diagramIndex = 
        match kidIndex with
            | 0 -> 0
            | _ -> (kidIndex * 2) - 2

    let diagramSplit =
        (diagram : string).Split('\n')

    let listOfVocals = 
        for line in diagramSplit do
            line[diagramIndex]

    let clasifyVocals vocal =
        match vocal with
            | 'G' -> Grass
            | 'V' -> Violets
            | 'C' -> Clover
            | 'R' -> Radishes
            | _  -> failwith "Whoops!"

    [for vocal in listOfVocals -> clasifyVocals vocal]