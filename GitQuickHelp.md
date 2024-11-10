# Quick help and basic commands when working with Git

If working in terminal (cmd, Powershell, GitBash etc), change directory first:
```sh
cd <path/folder_name>
```

**All Git commands begin with "git" preface**

HTML page with documentation about a specific command:
```sh
git help <command>
```

## Setup

Initialize local Git repository:
```sh
git init
```

Check current status (staged/modified/untracked files):
```sh
git status
```

## Staging and committing

Add a file to stage:
```sh
git add <file_name>
```
Remember to save changes made in your file (Ctrl+S) before staging it.

Discard changes in a modified file:
```sh
git restore <file_name>
```

Unstage a file:
```sh
git restore --staged <file_name>
```

Commit all staged files:
```sh
git commit
```
It is recommended to add a commentary:
```sh
git commit -m "<commentary>"
```

## Checking commits and switching between them

Check history of all commits:
```sh
git log
```

Go to any snapshot:
```sh
git checkout <commit_hash>
```

Return to main branch:
```sh
git checkout main
```

Check difference between latest commit and currently staged files:
```sh
git diff
```

You can check the difference between individual commits
```sh
git diff <hash_1> <hash_2>
```

## Branches
Show a list of branches:
```sh
git branch
```

Create a new branch:
```sh
git branch <branch_name>
```
A new branch is created based off the branch you were previously on.

Switch to a different branch:
```sh
git checkout <branch_name>
```

## Merges
By merging branches, you add changes made in branch A to branch B. Before merging, switch to the branch B first:
```sh
git checkout <target_branch_name>
```
Then, perform the merge:
```sh
git merge <incoming_branch_name>
```

# Remote repositories

## Initial setup: Link local machine to your GitHub account
1. Create a new repository on GitHub
2. Create new local folder on your machine
3. In that new folder, type the following commands from terminal:
```sh
echo "# <folder's name>" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin <GitHub repository URL>
git push -u origin main
```
When using the **git push** command for the first time, Git Bash will require authorization with your GitHub account and link them.

## Cloning, pushing and pulling
Create a copy of the remote repository on your machine:
```sh
git clone <GitHub repository URL>
```
Download the latest version of the remote repository and merge it with your local repository:
```sh
git pull
```
Upload your local repository online and merge with the existing remote repository:
```sh
git push
```
Pushing and pulling may create merge conflicts which will require resolving, if same files are edited on both sides.

## Pull requests:
To make contributions to a different project, you should create a personal copy of the project, create a separate branch, and make the contribution there.

1. On the GitHub page of the project, click **"Fork"** to create your copy of the original proect
2. Clone your fork on your machine:
```sh
git clone <fork URL>
```
3. Create a separate branch:
```sh
git branch <new branch's name>
```
4. Make and commit your edits in that branch
5. Push the changes to your fork:
```sh
git push --set-upstream origin <new branch's name>
```
6. Go to the fork's page. Select the branch that you have just worked in and click **"Compare & pull request"** to create the pull request.