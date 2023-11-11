[Git cheat sheet](https://education.github.com/git-cheat-sheet-education.pdf "Git cheat sheet")  

## Setup  
Configure user information across all local repositories  
```sh
git config --global user.name "firstname surname"
git config --global user.email "user@mail"
```  
Set automatic command line coloring for Git for easy reviewing  
```sh
git config --global color.ui auto
```  

## Setup and init
Initialize existing directory as a `git` repository  
```sh
git init
```  
Retrieve an entire repository from a hosted location via URL
```sh
git clone
```  
##  Stage and snapshot
Show modified files in working directory
```sh
git status
```  
Add a file as it looks now to your next commit(stage)  
```sh
git add <file>
```  
Unstage a file while retaining the changes in working directory
```sh
git reset <file>
```  
Diff of what is changes but not yet staged
```sh
git diff
```  
Diff of what is staged but not yet commited
```sh
git diff --staged
```  
Commit your staged content as a new commit snapshot
```sh
git commit -m "descriptive message"
```
## Inspect and compare
Show the commit history of the currently active branch
```sh
gti log
```



