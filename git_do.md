# Подсказка по Git

Создание репозитория:
```sh
git init
```
Добавить к индексации:
```sh
git add
```
Зафиксировать изменения:
```sh
git commit -m "Messege text"
```
 Для просмотра истории коммитов:
```sh
git log
```
 Для просмотра истории коммитов:
```sh
git log
```
Для просмотра сокращённой истории коммитов:
```sh
git log --oneline
```
Перемещение по веткам:
```sh
git checkout <branch_name>
```
Отображениие всех веток:
```sh
git branch
``` 
Удаление ветки:
```sh
git branch -d <name_branch>
```
Cоздание ветки и переход к ней за одну команду:
```sh
git branch -b <name_branch>
```
Поменять надпись последнего коммита:
```sh
git commit --amend -m "New commit message."
```
Список децствий на случай ошибки:
>HEAD detached from 87dc87b

```sh
git branch temp
git checkout temp
git branch -f master temp
git checkout master
git branch -d temp
```
1. создаем временную ветку с именем temp, причем в новой ветке будет правильно установлено положение HEAD
2. переключаемся на временную ветку temp
3. в ветке master устанавливается та же позиция HEAD, что и в ветке temp
4. переключиться на ветку master
5. удалить временную ветку

## Работа с удаленным репозиторием 
 
Связать удалённый и локальный репозитории: 
```sh
git remote add origin <link>
``` 
 "выталкнуть" изменения: 
```sh
git push
``` 
 "выкачать" изменения с сервера: 
```sh
git pull 
```
Для конфликтов: 
```sh
git push --rebase
``` 