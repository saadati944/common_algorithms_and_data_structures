

def linear_search(array, element):
    '''
    linear search algorithm in python
    '''
    for i in range(len(array)):
        if array[i] == element:
            return i
    return -1


def main():
    '''
    read an array from standard input and find expected element

    # input format

    first line  : number of elements in array
    second line : value to find
    next lines : array elements

    # example

    5
    2
    4
    7
    2
    9
    3

    # outout format

    index of the element

    # example

    2
    '''
    count = int(input())
    array = []
    find = int(input())

    for i in range(count):
        array.append(int(input()))

    print(linear_search(array, find))


if __name__ == "__main__":
    main()
