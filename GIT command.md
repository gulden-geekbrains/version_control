## Basic GIT commands

* *Set the user name and email address*

```sh
git config --global user.name "XXXX XXXXXX"
```

```sh
git config --global user.email "XXXX@XXXXX.com"
```

* *Initializing the repository*

```sh
git init
```

* *Adding a file to the repository*

```sh
git add <filename>
```

* *Making changes and fixing them in the current file*

```sh
git commit -m "comment text"
```

* *Checking the repository status*
```sh
git status
```

* *Viewing the history of commits with changes*
```sh
git log or git log --oneline
```

* *Selecting a specific commit*
```sh
git checkout "commit id"
```

* *Going to last (master) commit*
```sh
git checkout master
```

* *Viewing changes before commit*
```sh
git diff
```

* *Show all branches*
```sh
git branch
```

* *Switching between branches*
```sh
git checkout <branch_name>
```

* *Create new branch*
```sh
git branch <branch_name>
```

* *Delete branch*
```sh
git branch -d <branch_name>
```

* *Show additional graphical view in log with oneline*
```sh
git log --oneline --graph
```