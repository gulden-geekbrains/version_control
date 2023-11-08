# подсказки по командной строке

Создание репозитории
```sh
git init
```

Добавить файл в отслеживаемый
```sh
git add <filename>
```

Сделать коммит
```sh
git commit -m "message"
```

команда смены дируктории
```sh
cd c:\folder_name
```

команда отображения текущей дируктории
```sh
pwd
```

листинг текущей директории

Windows:
```sh
dir
```
MacOs, Linux:
```sh
ls
```

Удаление файла

Windows:
```sh
del <filename>
```
MacOs, Linux:
```sh
rm <filename>
```

Разница между файлами, коммитами ...
```sh
diff 
```

Чтобы увидеть все коммиты ...
```sh
git log
```

Чтобы увидеть все коммиты во всех ветках...
```sh
git log --graph
```

Просмотр всех веток
```sh
git branch
```

добавить новую ветку <name>
```sh
git branch <name>
```

Чтобы слить ветки, нужно перейти на Главную ветку (Master) и набрать команду
```sh
git merge <branchName>
```
Переход с одной ветки на другую
```sh
git checkout <branchName>
```

Удаление ветки
```sh
git branch -d <branchName>
```

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория <https://git@github.com:gulden-geekbrains/version_control.git>
2. Выполняем команду клонирования из своей fork-копии
```sh
git clone git@github.com:*YOURE_GITHUB*/version_control.git
```
3. Создаем новую ветку и вносим необходимые изменения в файл
```sh
git checkout -b <new_branch>
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
