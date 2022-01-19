import math
print("Hollla")
course = 'Python Programming'
print(len(course))
print(course[0])
print(course[-1])
print(course[0:3])
print(course[:3])
print(course[0:])
print(course[:])
print(id(course))
print(id(course[0]))
message = 'Python \' Programming'
print(message)
# For Note Ing
message2 = """Python
Programming
"""
print(message2)
first = "Azlan"
last = 'Abas'
fullName = first + ' ' + last
print(fullName)
full = f'{first} {last}'
print(full)

courses = '  Python Programming  '
print(course.upper())
print(course.lower())
print(course.title())

print(course.strip())
print(course.find("pro"))
print(course.replace('P', '-'))

print('Programming' in course)
print('Programming' not in course)

x = 10
x = 0b10
print(x)
print(bin(x))
x = 0x12c
print(hex(x))

x = 1 + 2j
print(x)

PI = 3.14
print(round(PI))
print(abs(PI))
print(math.floor(PI))
print(math.ceil(PI))

# z = input('z: ')
# print(int(z))
# print(float(z))
# print(bool(z))

# Falsyies '' 0 [] None (null)

age = 18
if age >= 18:
    print('Adut')
elif age >= 13:
    print('Teenager')
else:
    print('Child')
print('All Done')

name = ' '
if not name.strip():
    print('Name Is Empty')

ages = 22
if 18 <= ages < 65:
    print('Eligible')

# 18 <= age < 65

umur = 4
if umur >= 18:
    message = 'Eligible'
else:
    message = 'Not Eligible'
# message = ='Eligible' if age  >= 18 else 'Not Eligible'
print(message)

for x in 'Python':
    print(x)

for x in ['a', 'b', 'c']:
    print(x)

for x in range(0, 10, 2):
    print(x)

print(range(5))
print([1, 2, 3, 4, 5])

print(type(range(5)))
print([1, 2, 3, 4, 5])

##

names = ['AJohn', 'Mary']
found = False
for name in names:
    if name.startswith('J'):
        print('Found')
        found = True
        break
    if not found:
        print('Not Found')
        break

##

names = ['John', 'Mary']
for name in names:
    if name.startswith('J'):
        print('Found')
        break
else:
    print('Not Found')

# guess = 0
# answer = 5
# while answer != guess:
# guess = int(input('Guess: '))


def increment(number: int, by: int) -> int:
    return(number, number + by)


print(increment(2, by=3))


def multiply(*list):
    print(list)


multiply(2, 3, 4, 5)

##


def multiply(*list):
    total = 1
    for number in list:
        total *= number
    return total


print(multiply(2, 3, 4, 5))

##


def save_user(**user):
    print(user['name'])


save_user(id=1, name='admin')

##

message = 'a'


def greet():
    message = 'b'
    print(message)


greet()
print(message)

##


def multiply(*numbers):
    total = 1
    for number in numbers:
        total *= number
    return total


print('start')
print(multiply(1, 2, 3))
print('finish')
