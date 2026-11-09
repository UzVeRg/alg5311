#include "book.h"

int main() {
    Book book1("The Great Gatsby", "F. Scott Fitzgerald", 10);
    
    book1.printInfo();

    Book book2;
    book2.setTitle("Не придумайт");
    book2.setAuthor("НЕ Я");
    book2.setCount(-2);
    
    book2.printInfo();
}
