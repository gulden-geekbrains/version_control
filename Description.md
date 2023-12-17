# Краткое описание команд GIT

## GIT
GIT - одна из систем контроля версий

## Основные методы форматирования текста:

1. # Заголовок первогоуровня - "#"
2. ## Заголовок второго уровня - "##"
3. ### Заголовок третьего уровня - "###"
4. **Полужирный текст** -** **
5. *Курсив* - * *
6. * Ненумерованный список - *   
7. >Первый уровень цитирования - >
8. >>Второй уровень цитирования - >>
9. WEB ссылки [example](http.example.com "tooltip")

## краткий перечень основных команд
* Команда смены директории
```sh
cd 
```
* Команда отображения текущей директории
```sh
pwd 
```

* Команда инициализации ГИТ в текущей папке
```sh
git init 
```

* Команда отображение текущего статуса
```sh
git status 
```

* Команда добавления нового файла для отслеживания ГИТом
```sh
git add 
```

* Команда сохранения изменений 
```sh
git commit 
```

* Команда добавления описания к сохраняемым изменениям
```sh
git commit -m "Комментарий"
```

* Команда лога изменений файла
```sh
git log
```

* Команда лога изменений файла в кратком виде
```sh
git log --oneline
```

* Comand for visual interpritation of changes
```sh
git log --oneline --graph
```

* Команда разницы между текущим и сохраненным файлом
```sh
git diff
```

* Команда разницы между 2 версиями файла
```sh
git diff "номер лога" "номер лога" 
```

* Команда перехода к определенной версии файла
```sh
git checkout ######
```
* Новые команды

* New image
![Image](image.jpg)

* Show all branches
```sh
git branch
```

* Show all branches
```sh
git branch
```

* Another new command

* Command for copeing changes from another brach
```sh
git merge 
```
* Command for creating new brancg and switching to it
```sh
git checkout -b NAME_OF_THE_BRANCH
```
* Command for adding changes and commitng at the same time
```sh
git commit -a
```

* Command for cloning repo 
```sh
git clone
```

* Command for downloading changes of repo from GIT server
```sh
git fetch
```

Command for downloading changes of repo from GIT server + merging it with current branch
```sh
git pull
```

Command for uploading changes of repo to GIT server
```sh
git push
```

Command for changing name of current branch
```sh
git branch -M main
```

Command for conecting with remote repo
```sh
git remote add origin ####
```

Command show info from all the branches of remote repo
```sh
git remote show
```

Command shows info about remote repo, from which you cloned 
```sh
git remote show origin
```

Command for rebasing one branch on another with specified options
```sh
git rebase 
```