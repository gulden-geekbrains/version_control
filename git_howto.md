# Подсказка по гиту

Инициализация репозитория

```sh
git init
```

Статус репозитория

```sh
git status
```
Добавить в репозиторий
```sh
git add <filename>
```
Фиксация изменений 
```sh
git commit -m "message text"
```
Вывод списка коммитов
```sh
git log
```
Вывод только списка сообщений
```sh
git log --oneline
```
Переход от одного коммита к другому
```sh
git checkout <имя_ветки>
``` 
Удалить не сохраненные изменения
```sh
git restore
```
Показать разницу коммитов
```sh
git diff
```
Отабражение всех веток
```sh
git branch
```
Создание новой ветки
```sh
git branch <branch_name>
```
Удаление ветки
```sh 
git branch -d <branch_name>
```
Показать списка коммитов как график
```sh
git log --graph
```
Показать список комитов одной строкой как график
```sh
git log --oneline --graph
```
Показать текущее состаяние проекта
```sh
git status
Слить ветки 
```sh
git merge <branch_name>
```
Создаем новую ветку и вносим необходимые изменения в файл

```sh
git clone <ссылка на репозиторий в github>
```
Создаем новую ветку и вносим необходимые изменения в файл

```sh
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```
Делаем push

```sh
git push --st -upstream origin updatereadme
```