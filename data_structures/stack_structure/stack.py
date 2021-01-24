
class Stack():
    '''
    stack data structure in python
    '''
    def __init__(self):
        '''
        create elements array
        '''
        self.elements=[]
    
    def Push(self, item):
        '''
        add an item to the elements
        '''
        self.elements.append(item)
    
    def Pop(self):
        '''
        get the last item of the elements
        '''
        return self.elements.pop(len(self.elements)-1)

def main():
    '''
    test the stack class
    '''
    import random

    s = Stack()
    
    test_items=[]
    for i in range(random.randint(10, 100)):
        test_items.append(random.randint(10, 100))
        s.Push(test_items[i])
    
    for i in range(len(test_items)-1, -1, -1):
        if test_items[i] != s.Pop():
            print("Wront answer !!!")
            return

    print("ok")
if __name__ == "__main__":
    main()