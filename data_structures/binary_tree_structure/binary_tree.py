
class binary_tree:
    '''
    a simple implementation of binary tree in python
    '''
    def __init__(self, value=0, left=None, right=None):
        self.value=value
        self.left=left
        self.right=right
    
def main():
    '''
    testing binary tree class
    todo : write a better test
    '''
    bt = random_asing(binary_tree())
    print(show(bt))
    
def random_asing(b):
    import random
    b.value=random.randint(1, 20)
    if random.choice((True, False)):
        b.right = random_asing(binary_tree())
    if random.choice((True, False)):
        b.left = random_asing(binary_tree())
    return b
def show(b):
    return f"{b.value}:[({show(b.left) if b.left != None else 'None'}), ({show(b.right) if b.right != None else 'None'})]"

if __name__=="__main__":
    main()