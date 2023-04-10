module CarsAssemble

let successRate (speed: int): float =
    match speed with
        | 0 -> 0.0
        | a when a >= 1 && a <= 4 -> 1.0
        | a when a >= 5 && a <= 8 -> 0.9
        | 9 -> 0.8
        | 10 | _ -> 0.77

// lowest speed 221 increases linearly
let productionRatePerHour (speed: int): float =
    let success = successRate speed
    let cars = 221 * speed
    float(cars) * success

let workingItemsPerMinute (speed: int): int =
    let cars = productionRatePerHour speed
    int(cars / 60.0)
