
#include "student.h"
#include "check.h"



int main() {
    Student student;
    student.setFirstName("Иван");
    student.setLastName("Иванов");
    student.setGradeMath(5);
    student.setGradeC(4);
    checkGrade(student.getGradeMath(), student.getGradeC());
    return 0;
}