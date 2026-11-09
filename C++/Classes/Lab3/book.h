#ifndef BOOK_H
#define BOOK_H
#include <string>

class Book {
public:
    
    Book();
    Book(const std::string& title, const std::string& author, int count);
    

    void setTitle(const std::string& title);
    void setAuthor(const std::string& author);
    void setCount(int count);

    std::string getTitle() const;
    std::string getAuthor() const;
    int getCount() const;


    virtual void printInfo() const;
    
private:
    std::string title;
    std::string author;
    int count;
};


#endif