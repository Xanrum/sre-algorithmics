# Алгоритмические курсы

## Как делать задания

- клонировать репу
- создать свою ветку ветку
- решить задания
- сделать мерж реквест (не мержить)

## Решение задания

В каждом задание в заголовке в коментарии написано условие и пример входных данных Для решения надо дописать свой код,
обычно это функция Для запуска тестов можно использовать средства IDE или команду

`dotnet test`

## Разрешенные примитвы

К каждому заданию можно написать два решения.

- основное - решение использующие только базовые примитивы
- расширенное - решение использует расширенные возможности языка - ограничений нет

### Ограничения базового решения

Можно:

- примитивные типы string, int, long, byte, bool, double
- классы без свойств, только публичные поля. Без наследований, рекордов - обычных или позиционных, индексные свойства
- коллекции List, Dictionary
- циклы for, foreach, while

Нельзя:

- структуры
- массивы
- реализации свойств
- лямбды
- кортежи (любые, именнованные или нет)
- LINQ
- класс object
- dynamic