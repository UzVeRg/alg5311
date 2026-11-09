#include <iostream>
#include <string>

void checkGrade(short gradeMath, short gradeC);

void checkGrade(short gradeMath, short gradeC){
    if (gradeMath < 2 || gradeMath > 5)
        gradeMath = 2;
        std::cout << "Введена не верная оценка по математике, оценка изменена на 2" << std::endl;
    if (gradeC < 2 || gradeC > 5)
        gradeC = 2;
        std::cout << "Введена не верная оценка по С, оценка изменена на 2" << std::endl;
    std::cout << "Оценка по математике: " << gradeMath << std::endl;
    std::cout << "Оценка по С: " << gradeC << std::endl;
}

bool isFailed(short gradeMath, short gradeC){
    // Проверка, двоечник ли студент
    return gradeMath < 3 || gradeC < 3;

}
