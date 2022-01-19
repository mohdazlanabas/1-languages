#include <iostream>

using namespace std;

int main()
{

    // Guessing Game
    int index = 1;
    while (index <= 5)
    {
        cout << index << endl;
        index++;
    }

    int secretNum = 7;
    int guess;

    while (secretNum != guess)
    {
        cout << "Enter guess: ";
        cin >> guess;
    }

    cout << "You Win!" << endl;

    // Advance Guessing Game

    int secretNum2 = 7;
    int guess2;
    int guessCount2 = 0;
    int guessLimit2 = 3;
    bool outOfGuess2 = false;
    while (secretNum2 != guess2 && !outOfGuess2)
    {
        if (guessCount2 < guessLimit2)
        {
            cout << "Enter guess: ";
            cin >> guess2;
            guessCount2++;
        }
        else
        {
            outOfGuess2 = true;
        }
    }

    if (outOfGuess2)
    {
        cout << "you Lose!";
    }
    else
    {
        cout << "You Win!";
    }

    return 0;
}