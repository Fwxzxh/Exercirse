use enum_iterator::{Sequence, all};
use int_enum::IntEnum;

#[repr(u8)]
#[derive(Debug, PartialEq, Eq, IntEnum, Clone, Copy, Sequence)]
pub enum ResistorColor {
    Black = 0,
    Blue = 6,
    Brown = 1,
    Green = 5,
    Grey = 8,
    Orange = 3,
    Red = 2,
    Violet = 7,
    White = 9,
    Yellow = 4,
}

pub fn color_to_value(color: ResistorColor) -> u32 {
    color.int_value() as u32
}

pub fn value_to_color_string(value: u32) -> String {
    let color_res = ResistorColor::from_int(value as u8);
    match color_res {
        Ok(color) => format!("{:?}", color),
        Err(_) =>String::from("value out of range")
    }
}

pub fn colors() -> Vec<ResistorColor> {
    let mut colors = all::<ResistorColor>().collect::<Vec<_>>();
    colors.sort_by(|a, b| {
        a.int_value().cmp(&b.int_value())
    });
    colors
}