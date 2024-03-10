# Подсказка по гиту

## Инициализация репозитория

```sh
git init
```

## Статус репозитория

```sh
git status
```

```
Индексация  файл
```sh
git add
```
Фиксация файл
```sh
git commit -m "Massage"
```
Просмотр фиксированных файлов и веток
```sh
git log --oneline --graph
``` 
Открытия фиксированных файлов и веток
```sh
git checkout <branch_name>
```
Просмотр разницы фиксированных файлов
```sh
git diff
```
Удаление неиндексированных файлов
```sh
git restore 
```
Отображение всех веток
```sh
git branch
```
Создание новой ветки
```sh
git branch <branch_name>
```
Слияние веток
```sh
git merge <branch_name>
```
Удаление веток
```sh
git branch -d <branch_name>
```
Команда для колонизации репозиторий
```sh
git clone <repository address>
```
Скачивание и автоматически merge с нашей версией
```sh
git pull
```
Отправление нашей версий репозиторий на внешний репозиторий
```sh
git push
```
