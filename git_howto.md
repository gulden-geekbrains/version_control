# Подсказка по GIT

### Создания репозитория:
```sh
git init
```
### Команда добавления изменения:
```sh
git add
```
### Зафиксировать изменения:
```sh
git commit -m "Message_text"
```
### Команды для просмотра истории коммитов:
```sh
git log
git log --oneline
```
* Дополнительная команда просмотр веток
```sh
git log --onelene --graph
```
### Команда для переключения между отдельными ветками репозитория:
```sh
git checkout (hash)
```
### Команда для вычисления разницы между любыми двумя деревьями:
```sh
git diff
git diff (branch_txt)
```
* Web ссылки на сайт 

[Полезная ссылка 1]( https://habr.com/ru/articles/541258/ "Всплывающая подсказка"), [полезная ссылка 2](https://habr.com/ru/articles/542616/)

### Создание новой ветки
```sh
git branch <имя ветки>
```
### Команда удаления ветки
```sh
git branch -d <имя ветки>
```
### Команда для объеденения двух веток
```sh
git merge <branch_txt>
```

### Команда для выхода из git log
```sh
Q
```
### Подключения удаленного репозитория
```sh
git clone <URL>
```
* Команда выполняет отправку недавних коммитов с локального пк на сервер с удаленным репозиторием
```sh
git push
```
* Команда для запроса с удаленным сервером
```sh
git pull
```
1. Создаем новую ветку и вносим необходимые изменения в файл (Pull reguest)
```sh
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```
2. Делаем push
```sh
git push --set-upstream origin updatereadme
```

