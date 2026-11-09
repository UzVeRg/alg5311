#pragma once
#include <string>

class Student {
    private:
        std::string firstName;
        std::string lastName;
        short gradeMath;
        short gradeC;

        bool checkGradeMath(short gradeMath) const;
        bool checkGradeC(short gradeC) const;

    public:
        Student(const std::string& firstName, const std::string& lastName, short gradeMath, short gradeC);
        Student();
        // Сеттеры
        void setFirstName(const std::string& firstName);
        void setLastName(const std::string& lastName);
        void setGradeMath(short gradeMath);
        void setGradeC(short gradeC);
    
        // Геттеры
        std::string getFirstName() const;
        std::string getLastName() const;
        short getGradeMath() const;
        short getGradeC() const;
    
        bool isFailed() const;
    
        void printInfo() const;
};