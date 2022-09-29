# 001QuarterTestWork
## Первая четверть. Итоговая проверочная работа.
***
### ***Задача***: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
***

### ***Описание алгоритма решения:*** Пользователь с клавиатуры вводит длину первого массива. Программа осуществляет проверку ввода на корректность. Создается первый массив заданной длины. Программа запрашивает, а пользователь вводит с клавиатуры каждый элемент первого массива. При этом ввод пустого значения не допустим - программа просит повторить ввод. Для создания второго массива заводится подпрограмма подсчета длины нового массива, которая принимает в качестве параметра первый массив, подсчитывает количество элементов чей размер меньше, либо равен трем и выдает нужную длину. На следующем этапе программа создает второй массив и вызывает подпрограмму его заполнения. Подпрограмма возвращает заполненный массив равный длине второго массива, а в качестве параметра принимает первый массив. Внутри подпрограммы находится цикл, внутри которого проверяется является ли длина каждого элемента первого массива меньше, либо равной трем. Если условие выполняется, элементу второго массива присваивается элемент первого массива. Для отображения правильности работы программа выводит на печать первый массив, а затем печатает второй массив.
***
