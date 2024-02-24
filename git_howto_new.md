# Подсказка по git

## Команды командной строки Git
Создание репозитория
```sh
git init
```
Добавлние файла в репозиторий
```sh
git add
```
Добавление в Git сообщения об измении в файле
```sh
git commit -m "Message text"
```
Выведение в консоль списка изменений в файле
```sh
git log
```
Выведение списка изменений в одну строку (без имени и даты, того кто произвел изменение)
```sh
git log --oneline
```
Выведение списка изменений с отображением веток
```sh
git log --graph
```
Перемещение по веткам
```sh
git checkout ffff или <имя файла>
```
Отображение всех веток
```sh
git branch
```
Создание новой ветки
```sh
git branch <имя>
```
Удаление ветки
```sh
git branch -d <name>
```
Удаление файла из репозитория
```sh
git rm <namefile>
```
Объединение веток
```sh
git merge <name>
```
Выталкивание локального репозитория на сервер Git
```sh
git push
```

## Информация о работе с удаленными репозиториями
1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория
2. Выполняем команду клонирования из своей fork-копии
```sh
git clone git@github.com:*YOURE_GITHUB*/version_control.git
```
3. Создаем новую ветку и вносим необходимые изменения в файл
```sh
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```
4. Делаем push  
```sh
git push --set-upstream origin updatereadme
```
5. Переходим на свою страницу репозитория. Выбираем ветку **updatereadme** и жмем кнопку **Contribute** в появившемся меню нажимаем **Compare & pull request**