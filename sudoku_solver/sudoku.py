import os

# if you don't need to animate solving process, change ANIMATE variable to False
ANIMATE = True
LINUX = os.name != 'nt'



sudoku = [
    [5, 3, 0,   0, 7, 0,   0, 0, 0],
    [6, 0, 0,   1, 9, 5,   0, 0, 0],
    [0, 9, 8,   0, 0, 0,   0, 6, 0],

    [8, 0, 0,   0, 6, 0,   0, 0, 3],
    [4, 0, 0,   8, 0, 3,   0, 0, 1],
    [7, 0, 0,   0, 2, 0,   0, 0, 6],

    [0, 6, 0,   0, 0, 0,   2, 8, 0],
    [0, 0, 0,   4, 1, 9,   0, 0, 5],
    [0, 0, 0,   0, 8, 0,   0, 7, 9]
]
'''
sample sudoku puzzles :

sudoku = [
    [0, 1, 0,   4, 7, 0,   2, 0, 0],
    [0, 0, 0,   0, 0, 5,   0, 4, 0],
    [4, 0, 0,   2, 0, 8,   0, 0, 1],

    [3, 0, 4,   8, 0, 0,   0, 0, 0],
    [0, 7, 0,   0, 0, 0,   8, 0, 0],
    [1, 0, 2,   9, 0, 0,   0, 0, 0],

    [9, 0, 0,   6, 0, 1,   0, 0, 5],
    [0, 0, 0,   0, 0, 4,   0, 3, 0],
    [0, 2, 0,   7, 9, 0,   4, 0, 0]
]
sudoku = [
    [0, 0, 0,   0, 0, 0,   0, 0, 0],
    [0, 0, 0,   0, 0, 0,   0, 0, 0],
    [0, 0, 0,   0, 0, 0,   0, 0, 0],

    [0, 0, 0,   0, 0, 0,   0, 0, 0],
    [0, 0, 0,   0, 0, 0,   0, 0, 0],
    [0, 0, 0,   0, 0, 0,   0, 0, 0],

    [0, 0, 0,   0, 0, 0,   0, 0, 0],
    [0, 0, 0,   0, 0, 0,   0, 0, 0],
    [0, 0, 0,   0, 0, 0,   0, 0, 0]
]
'''


def is_valid(n, x, y):
    '''
    check if a number is valid for a block
    '''
    for i in range(9):
        if sudoku[x][i] == n:
            return False
    for i in range(9):
        if sudoku[i][y] == n:
            return False
    xbox = (x // 3) * 3
    ybox = (y // 3) * 3
    for i in range(xbox, xbox + 3):
        for j in range(ybox, ybox + 3):
            if sudoku[i][j] == n:
                return False
    return True


def draw():
    '''
    just draw the current state of the sudoku puzzle to standard output
    '''
    if LINUX:
        print("\033[0;0H",end='')
    else:
        _ = os.system("cls")
    for i in range(9):
        if i % 3 == 0 and i != 0:
            print('______|_______|______\n      |       |       ')
        for j in range(9):
            if j % 3 == 0 and j != 0:
                print('| ', end='')
            print(sudoku[i][j], end=' ')
        print()


def get_empty(xs=0, ys=0):
    '''
    get first empty block after given position
    '''
    if xs > 8 or ys > 8:
        return (-1, -1)
    for i in range(xs, 9):
        for j in range(ys, 9):
            if sudoku[i][j] == 0:
                return (i, j)
    return (-1, -1)


def solve(xs=0, ys=0):
    '''
    recursively check numbers fro 0 to 9 for each empty block
    '''
    x, y = get_empty(xs, ys)
    if x == -1:
        return True
    for i in range(1, 10):
        if is_valid(i, x, y):
            sudoku[x][y] = i
            if ANIMATE:
                draw()
            nx, ny = xs, ys
            if solve(nx, ny):
                return True
            else:
                sudoku[x][y] = 0
    return False


def main():
    '''
    solve wanted sudoku puzzle with backtracking
    technique and finally show it to the user.
    '''
    _ = os.system("clear" if LINUX else "cls")
    solve()
    if not ANIMATE:
        draw()


if __name__ == "__main__":
    main()
