# Это репозиторий для обучения pull request

## Первые шаги

1. Создаём копию (Fork) репозитория проекта
Заходим на страницу выбранного Вами проекта и нажимаем кнопку «Fork». Данная команда создаст Вашу собственную копию репозитория данного проекта.

Далее вам необходимо склонировать вашу копию репозитория.
```sh
git clone https://github.com/<YOURE_GITHUB>/version_control.git
```
2. Выполняем команду клонирования из своей fork-копии
```sh
git clone git@github.com:*YOURE_GITHUB*/version_control.git
```
3. Начиная работать над вашим исправлением, изначально надо создать соответствующую Git ветку, основанную на актуальном коде из базового репозитория.
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


