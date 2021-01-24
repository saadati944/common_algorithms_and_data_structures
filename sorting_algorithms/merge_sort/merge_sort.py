

def merge_sort(array):
    '''
    merge sort algorithm in python language
    this function will sort the array in ascending order
    '''

    if len(array)==1:
        return

    left_side = array[:len(array)//2]
    right_side = array[len(array)//2:]

    merge_sort(left_side)
    merge_sort(right_side)

    j = 0
    k = 0
    for i in range(len(array)):
        if j >= len(left_side):
            array[i] = right_side[k]
            k+=1
            continue
        if k >= len(right_side):
            array[i] = left_side[j]
            j+=1
            continue
        if left_side[j] <= right_side[k]:
            array[i] = left_side[j]
            j+=1
        else:
            array[i] = right_side[k]
            k+=1
        

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

    merge_sort(array)

    for i in array:
        print(i, end=' ')


if __name__ == "__main__":
    main()
