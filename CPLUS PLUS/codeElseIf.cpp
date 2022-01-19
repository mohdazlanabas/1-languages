#include <iostream>
#include <cmath>
// Block Out

using namespace std;
/* RETURN STAEMENT*/
void sayHi() { cout << "Hello User"; }
void sayHi3(string name3, int age3) { cout << "Hello " << name3 << " you are " << age3 << endl; }
/* FUNCTION STAEMENT*/
double cube(double num4)
{
    double result4 = num4 * num4 * num4;
    return result4;
}

int main()
{
    cout << " " << endl;
    cout << "Hello World!" << endl;
    cout << pow(3, 3) << endl;
    cout << sqrt(36) << endl;
    cout << round(4.3) << endl;
    cout << ceil(4.6) << endl;
    cout << fmax(10, 100) << endl;
    cout << fmin(100, 10) << endl;
    cout << " " << endl;

    cout << "CHARACTERS" << endl;
    string characterName = "Tom";
    int characterAge;
    characterAge = 50;
    cout << "There once was a man named " << characterName << endl;
    cout << "He was " << characterAge << " years old" << endl;
    characterName = "Mike";
    cout << "He liked the name " << characterName << endl;
    cout << "but did not like being " << characterAge << endl;
    cout << " " << endl;

    cout << "DATA TYPES" << endl;
    char grade = 'A';
    int age = 50;
    double gpa = 2.3;
    bool isMale2 = false;
    cout << " " << endl;

    cout << "STRINGS" << endl;
    string phrase = "Azlan Academy";
    phrase[0] = 'B';
    cout << phrase << endl;
    phrase[0] = 'A';
    cout << phrase << endl;
    cout << phrase.find("Azlan", 0) << endl;
    string phrasesub;
    phrasesub = phrase.substr(0, 3);
    cout << phrasesub;
    cout << " " << endl;

    cout << "MATH" << endl;
    int wnum = 5;
    double dnum = 5.5;
    wnum++;
    cout << wnum << endl;
    cout << (4 + 5 * 10) << endl;
    float anum = wnum / 2;
    cout << anum << endl;
    cout << " " << endl;

    /*cout << "INPUTS" << endl;
    string name2;
    cout << "Enter your name: ";
    getline(cin, name2);
    cout << "Hello " << name2 << endl;
    int age2;
    cout << "Enter your age:";
    cin >> age2;
    cout << "You are " << age2 << " years old." << endl;

    int num1, num2;
    cout << "enter first numer: ";
    cin >> num1;
    cout << "enter second numer: ";
    cin >> num2;
    cout << "Total are: " << num1 + num2 << endl;
    cout << " " << endl; */

    /*cout << "MAD LIBS" << endl;
    string color, pluralNoun, celebrity;
    cout << "Enter a color: ";
    getline(cin, color);
    cout << "Enter a plural noun: ";
    getline(cin, pluralNoun);
    cout << "Enter a Celebrity: ";
    getline(cin, celebrity);

    cout << "Roses are " << color << endl;
    cout << pluralNoun << " are blue" << endl;
    cout << "I Love " << celebrity << endl;*/

    cout << "ARRAYS" << endl;
    int luckyNums[] = {4, 8, 15, 16, 23};
    luckyNums[0] = 19;
    cout << luckyNums[0] << endl;
    cout << " " << endl;

    cout << "FUNCTIONS" << endl;
    cout << "Top ";
    sayHi();
    cout << " Bottom" << endl;

    sayHi3("Mike", 60);
    sayHi3("Tom", 40);
    sayHi3("Steve", 20);
    cout << " " << endl;

    cout << "RETURN STATEMENT" << endl;
    double answer4 = cube(5.0);
    cout << answer4 << endl;
    cout << " " << endl;

    cout << "IF STATEMENT" << endl;
    bool isMale = true;
    bool isTall = true;
    if (isMale && isTall)
    {
        cout << "You are a tall male" << endl;
    }
    else if (isMale && !isTall)
    {
        cout << "You are a Short Male" << endl;
    }
    else if (!isMale && isTall)
    {
        cout << "You are tall but a Female" << endl;
    }
    else
    {
        cout << "You are a short Female" << endl;
    }
    cout << " " << endl;

    return 0;
}