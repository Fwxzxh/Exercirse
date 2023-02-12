"""Functions used in preparing Guido's gorgeous lasagna.

Learn about Guido, the creator of the Python language: https://en.wikipedia.org/wiki/Guido_van_Rossum
"""

EXPECTED_BAKE_TIME= 40

PREPARATION_TIME = 2



def bake_time_remaining(elapsed_bake_time: int):
    """Calculate the bake time remaining.

    :param elapsed_bake_time: int - baking time already elapsed.
    :return: int - remaining bake time (in minutes) derived from 'EXPECTED_BAKE_TIME'.

    Function that takes the actual minutes the lasagna has been in the oven as
    an argument and returns how many minutes the lasagna still needs to bake
    based on the `EXPECTED_BAKE_TIME`.
    """
    return EXPECTED_BAKE_TIME - elapsed_bake_time


def preparation_time_in_minutes(layers: int):
    """
    Return the preparation time in minutes based of PREPARATION_TIME
    """
    return PREPARATION_TIME * layers



def elapsed_time_in_minutes(number_of_layers: int, elapsed_bake_time: int):
    """
    Return elapsed cooking time.

    This function takes two numbers representing the number of layers.
    """
    return number_of_layers * PREPARATION_TIME + elapsed_bake_time