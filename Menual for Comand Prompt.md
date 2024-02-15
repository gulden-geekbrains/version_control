# Commands for Command Prompt

1. Command for directory change (Folders or else)
```sh
cd - C:\Users\Lenovo\Desktop\Lesson 1
```

 2. Command for current directory check
```sh
pwd - this only for Mac & Linux
```
3. Listing for carrent Directory
```sh
Windows: dir
> Mac&Linux: ls
```
4. For folder Initialization
```sh
git init
```
5. To show file status
```sh
git status
```

6. To add file under Git change trucking

```sh
add "name of the file"
    #note: If you type first 2 letters and press Tab button file name will bring automaticly
```

```sh
git commit -m "some comment about commit"
```

8. Delating files from path
```sh
Windows: del "file name"
Mac&Linux: rm file name
```
9. To see History of commits
```sh
git log
    #Note: Under this command we can see Hesh which is unice for each commit that we have done. It is history or backup code. Also we can see by whom and when it was done. Also GMT - Time zone.
```

10. To see commits in one line
```sh
git log --oneline
```

11. To do backup
```sh
git checkout Hesh number
git #checkout master will backup at the latest version of commit#
```
12. Command which shows changes but not yet commited
```sh
git diff
```
13. For deleting uncommited addings
```sh
git restore
```

14. If we want check differance betwin Heshes
```sh
git diff Hesh Hesh
```

15. To check all branched
```sh
git branch
```

15. Creation of new branch
```sh
git branch <name_branch>
```
16. For deleting branch
```sh
git branch -d <name_branch>
```

17. To see logs with it's branch historyes
```sh
git log --oneline --graph
```

18. Clone remote repository to local
```sh
git clone https://github.com/Ruda15/version_control.git

    #Note: We can clone repository from other user profile or we can Fork it to our profile and then clone it to local repo. 
```

19. To bring remote repository changes from

```sh
git pull
```

20. To send Local repository to remote
```sh
git push
```

