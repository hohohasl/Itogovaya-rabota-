# Итоговая проверочная работа.

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

---
## Выполнение задания

1. Задаем исходный массив строк, который необходимо подвергнуть анализу.(arrayStrings)
2. Созданием метод печати массива в консоль.
    + указываем тип метода (void)
    + указываем тип аргумента метода ()
    + выводим массив при помощи цикла for на консоль.
3. Создаем метод для подсчета элементов для нового массива.
    + указываем тип метода (int)
    + указываем тип аргумента метода ()
    + перебираем массив при помощи цикла for и подсчитываем элементы    содержащие менее 4 символов.
    + возвращаем коллчичество элементов соответствующих условию
4. Создаем метод для создания сортированного массива в соответсвии с условием (элементы массива содержат менее 4х символов)
    + указываем тип метода (string[])
    + указываем тип аргументов метода (string[], int arraylenght)
    + создаем новый массив длинной arraylenght
    + перебираем массив при помощи цикла for и записываем в новый массив элементы, которые соответсвуют условию (длинна элемента <4)
    + возвращаем новый массив.
5. Используя ранее созданный метод (пункт2) выводим на консоль новый массив.

## результаты работы программы

    ["hello", "2", "world", ":-)", "88", "-2"]
    Рeзультат сортировки
    ["2", ":-)", "88","-2"]