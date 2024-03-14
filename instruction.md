# Инструкция по языку MarkDown

Новая строка - это олна пустая строка

## formating text
to make the text italic you have to put it between two asterisks (*) or two underlines (_). *Example* or _Example_

## Цитирование
> Первый уровень
>> Второй уровень

## lists

to make a list without numbers you can add (*) or (+) and a blank space before an element of the list
* example1
* example2
* example3
+ example4

to make a list with numbers you can add numbers starting from 1, a (.), and a blank space before an element of the list
1. example1
2. example2
3. example3

## WEB ссылки
Текст [пример ссылки](http.example.com "Всплывающая подсказка")

## tables
To add a table, use three or more hyphens (---) between pipes (|) to create each column’s header, and use pipes to separate each column. For compatibility, you should also add a pipe on either end of the row.
|Header|Description|
|------|-----------|
|elem1 |descrip1   |
|elem2 |descrip2   |

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

## Картинки

### Это яблоко

![apple](apple.jpg)

### Это апельсин

![orange](orange.png)

## Working with remotes

### Showing Your Remotes
To see which remote servers you have configured, you can run the:
```sh
 git remote
```
 command. It lists the shortnames of each remote handle you’ve specified. If you’ve cloned your repository, you should at least see origin
 ### Adding Remote Repositories
 To add a new remote Git repository as a shortname you can reference easily, run:
 ```sh
 git remote add [shortname] [url]
```

### Pushing to Your Remotes
When you have your project at a point that you want to share, you have to push it upstream. The command for this is simple:
```sh
 git push [remote-name] [branch-name]
```
### Pulling from Your Remotes
you can use the:
```sh
git pull
```
command to automatically fetch and then merge a remote branch into your current branch.

*Running git pull generally fetches data from the server you originally cloned from and automatically tries to merge it into the code you’re currently working on.*