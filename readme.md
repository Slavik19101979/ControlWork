
## Контрольная работа по первому блоку

***Задача*** :
  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

  ### ***Решение***

  1. Определяем колличество элементов  входящего массива,состоящие из не более чем трех символов.Таким образом мы определяем размер нового массива.
  2. Создаем новый массив ,размер которого задаем исходя из первого пункта 
  3. Поочередно перебираем элементы входящего массива и элементы ,соответствующие заданным условиям(<=3) записываем в исходящий массив.
  4. Выводим на консоль наш полученный массив.

В репозитории находятся файлы :
 * algoritm.drawio.png
 * readme.md
 * Program.cs

В блок-схеме находится только основная часть метода.