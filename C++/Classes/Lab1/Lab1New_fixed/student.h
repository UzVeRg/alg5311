#ifndef STUDENT_H
#define STUDENT_H

#include <string>

class Student {
private:
    std::string firstName;
    std::string lastName;
    short gradeMath;
    short gradeC;

public:
    Student(); //для student2

    Student(
        const std::string& firstName,
        const std::string& lastName,
        short gradeMath,
        short gradeC
    );// для student1

    void setFirstName(const std::string& firstName);
    void setLastName(const std::string& lastName);
    void setGradeMath(short gradeMath);
    void setGradeC(short gradeC);

    std::string getFirstName() const;
    std::string getLastName() const;
    short getGradeMath() const;
    short getGradeC() const;

    bool isFailed() const;
    void printInfo() const;
};

#endif