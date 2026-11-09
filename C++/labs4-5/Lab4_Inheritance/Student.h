#ifndef STUDENT_H
#define STUDENT_H

#include <string>

class Student {
protected:
    std::string firstName;
    std::string lastName;
    int grade1;
    int grade2;

public:
    Student(const std::string& firstName, const std::string& lastName,
            int grade1, int grade2);

    bool isFail() const;
    void print() const;
};

#endif
