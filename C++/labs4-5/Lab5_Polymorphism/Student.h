#ifndef STUDENT_H
#define STUDENT_H

#include <string>

class Student {
private:
    std::string firstName;
    std::string lastName;
    int grade1;
    int grade2;

public:
    Student(const std::string& firstName, const std::string& lastName,
            int grade1, int grade2);

    virtual bool isFail() const;
    virtual void print() const;
    virtual ~Student() = default;
};

#endif
