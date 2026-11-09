#include "Student.h"

#include <iostream>
#include <stdexcept>

Student::Student(const std::string& firstName, const std::string& lastName,
                 int grade1, int grade2)
    : firstName(firstName), lastName(lastName),
      grade1(grade1), grade2(grade2) {
    if (grade1 < 2 || grade1 > 5 || grade2 < 2 || grade2 > 5) {
        throw std::out_of_range("Grades must be between 2 and 5");
    }
}

bool Student::isFail() const {
    return grade1 == 2 || grade2 == 2;
}

void Student::print() const {
    std::cout << "Student: " << firstName << ' ' << lastName << '\n'
              << "Grades: " << grade1 << ", " << grade2 << '\n'
              << "Has grade 2: " << (isFail() ? "yes" : "no") << '\n';
}
