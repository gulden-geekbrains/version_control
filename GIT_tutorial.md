# Git Tutorial
## What is Git?
**Git** - the most popular tool for version control. It can have local and remote repositories.

## Initializing A Repository in an Existing Diractory

1. Go to a project directory  
    *For Linux*
    ```sh
    $ cd /home/user/<foldes_name>
    ```
    *For MacOS*
    ```sh
    $ cd /Users/user/<folder_name>
    ```
    *For Windows*
    ```sh
    $ cd C:/Users/user/<folder_name>
    ```
    You just need to specify the path to your directory.

2. Then type following command:
```sh
git init
```
Hidden folder with the title ".git" will appear in the directory.

## Creating commits

### git add
The `git add`command adds content from the working directory into the staging area (or "index") for the next commit.

### git status
The `git status` command will show the different states of files in the working directory and staging area. Which files are modified and unstaged and which are staged but not yet committed. It also  will show some basic hints on how to move files between these stages.

### git commit -m "Message"
The `git commit` command takes all the file contents that have been staged with `git add` and records a new permanent snapshot  in the database and then moves the branch pointer on the current branch up to it.  
* -a - a flag to skip `git add` command.
* -m - a flag to pass a commit message in:
```sh
git commit -m "Message text"
```

### git diff
The `git diff` command is used when user wants to see differencies between two trees. This could be the difference: 
* between working environment and staging area (`git diff` itself)
* between staging area and the last commit (`git diff --staged`). If you want to see what you've staged that will go into your next commit.
* or between 2 commits (`git diff master branch`)
**NOTE!** `git diff` by itself doesn't show all changes made since the last commit - only changes that are still unstaged.

### git restore
The `git restore` command restores working tree files with some contents from a restore sources.

### git clean
The `git clean` command is used to remove unwanted files from the working directory. This could include removing temporary build artifacts or merge conflict files.  
Some common reasons for cleaning your working directory might be to remove cruft that has been generated be merges or external tools or to remove build artifacts in order to run a clean build.

## Branching & Merging
### git branch
The `git branch` command is a branch management tool. It can list the branches that exist, create a new branch, delete branches, rename them. Shows all branches:
```sh
git branch
```
To create a new branch:
```sh
git branch <new_branch_name>
```
To delete irrelevant branches:
```sh
git branch -d <branch_name>
```

### git checkout
The `git checkout` command is used to switch branches and check content out into a working directory.
```sh
git checkout <branch_name>
```

### git merge
The `git merge` tool is used to merge one or more branches you have checked out. It will then advance the current branch to the result of the merge.

### git log
The `git log` command is used to show the reachable recorded history of a project from the most recent commit snapshot backwards. By default it shows only the history of the branch you're currently on.  

The `git log --oneline` command prints the contents of the commit logs as well, but instead of showing the full hexadecimal commit object name, it shows a prefix that names the object uniquely, and in one line.

The `--oneline` option values are particularly useful with another `log` option called `--graph`. This option adds a nice graph showing a branch and merge history:
![git_log_oneline_graph](git_snap.png)

## Remote repositories
### git pull
The `git pull` command is basically a combination of the `git fetch` and `git merge` commands, where Git will fetch from the specified remote and then immediately try to merge it into the branch.

### git push
The `git push`command is used to communicate with another repository, calculate what your local database has that the remote one doesn't, and then pushes the difference into the other repository. It requires write access to the other repository and so normally is authenticated somehow.

### git remote
The `git remote` command is a management tool for the record of remote repositories. It allows to save long URLs as short handles, such as "origin" so you don't have to type them out all the time. You can have several of these and the `git remote` command is used to add, change and delete them.