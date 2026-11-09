#include "Student.h"
#include "StudentWithCoursework.h"

#include <iostream>

int main() {
    Student student("Ivan", "Petrov", 4, 5);
    StudentWithCoursework courseworkStudent(
        "Anna", "Sidorova", 5, 4, "Algorithms", 2);

    student.print();
    std::cout << "\n";
    courseworkStudent.print();

    return 0;
}
