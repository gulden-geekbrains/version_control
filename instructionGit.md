# Help to GIT

## Инициализация GIT

1. Инициализация GIT /Делается один раз при тнициализации папки/ 
```sh
git init
```
## Команда проверки статуса файла

1. Проверка статуса файла /можно проверять состояние файла на любом этапе/
```sh
git status
```

## Команды для регистрации изменений и добавления комментария

1. Регистрация изменнений в файл
```sh
git add
```
2. Добавление комментария при изменении файла
```sh
git commit -m "Message"
```
## Команды просмотра логов событий с различными ключами

1. Посмотреть log изменения файла
```sh
git log
```
2. Посмотреть log, укороченная версия
```sh
git log --oneline
```
3. Показать дерево веток.
```sh
git log --oneline --graph
```

## Команды для работы с ветками файла

1. Создать новую ветку
```sh
git branch new_branch
```
2. Перейти в указанную ветку
```sh
git checkout new_branch
```
3. Показать все /текущую/ ветку
```sh
git branch
```
4. Слияние веток после редактирования //Необходимо перейти в ветку для которой будет происходить слияние. В команде указать ветку которая будет добавлена в текущую ветку.
```sh
git merge new_branch
```
5. Удаление ветки
```sh
git branch -d <name_branch>
```

## Команды по работе с файлом

1. Посмотреть /вернуть/ предыдущие значения файла
```sh
git checkout
```
2. Показать изменения в файле.
```sh
git diff
```

## Команды для pull request

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

## Создание своего репозитория

1. Переходим в свои репозитории через иконку профиля.

2. Нажимаем кнопку New, для создания собственного репозитория и даем ему название.

3. Переходим в VS code и открываем папку, которую необходимо добавить в GitHub/

4. Проверяем status, если все изменения сохранены, то выполняем команду по переименованию ветки в "main"
. Делаем push  
```sh
git branch -M main
```

5. Делаем push
```sh
git push --set-upstream origin main
```
* Иногда при выполнении этой команды возникает ошибка о том, что привязан другой репозиторий с неправильным url. Исправить url поможет команда
```sh
remote set-url origin <правильный url>
```