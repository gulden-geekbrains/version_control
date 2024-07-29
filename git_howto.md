# GIT cheat sheet:

Create a new local repository:
```sh
git init
```

Add file to staging:
```sh
git add
```
Commit all stages files to git:
```sh
git commit -m "Message text"
```
List commit history:
```sh
git log
```
List commit history in oneline:
```sh
git log --oneline
```
Switch the version of project:
```sh
git checkout <branch_name>
```
Showing all branches:
```sh
git branch
```
Creating new branch:
```sh
git branch <branch_name>
```
How to delete branch:
```sh
git branch -d <branch_name>
```
Merge branch brnach_a intro brnach brnach_b:
```sh
git checkout <brnach_b>
git merge <branch_a>
```
Download a remote repo:
```sh
git clone <url>
```
Upload local content to remote repo:
```sh
git push <alias>
```
Rebase you local changes:
```sh
git pull
```

## If you need more information about GIT commands list , check the [link](https://git-scm.com/docs "more info about git")