
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

    current_node = node
    while(current_node.pointer != None):
        print(current_node.value, '=> ', end='')
        current_node=current_node.pointer
    print(current_node.value)
    

if __name__ == "__main__":
    main()
