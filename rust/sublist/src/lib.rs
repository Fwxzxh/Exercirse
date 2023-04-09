#[derive(Debug, PartialEq, Eq)]
pub enum Comparison {
    Equal,
    Sublist,
    Superlist,
    Unequal,
}


pub fn sublist<T: PartialEq>(_first_list: &[T], _second_list: &[T]) -> Comparison {
    match (_first_list, _second_list) {
        ([], _) => Comparison::Sublist,
        (_, []) => Comparison::Superlist,
        ([], []) => Comparison::Equal,
        (a, b) if a == b  => Comparison::Equal,
        (a, b) => Check(a, b),
    }
    // let len_first = _first_list.len();
    // let len_second = _second_list.len();
    // if len_first == len_second {
    //     for i in 0..=len_first {
    //         if _first_list[i] != _second_list[i] {
    //             return Comparison::Unequal;
    //         }
    //     }
    //     return Comparison::Equal;
    // } else {
    //     for i in 0..=len_first {

    //     }
    //     unimplemented!()
    // }


}