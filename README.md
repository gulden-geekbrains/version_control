# Это репозиторий для обучения pull request

## Первые шаги

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория <https://git@github.com:gulden-geekbrains/version_control.git>
2. Выполняем команду клонирования из своей fork-копии
```sh
git clone https://git@github.com:*YOURE_GITHUB*/version_control.git
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

# Важно знать

При работе с удалёнными репозиториями, не стоит выполнять команду pull request при малейшем изменении, ведь это может испортить проект над которым работаете не только вы. Внимательно проверяйте что вы хотите изменить!

## Начало работы

Если опыта не так много, стоит немного чаще использовать команду:
```sh
git commit
```
Прежде, не забывайте добавлять файл в ветку после изменений заново
```sh
git add <filename>
```

## Что дальше

**Файл отредактирован, изменения внесены**

Для начала стоит убедиться что всё по прежнему работает, для этого конечно вы должны будете проверить файл на наличие ошибок, будь то код или презентация.

После, можно опубликовать изменения
```sh
git push --set-upstream origin updatereadme
```
После чего на странице репозитория вы можете сделать pull request