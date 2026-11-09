#include "student.h"
#include <iostream>


Student::Student(){}

Student::Student(
    const std::string& firstName,
    const std::string& lastName,
    short gradeMath,
    short gradeC
) {
    setFirstName(firstName);
    setLastName(lastName);
    setGradeMath(gradeMath);
    setGradeC(gradeC);
}


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
        std::cout << "Предупреждение: неверная оценка по математике у студента "
                  << firstName << " " << lastName
                  << ". Оценка заменена на 2." << std::endl;
    } else {
        this->gradeMath = gradeMath;
    }
}

void Student::setGradeC(short gradeC) {
    if (gradeC < 2 || gradeC > 5) {
        this->gradeC = 2;
        std::cout << "Предупреждение: неверная оценка по C у студента "
                  << firstName << " " << lastName
                  << ". Оценка заменена на 2." << std::endl;
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
    return gradeMath == 2 || gradeC == 2;
}

void Student::printInfo() const {
    std::cout << "Студент: " << firstName << " " << lastName << std::endl;
    std::cout << "Оценка по математике: " << gradeMath << std::endl;
    std::cout << "Оценка по C: " << gradeC << std::endl;
    std::cout << "Двоечник: " << (isFailed() ? "да" : "нет") << std::endl;
    std::cout << "------------------------" << std::endl;
}
