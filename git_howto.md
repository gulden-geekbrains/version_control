# Подсказка по GIT

Создание репозитория:
```sh
git init
```
Добавить файл в индекс:
```sh
git add
```
Cделать коммит:
```sh
git commit -m "Message"
```
Просмотреть историю коммитов:
```sh
git log
```
Сокращеный просмотр коммитов:
```sh
git log --oneline
```
Команда переключения между ветками:
```sh
git checkout <branche_name>
```
Cостояние рабочего каталога:
```sh
git status
```
Выводим список веток в репозитории
```sh
git branch
```
Удаляем ветку с именем new_branch_name
```sh
git branch -d branch_to_delete
```
Переходим на ветку branch_name
```sh
git checkout branch_name
```
Выводим список коммитов в виде красивого графа/дерева
```sh
git log --graph
```
Сливает ветку branch_name с текущей веткой
```sh
git merge branch_name
```
Создание новой ветки 
```sh
git branch <имя_ветки>
```
Отправить локальную ветку в удаленную ветку 
```sh
git push
```
Клонировать существующий репозиторий 
```sh
git clone https://github.com
```
Извлечение и загрузка содержимого из удаленого репозитория
```sh
git pull
```