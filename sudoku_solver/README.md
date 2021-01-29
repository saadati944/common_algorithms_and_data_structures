# Sudoku solver

![sudoku1](https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Sudoku_Puzzle_by_L2G-20050714_standardized_layout.svg/260px-Sudoku_Puzzle_by_L2G-20050714_standardized_layout.svg.png)
![sudoku2](https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Sudoku_solved_by_bactracking.gif/260px-Sudoku_solved_by_bactracking.gif)

[read more in wikipedia](https://en.wikipedia.org/wiki/Sudoku_solving_algorithms)

A standard Sudoku contains 81 cells, in a 9×9 grid, and has 9 boxes, each box being the intersection of the first, middle, or last 3 rows, and the first, middle, or last 3 columns. Each cell may contain a number from one to nine, and each number can only occur once in each row, column, and box. A Sudoku starts with some cells containing numbers (clues), and the goal is to solve the remaining cells. Proper Sudokus have one solution. Players and investigators use a wide range of computer algorithms to solve Sudokus, study their properties, and make new puzzles, including Sudokus with interesting symmetries and other properties.

There are several computer algorithms that will solve most 9×9 puzzles (n=9) in fractions of a second, but combinatorial explosion occurs as n increases, creating limits to the properties of Sudokus that can be constructed, analyzed, and solved as n increases.