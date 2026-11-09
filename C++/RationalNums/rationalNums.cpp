#include "rationalNums.h"
#include <iostream>
#include <numeric>


void Rational::normalize() {
    if (denumerator == 0) {
        throw std::invalid_argument("Знаменатель не может быть равен нулю.");
    }

    if (denumerator < 0) {
        numerator = -numerator;
        denumerator = -denumerator;
    }

    int g = std::gcd(std::abs(numerator), denumerator);
    numerator /= g;
    denumerator /= g;
}

Rational::Rational() : numerator(0), denumerator(1) {}

Rational::Rational(int numerator) : numerator(numerator), denumerator(1) {}

Rational::Rational(int numerator, int denumerator) : numerator(numerator), denumerator(denumerator) {
    normalize();
}

Rational Rational::operator+(const Rational& other) const {
    return Rational(numerator * other.denumerator + other.numerator * denumerator, denumerator * other.denumerator);
}

Rational Rational::operator-(const Rational& other) const {
    return Rational(numerator * other.denumerator - other.numerator * denumerator, denumerator * other.denumerator);
}

Rational Rational::operator*(const Rational& other) const {
    return Rational(numerator * other.numerator, denumerator * other.denumerator);
}

Rational Rational::operator/(const Rational& other) const {
    return Rational(numerator * other.denumerator, denumerator * other.denumerator);
}

Rational Rational::operator-() const {
    return Rational(-numerator, denumerator);
}

std::ostream& operator<<(std::ostream& os, const Rational& r) {
    os << r.numerator << "/" << r.denumerator;
    return os;
}

std::istream& operator>>(std::istream& is, Rational& r) {
    int n, d;
    char slash;
    if (is >> n >> slash >> d) {
        if (slash == '/') {
            r.numerator = n;
            r.denumerator = d;
            r.normalize();
        } else {
            is.setstate(std::ios::failbit);
        }
    }
    return is;
}