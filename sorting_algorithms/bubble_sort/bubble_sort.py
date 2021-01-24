

def bubble_sort(array):
    '''
    bubble sort algorithm in python language
    this function will sort the array in ascending order
    '''
    for i in range(0, len(array)-1):
        for j in range(len(array)-1, i, -1):
            if array[i] > array[j]:
                array[i], array[j] = array[j], array[i]


def main():
    '''
    read an unsorted array from standard input and sort it

    # input format

    first line  : number of elements in array
    next lines : array elements

    # example

    5
    4
    7
    2
    9
    3

    # outout format

    sorted elemnts seperated with one space character

    # example

    2 3 4 7 9
    '''
    count = int(input())
    array = []

    for i in range(count):
        array.append(int(input()))

    bubble_sort(array)

    for i in array:
        print(i, end=' ')


if __name__ == "__main__":
    main()
