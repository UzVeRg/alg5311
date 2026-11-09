#pragma once
#include <iostream>
#include <string>
using namespace std;
class Student{
    private:
        string firstName;
        string lastName;
        short gradeMath;
        short gradeC;

    public:
        void setFirstName(string firstName);
        void setLastName(string lastName);
        void setGradeMath(short gradeMath);
        void setGradeC(short gradeC);

        string getFirstName();
        string getLastName();
        short getGradeMath();
        short getGradeC();
};
