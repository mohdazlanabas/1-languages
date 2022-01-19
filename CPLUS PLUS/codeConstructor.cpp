#include <iostream>
using namespace std;

class Book
{
public:
    string title;
    string author;
    int pages;

    Book()
    {
        title = "no tiitle";
        author = "no authorr";
        pages = 0;
    }

    Book(string aTitle, string aAuthor, int aPages)
    {
        title = aTitle,
        author = aAuthor;
        pages = aPages;
    }
};

int main()
{
    Book book1("Harry Porter", "JK Rowlings", 500);
    Book book2("Lord Of The Rings", "Tolkien", 700);
    Book book3;
    cout << book2.title << endl;
    return 0;
}