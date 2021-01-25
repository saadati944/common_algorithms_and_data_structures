# Search algorithm

[read more in wikipedia](https://en.wikipedia.org/wiki/Search_algorithm)

In computer science, a search algorithm is any algorithm which solves the search problem, namely, to retrieve information stored within some data structure, or calculated in the search space of a problem domain, either with discrete or continuous values. Specific applications of search algorithms include:

- Problems in combinatorial optimization, such as:
    - The vehicle routing problem, a form of shortest path problem
    - The knapsack problem: Given a set of items, each with a weight and a value, determine the number of each item to include in a collection so that the total weight is less than or equal to a given limit and the total value is as large as possible.
    - The nurse scheduling problem
- Problems in constraint satisfaction, such as:
    - The map coloring problem
    - Filling in a sudoku or crossword puzzle
- In game theory and especially combinatorial game theory, choosing the best move to make next (such as with the minmax algorithm)
- Finding a combination or password from the whole set of possibilities
- Factoring an integer (an important problem in cryptography)
- Optimizing an industrial process, such as a chemical reaction, by changing the parameters of the process (like temperature, pressure, and pH)
- Retrieving a record from a database
- Finding the maximum or minimum value in a list or array
- Checking to see if a given value is present in a set of values

The classic search problems described above and web search are both problems in information retrieval, but are generally studied as separate subfields and are solved and evaluated differently. Web search problems are generally focused on filtering and finding documents that are most relevant to human queries. Classic search algorithms are typically evaluated on how fast they can find a solution, and whether that solution is guaranteed to be optimal. Though information retrieval algorithms must be fast, the quality of ranking is more important, as is whether good results have been left out and bad results included.

The appropriate search algorithm often depends on the data structure being searched, and may also include prior knowledge about the data. Some database structures are specially constructed to make search algorithms faster or more efficient, such as a search tree, hash map, or a database index. 

Search algorithms can be classified based on their mechanism of searching. Linear search algorithms check every record for the one associated with a target key in a linear fashion. Binary, or half interval searches, repeatedly target the center of the search structure and divide the search space in half. Comparison search algorithms improve on linear searching by successively eliminating records based on comparisons of the keys until the target record is found, and can be applied on data structures with a defined order. Digital search algorithms work based on the properties of digits in data structures that use numerical keys. Finally, hashing directly maps keys to records based on a hash function. Searches outside a linear search require that the data be sorted in some way.

Algorithms are often evaluated by their computational complexity, or maximum theoretical run time. Binary search functions, for example, have a maximum complexity of O(log n), or logarithmic time. This means that the maximum number of operations needed to find the search target is a logarithmic function of the size of the search space.