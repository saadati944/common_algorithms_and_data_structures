
class Queue():
    '''
    queue data structure in python
    '''
    def __init__(self):
        '''
        create elements array
        '''
        self.elements=[]
    
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

def main():
    '''
    test the queue class
    '''
    import random

    q = Queue()
    
    test_items=[]
    for i in range(random.randint(10, 100)):
        test_items.append(random.randint(10, 100))
        q.enqueue(test_items[i])
    
    for i in range(len(test_items)):
        if test_items[i] != q.dequeue():
            print("Wront answer !!!")
            return

    print("ok")
if __name__ == "__main__":
    main()