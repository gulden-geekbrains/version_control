# Это репозиторий для обучения pull request

## Первые шаги

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория <https://git@github.com:gulden-geekbrains/version_control.git>
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
5. Переходим на свою страницу репозитория. Выбираем ветку **updatereadme** и жмем кнопку **Compare & pull request**

## Заметки

Что бы сделать push от другого пользователя необходимо выполнить команду
```sh
GIT_SSH_COMMAND='ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes' git push git@github.com:gulden-geekbrains/version_control.git
```

вместо *user-private-key* подставьте свой ключ

Можно прописать настройки для подсоединения по ssh
```sh
git config remote.origin.url git@github.com:gitusername/reponame
git config core.sshCommand "ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes"
```
# Как подружить git с github под Windows 10

Вот видео инструкция https://youtu.be/E8cIjbJMEpE


# Инструкция по работе с GIT и удаленными репозиториями

## Что такое GIТ? 
GIT - это одна из реализпций распространенных систем контроля версий, имеющая как локальный, так и удаленные репозитории. Является самой популярной реализацией систем контроля версий в мире.
## Подготовка репозитория 
Для создания репозитория необходимо выполнить команду *git init* в папке с репозиторием и у вас создасться репозиторий (появится папка скрытая .git)

## Создание коммитов 

### Git add
Для добавления изменений в коммит используется команда *git add*. Чтобы использовать команду *git add* напишите *git add <имя файла>*

### Просмотр состояния репозитория 
Для того, чтобы посмотреть состояние репозитория используйте команду *git status*. Для этого необходимо в папке с репозиторием написать *git status*, и вы увидите были ли изменения в файлах, или их не было.

### Создание коммитов 
Для того чтобы создать коммит (сохранение) необходимо выполнить команду *git commit*.

# Разные визуальные команды 
```sh 
cd c;\folder_name
```

Команда отображения директории Windows
```sh 
dir
```
Первая команда в GIT
```sh 
git init
```
Вторая команда в GIT
```sh 
git status
```
Третья команда в GIT
```sh 
git add <readme.md>
```
Четвертая команда в GIT
```sh 
git commit -m "Создали репозиторий в GIT"
```
Далее еще раз прописываю команду 
```sh
git status
```
Далее прописываю 
```sh
dir readme.md
```
Так же набираю команды 
```sh
git add readme.md и git status
```
Нужно теперь зафиксировать ввожу команду 
``` sh
git commit -m "комментрарий обязательно"
```
набираю команду 
```sh
git status
```

Закомичу
```sh
git commit
```
Скачать  GIT ссылку для *Windows*
[Скачать файл](http://example.com/path/to/your/file.txt)

Изменение в ветке new_line
Изменение в ветке new_line2
Изменение в ветке new_line3
Изменение в ветке new_line4
