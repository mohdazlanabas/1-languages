#include <iostream>

using namespace std;

int main()
{
    int age = 19;
    double gpa = 2.7;
    string name = "Mike";
    cout << "Age: " << &age << endl;
    cout << "Gpa: " << &gpa << endl;
    cout << "Name: " << &name << endl;

    int age2 = 19;
    int *pAge2 = &age2;
    double gpa2 = 2.7;
    double *pGpa2 = &gpa2;
    string name2 = "Mike";
    string *pName2 = &name2;
    cout << pAge2;

    return 0;
}