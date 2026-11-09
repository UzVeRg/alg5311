#include <iostream>
#include "rationalNums.h"

int main() {

    Rational r1;
    Rational r2(5);
    Rational r3(4, -8);

    std::cout << "r1 = " << r1 << "\n";
    std::cout << "r2 = " << r2 << "\n";
    std::cout << "r3 (4/-8) = " << r3 << "\n\n";

    Rational a(1, 2);
    Rational b(1, 3);

    std::cout << a << " + " << b << " = " << (a + b) << "\n";
    std::cout << a << " - " << b << " = " << (a - b) << "\n";
    std::cout << a << " * " << b << " = " << (a * b) << "\n";
    std::cout << a << " / " << b << " = " << (a / b) << "\n";
    std::cout << "Унарный минус для " << a << " равен " << (-a) << "\n\n";

    Rational user_rational;
    std::cout << "Введите дробь в формате числитель/знаменатель (например, 1/-3 или -3/-4): ";
    if (std::cin >> user_rational) {
        std::cout << "Нормализованное число: " << user_rational << "\n";
    } else {
        std::cout << "Ошибка ввода!\n";
    }

    return 0;
}