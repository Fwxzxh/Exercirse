class Matrix:
    """Given a string representing a matrix of numbers, return the rows and columns of
    that matrix."""

    def __init__(self, matrix_string):
        self.matrix_string = matrix_string

    def row(self, index):
        srow = self.matrix_string.split("\n")
        srow = srow[index-1].split(" ")
        for i in range(0,len(srow)):
            srow[i] = int(srow[i])
        return srow

    def column(self, index):
        mat = []
        for i in self.matrix_string.split("\n"):
            mat.append(int(i.split(" ")[index-1]))
        return mat
