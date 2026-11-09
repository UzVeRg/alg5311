#ifndef STUDENT_WITH_COURSEWORK_H
#define STUDENT_WITH_COURSEWORK_H

#include "Student.h"

#include <string>

class StudentWithCoursework : public Student {
private:
    std::string courseworkTitle;
    int courseworkGrade;

public:
    StudentWithCoursework(const std::string& firstName,
                          const std::string& lastName,
                          int grade1, int grade2,
                          const std::string& courseworkTitle,
                          int courseworkGrade);

    bool isFail() const;
    void print() const;
};

#endif
