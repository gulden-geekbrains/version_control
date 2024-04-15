# GIT - how to use it

## lesson 1

*We start to learn GIT. There you can find som usefull commands.*

- create new location for files
``` sh
git init
```

- check status of the folder and branch
``` sh
git status
```

- to add into GIT analis

``` sh
git add
```

- add comment for understanding

``` sh
git commit -m "message"
```

 - all changes and comments

``` sh
git log
```

- all comments in one line with codes

```sh
git log --oneline
```

 - change version of the file

``` sh
git checkout <code>
```
- back to last version

``` sh
git checkout master
```

- delite files
``` sh
del <file name>
```

- delit without chance to retern
```sh
git restore
```

- show difference
```sh
git diff
```
## lesson 2

*Today we learn how to work with different branches*

- To make new branch for changes
```sh
git branch <new_name>
```

- To check branches
```sh
git branch 
or
git status
```

- To change branches
```sh
git checkout <new_name>
```

- To compaund 2 branches
```sh
1. cheng location to master branch
git checkout master
2. compaund with the branch you need
git merge <new_name>
```

- To delit branch
```sh
git branch -d <new_name>
```

- To stop the merge
```sh
git merge --abort
```

- all comments in one line with codes and branches

```sh
git log --oneline --graph
```

## lesson 3


*Here we learn how to work with remoteled files*

#### First steps

1. Press the button **FORK** on the repository that you need  to change and do pull request then.
[Try this for HW](https://git@github.com:gulden-geekbrains/version_control.git "необходимый репозиторий")
2. Cloning command for fork-copies
```sh
git clone git@github.com:*YOURE_GITHUBNAME*/version_control.git
```
3. Make new branch and alter the file.
```sh
git branch <branch_name>
git checkout <branch_name>
*add your changes*
git add <file_name>
git commit -m "Добавили инструкцию как создать pull request"
```
4. Make push  
```sh
git push --set-upstream origin <branch_name>
```

If it is your first pushing, than you should try to connect accounts. After you do this, your version of document will be displayed in web. Update the page.

5. Look at your web repository. Chouse branch **<branch_name>** and press the button **Compare & pull request**

