# Peparation

* **Download and launch git from official website.**  

# Repository 

1.**Enter cd (change directory) command**
```sh
cd
```  

2.**Create a folder and set path to the foder** 
```sh
cd C:\Users\ПК\Desktop\Lesson1HW>
```

3.**Introduce yourself to git by cds:**
```sh
cd git config --­­global user.name "Your Name"
```
```sh
cd git config ­­--global user.email "your email"
```
4.**Repository initialization**
```sh
cd git init
```
# Basic commands

* to get the **current** git status use:
```sh
cd git status
```

* to **add** file and/or files to following commit use:
```sh
cd git add
```

* to **create** commit use:
```sh
cd git commit -m"message"
```

* to get all **commit history** with hash-codes use:
```sh
cd git log
```

* to **switch** from one commit to another use:
```sh
cd git checkout
```

* back **to actual state** and keep working use:
```sh
cd git checkout master
```

* to see **the difference** between current file and commited file use:
```sh
cd git diff
```

## Ignore files

If you need **to ignore (not to track)** some files create **.gitignore file** and put them in it and use /* in the last one

*For example:*
1. DS.Store

2. .VScode/*

# File delete
1. To remove file from repository use cd:
```sh
cd git rm name.md
```
2. **Manually** from folder, but you can restore is using cd:
```sh
cd git rm name.md
```
# Branch
* To see the list of brances in repositoryuse:
```sh
cd git branch
```
* To create a new branch use:
```sh
cd git branch branch_name
```
* To switch between branches:
```sh
cd git checkout branch_name
```
* To switch to the main branch use:
```sh
cd git checkout master
```
* To merge 2 branches use:
```sh
cd git merge branch_name
```
* To delete a branch use:
```sh
cd git branch d- branch_name
```
# Rename
```sh
cd git mv name.md NAME.md
```

## GIThub

* **to download** a repository from GIThub **fork** it to your account **then use its link**
or **create your own repository** an also use its link 

* **Paste** the link in terminal using this cd:
```sh
cd git clone your_link
```
* Use **new branch** to add any changes
* **To upload** current version to GIThub use:
```sh
cd git push
```
* **To get** all changes and **merge** with local version use:
```sh
cd git pull
```
**YOU CAN ALSO MAKE THE COMMITS DIRECTLY IN GITHUB COMMENT SECTION**