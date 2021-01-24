arr = input().split(' ')

while '' in arr:
    arr.pop(arr.index(''))

for i in range(len(arr)-1):
    if int(arr[i])>int(arr[i+1]):
        print("error")
        break
print("ok")
