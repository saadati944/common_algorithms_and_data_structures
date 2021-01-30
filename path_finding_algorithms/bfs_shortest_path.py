
class Queue():
    '''
    queue data structure in python
    '''

    def __init__(self):
        '''
        create elements array
        '''
        self.elements = []

    def enqueue(self, item):
        '''
        add an item to the elements
        '''
        self.elements.append(item)

    def dequeue(self):
        '''
        get the first item of the elements
        '''
        return self.elements.pop(0)


class Edge:
    '''
    the edge class represents an edge from one vertex to another
    '''

    def __init__(self, From, To, directional=True):
        self.From = From
        self.To = To
        self.directional = directional

    def __eq__(self, other):
        if self.directional:
            return self.From == other.From and self.To == other.To
        return (self.From == other.From and self.To == other.To) or (self.From == other.To and self.To == other.From)

    def __str__(self):
        return f"{self.From} {'<=>' if self.directional else '=>'} {self.To}"


class Graph:
    '''
    this is the graph data structure in python
    '''

    def __init__(self, vertices=[], edges=[]):
        self.vertices = vertices
        self.edges = edges

    def add_vertex(self, v):
        if v not in self.vertices:
            self.vertices.append(v)

    def add_edge(self, e):
        if e not in self.edges:
            self.edges.append(e)

    def get_edges(self, v):
        return [e for e in self.edges if (e.directional and e.From == v) or (not e.directional and (e.From == v or e.To == v))]

    def __str__(self):
        return f"Vertices : {', '.join([str(x) for x in self.vertices])}\nEdges : {', '.join([str(x) for x in self.edges])}"

# The above classes are required to implement bfs


def bfs(g: Graph, find, v):
    '''
    the breadth first search algorithm implemented in python
    '''
    visited = []
    queue = Queue()
    queue.enqueue(v)

    parents = {}

    while queue.elements:
        q = queue.dequeue()
        visited.append(q)
        if q == find:
            return get_path(q, parents)
        for child in g.get_edges(q):
            if child.To in visited:
                continue
            if child.To not in parents:
                parents[child.To] = q
            queue.enqueue(child.To)


def get_path(v, parents):
    if v not in parents:
        return str(v)
    return f"{get_path(parents[v], parents)} => {str(v)}"


def main():
    r"""
    test bfs function
    give
          0 
         / \ 
        /   \ 
       1     2
      /|\    |\ 
     / | \   | \ 
    3  4  5--6  7
       |     |
       8     9

    to the bfs function and it would find shortest path from 0 to 9
    """
    import random

    g = Graph()
    g.vertices += [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
    g.edges += [Edge(0, 1), Edge(0, 2), Edge(1, 3), Edge(1, 4),
                Edge(1, 5), Edge(4, 8), Edge(2, 6), Edge(2, 7),
                Edge(6, 9), Edge(5, 6)]

    print(bfs(g, 9, 0))


if __name__ == "__main__":
    main()
