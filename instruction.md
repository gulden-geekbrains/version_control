# Инструкция по языку MarkDown

## Стилизация текста

Обычный текст набирается как есть.

Новая строкм - набираем через пробел.

**Полужирный**

*Курсив*

## Цитирование в языке MarkDown
> Первый уровень циторования
>> Второй уровень цитирования

## Списки
### Ненумерованный список
* Лист 1
* Лист 2

### Нумерованный список
1. Лист 1
2. Лист 2

## WEB ссылки
Текст [пример ссылки](http.example.com "Всплывающая подсказка")

## Работа с таблицами

Буква | Цифра | Символ
------ | ------|----------
a      | 4     | $
x      | 365    | (
b      |       | ^  

Буква|Цифра|Символ
---|---|---
a|4|$
 |365|(
b| |^  

Column | Column
------ | ------
\| Cell \|| \| Cell \|  


Column | Column | Column
:----- | :----: | -----:
Left   | Center | Right
align  | align  | align

## Как добавлять картинки в Markdown

### Это яблоко

![apple](apple.jpg)

### Это апельсин

![orange](orange.png)

## Работа с удаленным репозиторием

### Копирование репозитория 
1. Или выполняем команду клонирования из понравившегося ))) репозитория
```sh
git clone git@github.com:*YOURE_GITHUB*/version_control.git
```
2. Иди делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория <https://git@github.com:gulden-geekbrains/version_control.git>

Выполняем команду клонирования из своей fork-копии
```sh
git clone git@github.com:*YOURE_GITHUB*/version_control.git
```
### Создаем новую ветку и вносим необходимые изменения в файл
```sh
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```
### Делаем push  
```sh
git push --set-upstream origin updatereadme
```
### Переходим на свою страницу репозитория. Выбираем ветку **updatereadme** и жмем кнопку **Compare & pull request**