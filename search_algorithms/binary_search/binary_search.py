
def binary_search(array, element, start=0, end=0):
    '''
    binary search algorithm in python
    '''
    mid = (end - start)//2 + start
    if array[mid] == element:
        return mid

    if start==end:
        return -1

    if array[mid] > element:
        return binary_search(array, element, start, mid-1)
    else:
        return binary_search(array, element, mid+1, end)
    return -1


def main():
    '''
    read a SORTED array from standard input and find expected element

    # input format

    first line  : number of elements in array
    second line : value to find
    next lines : array elements

    # example

    5
    2
    0
    1
    2
    3
    4


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

    print(binary_search(array, find, 0, len(array)-1))


if __name__ == "__main__":
    main()
