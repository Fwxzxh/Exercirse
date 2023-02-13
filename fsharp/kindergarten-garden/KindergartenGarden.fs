module KindergartenGarden

type Plant =
    | Grass
    | Violets
    | Clover
    | Radishes

let plants diagram student = 
    let kidIndex = 
        ['A'..'Z']
        |> Seq.findIndex (fun elm -> elm = (student: string)[0])

    let clasifyVocals vocal =
        match vocal with
            | 'G' -> Grass
            | 'V' -> Violets
            | 'C' -> Clover
            | 'R' -> Radishes
            | _  -> failwith "Whoops!"

    (diagram : string).Split('\n')
    |> List.ofArray
    |> List.map (fun x -> x.Substring(kidIndex * 2, 2))
    |> List.collect (fun x -> [for xx in x -> xx ])
    |> List.map clasifyVocals