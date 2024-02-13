# _**Instruction GIT**_

## 1. _Chapter: Name & Email address_
* Username
    > git config --global user.name "First Second"
* Email
    > git config --global user.email "mail@domain.com"

## 2. *Chapter: Initialize, add & commit*

1. Initialize catalog
    > git init
2. Include in what will be committed
    > git add 'filename'
3. Commit changes
    > git commit -m "text"
## 3. _Chapter: Status, Log_

1. Show repozitory status
    > git status
2. Commit history
    > git log

## 4. _Chapter: Diff, show, rm, mv_
    
1. All changes
    > git show 'hash'
2. Changes before commit
    > git diff
3. Remove files
    > git rm dirname/file
4. Rename file
    > git mv [dir1](httpr:// "Source - real file or catalog")/filename [dir2](https:// "Destination - real catalog")

## 5. _Chapter: Checkout_

1. Switch to commit
    > git checkout 'hash'
2. Switch to last commit
    > git checkout master

## 6. _Chapter: New branch_
1. Create new branch
    > git branch branch_name
2. Switch to anithe branch
    > git checkount branch_name
3. Delete branch
    > git branch -d branch_name

## 7. *Chapter: Merge branch*

> git merge branch_name

_Note: To merge branches, you must be on the branch you want to add changes to._

## 8. _Chapter: Git logs_

1. The log of your branch
    > git log
2. The log of your branch is a simplified version
    > git log --oneline
3. The log of your branch indicating the merge
    > git log --graph

# ***The end***
