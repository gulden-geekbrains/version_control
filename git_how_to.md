# Tips for git

Command direction change
```sh
cd ~/Desktop/folder_name/
``` 

Listing of current direction
```sh
dir
```

 File deletion
 ```sh
 del <filename>
 ```

Creation of a repositorium
```sh
git init
```

Add to indexing
```sh
git add
```

Save changes
```sh
git commit -m <Name>
```

Changes checking
```sh
git diff
```

Checking the log. Full version
```sh
git log
```

Log in a nutshell
```sh
git log --oneline
```

Visualizing log story
```sh
git log --graph/ git log --oneline --graph
```

Adding a picture
```sh
Message ![Name](accurate name with extension)
```

Adding a new branch
```sh
git branch <Name>
```

Branches switching
```sh
git checkout <name of a branch>
```

Branches merging
```sh
git merge <name of a branch>
```

All branches listing
```sh
git branch
```

Deletion of a branch
```sh
git branch -d <Name>
```

## Working with a remote repository

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
