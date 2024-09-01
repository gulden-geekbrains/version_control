# GIT howto

Repository creation
```sh
git init
````

add file to GIT
```sh
git add
````

Start a commit with GIT
```sh
git commit -m "Message"
```

directory change command
```sh
cd c:\folder name
```

Show current directory command
```sh
pwd
```

Current directory listing Linux, MasOS:
```sh

ls
````
Delete file
```sh
rm <filename>
```
See versions log
```sh
git log
````
 Back the the latest version
 ```sh
 git checkout master
 ```
 See versions in one line only
 ```sh
 git log --oneline
 ````
See changes in a file
```sh
git diff
```
Redo unsaved changes
```sh
git restore
```
See differences between 2 versions
```sh
git diff <commit1> <commit2>
```

To see different file branches 
```sh
git branch
```

To swith to another branch
```sh
git checkout <another branch name>
```

File <.gitignore> allows GIT to ignore certain files in the folder (usually is used for images). Just add file name you do not want GIT to index this file.

To merge branches use
```sh
git merge <branch name> test2
```
You should do it in the branch to which you´d like to add another branch, so first checkout to the "main" branch and then execute *merge* command. 

To delete a branch
```sh
git branch -d <branch name>
```

To see branches in log
```sh
git log --oneline --graph
```

To leave dead editor 
```sh
press *esc* and enter <:wq>
```

test1 test1 test1

test2 test2 test2

To clone a repository
```sh
git clone <link>
```
To rename a branch
```sh
git branch -m <new name>
````

To upload local files to GitHub
```sh
git push -u origin
````

To see remote repository status
```sh
git remote -v
````

To pull changes from GitHub
```sh
git pull
````

To push changes to GitHub
```sh
git push
````

To push only one branch
```sh
git push --set - upstream origin <branch name>
````

To push and delete a branch
```sh
git push origin --delete <branch name>
````

To pull changes and compare
```sh
git pull --rebase
````
