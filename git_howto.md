# Подсказка по GIT

Создание репозитория:
```cmd
git init
```
Добавляем файл в коммит:
```sh
git add <filename>
```
Добавить все файлы в коммит:
```sh
git add -A
```
Создаем коммит с сообщением:
```sh
git commit -m "Message"
```
Список коммитов:
```sh
git log
```
Вывод коммитов "компактно":
```sh
git log --oneline
```
Вывод коммитов "компактно и ветками":
```sh
git log --oneline --graph
```
Переход по коммитам/веткам:
```sh
git checkout <branch_or_commit_name>
```
Просмотр статуса git
```sh
git status
```
Создание новой ветки
```sh
git branch <new_branch_name>
```
Просмотр разницы между коммитами
```sh
git diff
```
Слияние веток
```sh
git merge <branch_name>
```
[Ссылка на картинку](image.png)

![Картинка для полноты инструкции](/image.jpeg)

Pull на сервер
```sh
git pull
```
Push на сервер
```sh
git push
```
Clone репозитория
```sh
gt clone <url_github>
```
