# Инструкция по работе с Git
Создание репозитория
```sh
git init
```
Проиндексировать файл
```sh
git add <name>
```
Зафиксировать файл
```sh
git commit <name> -m <message>
```
Вывести журнал всех коммитов
```sh
git log
```
Вывести журнал всех коммитов в одну строку
```sh
git log --oneline
```
Вывести журнал всех коммитов в виде графика
```sh
git log --graph
```
Переход к состоянию выбранного коммита или ветки
```sh
git checkout <name>
```
Показать отличия файла от последнего коммита
```sh
git diff
```
Показать список всех веток
```sh
git branch
```
Создать новую ветку
```sh
git branch <name>
```
Удалить ветку
```sh
git branch -d <name>
```
Слияние веток
```sh
git merge <branch_name>
```
Скопировать репозиторий с Github
```sh
git clone <link>
```
Загрузить репозиторий на Github
```sh
git push
```
Выгрузить репозиторий с Github
```sh
git pull
```
Выгрузить репозиторий с Github со сливанием
```sh
git pull --rebase
```