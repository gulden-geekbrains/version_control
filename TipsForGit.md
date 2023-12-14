# GIT syntax
## or Usefull tips for Git 

### Initialize where you are for git 
**First time using Git**
```sh
git config --global user.name “Mikhail”
git config --global user.email msmerkushov123@yandex.ru
```
**After**
```sh
cd /home/locationOfFolder
git init 
```
## Saving
**To record ompleted work**
```sh
git add <filename>
    if you have space in name use "\" and space
```
**After that necessarily add commit**
```sh
git commit -m "Initial commit"
-m (message)
```
## Log
**Look at the history of commits and branches**
```sh
git log 
git log --oneline
    --oneline means in one line 
git log --graph 
    --graph  to see all branches in log 
```
## If you wanna know about Branches ;)
**To see all the branches and**

 __* means where i am__
```sh
git branch
git branch <NewNameForBranch>  
    to add new branch
git checkout <BranchName> or master    
    to switch branch
git merge <BranchName>
    to add this branch to the master branch
git branch -d <BranchName>
    -d means delete this branch
git branch -M <NewNameForBranch>
git push origin --delete <NameOfBranch>
    to push without unnecessary branches
git merge origin/main
    if you cant push or pull to github
```
## Few usefull tips 
**Remove git from project** 
```sh
rm -rf .git*
```
**To restore file** 
```sh
git resotore <filename>
```
**Get the differnce betwen two savings**
```sh
git diff
```
**Status** 
```sh
git status
```
**Go for a walk between savings**
```sh
git checkout 984b....first four digits of commit number 
or 
git checkout master 
```
## REMOTE
* find on github code (https) and copy it
```sh
git clone <copied link from github>
```
* after successfull copy go to this repository

**To load cahbges on github**
```sh
git push
```
**To get actual version of repository from github (Refresh)**
```sh
git pull
```
* click on **Fork** button on github to get copy of repository and save it on your account 

**Always add README file to copied repository and your branch**

