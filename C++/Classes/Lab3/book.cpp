#include <iostream>
#include "book.h"


Book::Book() {};

Book::Book(
    const std::string& title, 
    const std::string& author, 
    int count
) {
    setTitle(title);
    setAuthor(author);
    setCount(count);
}

void Book::printInfo() const {
    std::cout << "Title: " << title<< std::endl;
    std::cout << "Author: " << author << std::endl;
    std::cout << "Count: " << count << std::endl;
    std::cout << "------------------------" << std::endl;
}

void Book::setTitle(const std::string& title) {
    this->title = title;
}
void Book::setAuthor(const std::string& author) {
    this->author = author;
}

void Book::setCount(int count) {
    if (count < 0) {
        this->count = 0;
        std::cout << "Не может быть отрицательным. Установлено 0." << std::endl;
    } else {
        this->count = count;
    }
}


std::string Book::getTitle() const {
    return title;
}
std::string Book::getAuthor() const {
    return author;
}

int Book::getCount() const {
    return count;
}
