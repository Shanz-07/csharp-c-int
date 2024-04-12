#include <stdio.h>

int main() {
    int choice;
    float num1, num2, result;

    printf("Enter num1: ");
    scanf_s("%f", &num1);
    printf("Enter num2: ");
    scanf_s("%f", &num2);

    printf("Enter your choice from 1-4: ");
    scanf_s("%d", &choice);

    switch (choice) {
        case 1:
            result = num1 + num2;
            printf("The addition of %.1f and %.1f is: %.1f\n", num1, num2, result);
            break;
        case 2:
            result = num1 - num2;
            printf("The subtraction of %.1f and %.1f is: %.1f\n", num1, num2, result);
            break;
        case 3:
            result = num1 * num2;
            printf("The multiplication of %.1f and %.1f is: %.1f\n", num1, num2, result);
            break;
        case 4:
            if (num2 != 0) {
                result = num1 / num2;
                printf("The division of %.1f and %.1f is: %.1f\n", num1, num2, result);
            } else {
                printf("Error! Division by zero is not allowed.\n");
            }
            break;
        default:
            printf("Invalid choice!\n");
            break;
    }

    return 0;
}
