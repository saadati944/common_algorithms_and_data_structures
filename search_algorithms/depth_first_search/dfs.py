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

# The above classes are required to implement dfs

def dfs(g, find, v, visited = [], path=[]):
    '''
    the depth first search algorithm implemented in python
    '''
    if v in visited:
        return
    path.append(v)
    if v == find:
        return path
    visited.append(v)
    edges = g.get_edges(v)
    for e in edges:
        out = dfs(g, find, e.To, visited, path)
        if out != None:
            return out
    path.pop()
    return None


def main():
    """
    test dfs function
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

    to the dfs function and find a path from 0 to 9
    """
    import random

    g = Graph()
    g.vertices+=[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
    g.edges+=[Edge(0, 1), Edge(0, 2), Edge(1, 3), Edge(1, 4),
                    Edge(1, 5), Edge(4, 8), Edge(2, 6), Edge(2, 7),
                    Edge(6, 9), Edge(5, 6)]
    
    path = dfs(g, 9, 0)
    print(' => '.join([str(x) for x in path]))


if __name__=="__main__":
    main()