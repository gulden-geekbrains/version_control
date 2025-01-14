# Подсказка по GIT (Git help)

### Последние дополнения

### Клонирование удаленного репозитория в локальное расположение
```sh
git clone (https://...)
```
### Отправка отредактированного содержимого ветки <branch> на удаленный репозиторий (-u - система запомнит ветку и следующий раз будет достаточно просто набрать `git push`)
```sh
git push -u origin <branch>
```
### Показывает состояние удаленного репозитория
```sh
git remote show origin
```
### git pull вначале забирает изменения с удалённого репозитория, а затем пытается слить их с текущей веткой
```sh
git pull
```
### Скачивание и слияние версий с удаленного и локального репозиториев в случае конфликта (наличия изменений как в локальном, так и на удаленном репозиториях).
```sh
git pull --rebase
```


## Proclaiming work repository
```sh
git init
```
## Adding specified file <filename> for indexation
```sh
git add filename
```
## Commit specified file wih message
```sh
git commit -m "Message"
```
## Git log

1. ### View log of commiting
```sh
git log
```
2. ### View brief log of commiting
```sh
git log --oneline
```
3. ### Brief log in graph notion
```sh
git log --oneline --graph
```
### Git checkout <initial part of hash>
* #### ***Jumping to needed commited state***
```sh
git checkout initial_part_of_hash
```
* #### ***Jumping to final commited state of main branch***
```sh
git checkout master
```
### <u>View status log</u>
```sh
git status
```
### View differences btwn commited states `hash1` and `hash2`
```sh
git diff hash1 hash2
```
### Restore file to the state of last commit
```sh
git restore
```
### Gives information to specified commit
##### *(Data available in two blocks: metadata and list of changes)*
```sh
git show hash
```
### Undo changes
#### *(Only before `git add` command)*
```sh
git restore
```
### Deleting file from index and working dir
#### *(Use option `--cached` to del only from index)*
```sh
git rm filename
```
### Undo commit
```sh
git reset
```
### Create a new branch <branchname>
```sh
git branch branchname
```
### Go to specified branch
```sh
git checkout branchname
```
### Merging of branchename to master
##### (To merge you must be in master branch)
```sh
git merge branchname
```
### Delete branch <branchname>
```sh
git branch -d branch_name
```

*"q" - exit from multipage viewing mode*

*"wq" - exit from merge redactor mode*

[***More help*** (*click here*)](https://skillbox.ru/media/code/osnovnye-komandy-dlya-raboty-s-git-i-github/ "Справочник команд git")
