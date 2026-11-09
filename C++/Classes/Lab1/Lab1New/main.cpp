#include "student.h"

int main() {

  Student student1("Иван", "Иванов", 20, 5);

  Student student2;
  student2.setFirstName("Пётр");
  student2.setLastName("Петров");
  student2.setGradeMath(20);
  student2.setGradeC(4);


  student1.printInfo();
  student2.printInfo();

  return 0;
}
