pub fn production_rate_per_hour(speed: u8) -> f64 {
    let prob = match speed {
        0 => 0.0,
        1..=4 => 1.0,
        5..=8 => 0.9,
        9..=u8::MAX => 0.77,
    };
    let total_cars = speed as f64 * 221.0;
    total_cars * prob
}

pub fn working_items_per_minute(speed: u8) -> u32 {
    production_rate_per_hour(speed) as u32 / 60
}