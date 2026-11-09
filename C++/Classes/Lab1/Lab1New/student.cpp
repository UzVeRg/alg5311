#include "student.h"
#include <iostream>





// Сеттеры
void Student::setFirstName(const std::string& firstName) {
    this->firstName = firstName;
}

void Student::setLastName(const std::string& lastName) {
    this->lastName = lastName;
}

void Student::setGradeMath(short gradeMath) {
    if (gradeMath < 2 || gradeMath > 5) {
        this->gradeMath = 2;
        std::cout << "Введена неверная оценка по математике, оценка изменена на 2 для студента " << firstName << " " << lastName << std::endl;
    } else {
        this->gradeMath = gradeMath;
    }
}

void Student::setGradeC(short gradeC) {
    if (gradeC < 2 || gradeC > 5) {
        this->gradeC = 2;
        std::cout << "Введена неверная оценка по С, оценка изменена на 2 для студента " << firstName << " " << lastName << std::endl;
    } else {
        this->gradeC = gradeC;
    }
}

// Геттеры
std::string Student::getFirstName() const {
    return firstName;
}

std::string Student::getLastName() const {
    return lastName;
}

short Student::getGradeMath() const {
    return gradeMath;
}

short Student::getGradeC() const {
    return gradeC;
}

bool Student::isFailed() const {
    return (gradeMath < 3 || gradeC < 3);
}

// Вывод информации
void Student::printInfo() const {
    std::cout << "Студент: " << firstName << " " << lastName << std::endl;
    std::cout << "Оценка по математике: " << gradeMath << std::endl;
    std::cout << "Оценка по С: " << gradeC << std::endl;
    std::cout << "Статус: " << (isFailed() ? "двоечник" : "не двоечник") << std::endl;
    std::cout << "------------------------" << std::endl;
}