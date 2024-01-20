 # Подсказка по GIT
 
 Создание репозитория:
 ```sh
 git init
 ```
 Сохранения файла:
 ```sh
 git add
 ```
 Добавления комментария к сохраненному файлу:
 ```sh
 git commit -m "Message text"
 ```
 Расширенный просмотр коммитов:
 ```sh
 git log
 ```
 Проверить состояние файлов:
 ```sh
 git status
 ```
 Краткий просмотр коммитов:
 ```sh
 git log --oneline
 ```
 Переключаться между ветками:
 ```sh
 git checkout <имя_ветки>
 ```
 Выход к текущей версии файла:
 ```sh
 git checkout master
 ```
 Слить ветки в одну:
 ```sh
 git merge (имя файла)
 ```
 Отображение всех веток :
 ```sh
 git branch
 ```
 Создание новой ветки:
 ```sh
 git branch <имя_ветки>
 ```
 Удаление ветки:
 ```sh
 git branch -d <name>
 ```
 Просмотр изменения веток:
 ```sh
 git log --oneline --graph
 ```
 Имя пользователя в GIT:
 ```sh
 git config --global user.name "name"
 ```
 Отмена изменений в HEAD:
 ```sh
 git reset
```
Создание клона репозитория:
```sh
git clone
```
Добавить в удаленный репозиторий:
```sh
git push
```
Удаление ветки в GIT:
```sh
git push origin --delete <название-ветки>
```
