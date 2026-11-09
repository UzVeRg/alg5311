#include "student.h"
#include <string>


void Student::setFirstName(string firstName){
    this->firstName = firstName;
}
void Student::setLastName(string lastName){
    this->lastName = lastName;
}
void Student::setGradeMath(short gradeMath){
    this->gradeMath = gradeMath;
}
void Student::setGradeC(short gradeC){
    this->gradeC = gradeC;
}


string Student::getFirstName(){
    return firstName;
}
string Student::getLastName(){
    return lastName;
}
short Student::getGradeMath(){
    return gradeMath;
}
short Student::getGradeC(){
    return gradeC;
}