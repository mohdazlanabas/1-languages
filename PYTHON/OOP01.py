# DOG

class Dog:
    def bark(self):
        print('bark')


d = Dog()
d.bark()
print(type(d))

# STUDENT


class Student:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def present(self):
        print(f'{self.name} is PRESENT')

    def absent(self):
        print(f'{self.name} is ABSENT')

    def tardy(self):
        print(f'{self.name} is TARDY')


student1 = Student('Anna Lovelace', 16)
print(f'Student information (student1.name), (student1.age).')

student2 = Student('John Smith', 17)

student1.present()
student2.absent()

# Static Method


class Math:
    @staticmethod
    def add5(x):
        return x + 5

    @staticmethod
    def add10(y):
        return y + 10

    @staticmethod
    def pr():
        print('run')


Math.pr()

# classmethod


class Person:
    number_of_people = 0
    GRAVITY = -9.8

    def __init__(self, name):
        self.name = name
        Person.add_person()

    @classmethod
    def number_of_people_(cls):
        return cls.number_of_people

    @classmethod
    def add_person(cls):
        cls.number_of_people += 1


p1 = Person('tim')
print(Person.number_of_people)
p2 = Person('jill')
print(Person.number_of_people)

