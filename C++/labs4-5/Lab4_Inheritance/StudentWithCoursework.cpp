#include "StudentWithCoursework.h"

#include <iostream>
#include <stdexcept>

StudentWithCoursework::StudentWithCoursework(
    const std::string& firstName, const std::string& lastName,
    int grade1, int grade2, const std::string& courseworkTitle,
    int courseworkGrade)
    : Student(firstName, lastName, grade1, grade2),
      courseworkTitle(courseworkTitle), courseworkGrade(courseworkGrade) {
    if (courseworkGrade < 2 || courseworkGrade > 5) {
        throw std::out_of_range("Coursework grade must be between 2 and 5");
    }
}

bool StudentWithCoursework::isFail() const {
    return Student::isFail() || courseworkGrade == 2;
}

void StudentWithCoursework::print() const {
    std::cout << "Student: " << firstName << ' ' << lastName << '\n'
              << "Grades: " << grade1 << ", " << grade2 << '\n'
              << "Coursework: " << courseworkTitle << '\n'
              << "Coursework grade: " << courseworkGrade << '\n'
              << "Has grade 2: " << (isFail() ? "yes" : "no") << '\n';
}
