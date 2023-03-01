#include <stdio.h>

int find_max_even_index(int arr[], int n) {
    int max_index = -1;
    int max_value = -1;
    for (int i = 0; i < n; i++) {
        if (arr[i] % 2 == 0 && arr[i] > max_value) {
            max_value = arr[i];
            max_index = i;
        }
    }
    return max_index;
}

int main() {
    int arr[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int n = sizeof(arr) / sizeof(arr[0]);
    int max_even_index = find_max_even_index(arr, n);
    if (max_even_index != -1) {
        printf("Індекс найбільшого парного елемента дорівнює %d\n", max_even_index);
    } else {
        printf("У масиві немає парних елементів\n");
    }
    return 0;
}
