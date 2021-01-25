
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
        


def main():
    '''
    test graph class
    '''
    import random

    g = Graph()
    
    for i in range(random.randint(5, 20)):
        g.add_vertex(random.randint(0, 100))
    
    for i in range(random.randint(10, 20)):
        samples=random.sample(g.vertices, 2)
        g.add_edge(Edge(samples[0], samples[1], random.choice([True, False])))
    
    print(g)


if __name__ == "__main__":
    main()
