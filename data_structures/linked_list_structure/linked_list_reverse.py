
class linkedList:
    '''
    linked list data structure in python
    '''
    def __init__(self, value=0, pointer=None):
        '''
        initilize value and pointer
        '''
        self.value=value
        self.pointer=pointer

    def reverse(self, to = None):
        '''
        reverse the linked list and return new head
        '''
        deepest_node = None
        if self.pointer != None:
            deepest_node = self.pointer.reverse(self)
            self.pointer = to
        else :
            self.pointer = to
            return self

        return deepest_node
    
    def __str__(self):
        if self.pointer==None:
            return str(self.value)
        return f"{self.value} => {str(self.pointer)}"

def main():
    '''
    test the linkedList class
    '''
    import random

    node = linkedList(0)

    last=node
    for i in range(random.randint(10, 25)):
        newNode=linkedList(random.randint(1, 100))
        last.pointer=newNode
        last=newNode

    print('linked list: ', node)

    # reversing the linked list
    node = node.reverse()

    print('reversed   : ', node)


    

if __name__ == "__main__":
    main()
