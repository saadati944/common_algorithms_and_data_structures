import random

arr = []
for i in range(random.randint(100, 300)):
    arr.append(random.randint(0, 500))

print(len(arr))
for i in arr:
    print(i)
