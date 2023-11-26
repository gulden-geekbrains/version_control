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

вместо _user-private-key_ подставьте свой ключ

Можно прописать настройки для подсоединения по ssh

```sh
git config remote.origin.url git@github.com:gitusername/reponame
git config core.sshCommand "ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes"
```

# Как подружить git с github под Windows 10

Вот видео инструкция https://youtu.be/E8cIjbJMEpE

# Работа с удалёнными репозиториями

Для того, чтобы просмотреть список настроенных удалённых репозиториев, вы можете запустить команду git remote. Она выведет названия доступных удалённых репозиториев. Если вы клонировали репозиторий, то увидите как минимум origin — имя по умолчанию, которое Git даёт серверу, с которого производилось клонирование:

```sh
git clone https://github.com/schacon/ticgit
```

Для того, чтобы добавить удалённый репозиторий и присвоить ему имя (shortname), просто выполните команду

```sh
git remote add <shortname> <url>
```

для получения данных из удалённых проектов, следует выполнить:

```sh
$ git fetch [remote-name]q
```

Данная команда связывается с указанным удалённым проектом и забирает все те данные проекта, которых у вас ещё нет. После того как вы выполнили команду, у вас должны появиться ссылки на все ветки из этого удалённого проекта, которые вы можете просмотреть или слить в любой момент.

Команда

```sh
git pull
```

работает как комбинация команд git fetch и git merge, т. е. Git вначале забирает изменения из указанного удалённого репозитория, а затем пытается слить их с текущей веткой.
