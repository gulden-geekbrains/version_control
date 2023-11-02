# Шпаргалка к git

## Создание репозитория
```sh
git init
```
## Работа с файлом

Создание файла <>.md / сохранение изменений в файле <>.md
```sh
git add <file_name>
```
Подтверждение изменений / присвоение трэк-номера версии файла
```sh
git commit -m "text"
```
Вызов статуса репозитория
```sh
git status
```
Вызов списка версий
* обычный вариант
```sh
git log
```
* однострочный вариант
```sh
git log --oneline
```
* вариант с ветками
```sh
git log --graph
```
Выйти из END
```sh
press q
```
Переключение между версиями

* по номеру версии
```sh
git checkout <version_number>
```
* на последнюю версию
```sh
git checkout master
git checkout <current branch name>
```
Восстановление последнего сохранения
```sh
git restore <file_name>
```
Удаление файла/папки
```sh
git rm <file_name>
```

## Контроль версий

Выявление различий между версиями

* последнее сохранение vs текущее состояние
```sh
git diff
```
* различия между конкретными версиями
```sh
git diff <version1> <version2>
```

## Работа с ветками

Посмотреть текущую ветку
```sh
git branch
```
Создать новую ветку
```sh
git branch <new_branch_name>
```
Переключиться между ветками
```sh
git checkout <branch_name>
```
Объединить ветки
```sh
git merge <branch_name_to_add_to_main>
```
Удалить отработанную ветку
```sh
git branch -d <branch_name>
```

## Добавление картинки

Добавить картинку в текстовый файл

```sh
Introduction text
![if_false](picture_file_name.extention)
```
My picture
![](maldivi_.jpg)
