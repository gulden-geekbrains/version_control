# Подсказка по Git
## Инициализация
```sh
git init
```
## Добавление файла
```sh
git add
```
## Проверка статуса
```sh
git status
```
## Фиксация и добавление комментария по внесенным изменениям
```sh
git commit -m "Message text"
```
## Выведение истории изменения версий
* поочередно:
```sh
 git log
 ```
* одной строчкой
```sh
git log --oneline
```
* одной строчкой cо структурой изменений
```sh
git log --oneline --graph
```
* выход из режима изменения версий
```sh
q
```

## Переход к конкретной версии и сравнение версий
```sh
git checkout <branch_name>
```
## Отображение всех веток
```sh
git branch
```
## Создание новой ветки
```sh
git branch <branch_name>
```
## Удаление ветки
```sh
git branch -d <branch_name>
```
## Слияние веток
```sh
git merge <branch_name>
```
