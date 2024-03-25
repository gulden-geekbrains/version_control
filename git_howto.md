# Подсказка по Git

Создание репозитория:
```sh
git init
```
```sh
git add
```
Зафиксировать изменения
```sh
git commit -m"Message text"
```
``` sh
git log
```
```sh
git log --oneline
```
Переключение между ветками <Имя_ветки>
``` sh
git checkout
```
Отображение всех веток
```sh
git branch
```

Создание новой ветки
```sh
git branch <имя_ветки>
```
Удаление определенной ветки
git branch -d <branch_name>

Команда позволяющая обьяденить ветки
```sh
git merge <branch_name>
```
Команда которая позволяет вывести список всех "commit" с графиков branch
```sh
git log --oneline --graph
```
Команда которая очищает терминал
```sh
clear
```