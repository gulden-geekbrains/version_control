## This file is written using MarkDown
**You can get acquainted with the syntax of the language at this link: [MarkDown syntax](https://www.markdownguide.org/basic-syntax/ "MarkDown Basic Syntax")**


## Install Git
Information on installing the git is available at the link: [Git install guide](https://github.com/git-guides/install-git "link for guide")


# List of command GIT

View version git:
```sh
git --version
```
Set to config user name:
```sh
git config --global user.name "UserName"
```
 Create an empty Git repository or reinitialize an existing:
```sh
git init
```
Add file contents to the index: 
```sh
git add "filename"
```
Record changes to the repository:
```sh
git commit -m "Message"
```
Show commit logs:
```sh
git log
```
Show commit logs in one line:
```sh
git log --oneline
```
Show the working tree status:
```sh
git status
```
Switch branches or restore working tree files:
```sh
git checkout
```
Show changes between commits, commit and working tree, etc:
```sh
git diff
```
Display help information about Git:
```sh
git --help
```

[![Image with commands](https://present5.com/presentforday2/20170206/git_images/git_3.jpg "Basic commands")](https://present5.com/presentforday2/20170206/git_images/git_3.jpg)


# Добавление картинки
Это яблоко
![apple](apple.jpg)


Switch branches or restore working tree files:
```sh
git checkout <branch_name>
```

List branches
```sh
git branch
```
Join two or more development histories together
```sh
git merge
```
Create new brance
```sh
git branch <branch_name>
```
Delete a branch. The branch must be fully merged in its upstream branch, or in HEAD if no upstream was set with --track or --set-upstream-to.
```sh
git branch -d <branch_name>
```
Draw a text-based graphical representation of the commit history on the left hand side of the output. This may cause extra lines to be printed in between commits, in order for the graph history to be drawn properly. 
```sh
git log --graph
        or
git log --oneline --graph
```

# Команды для работы с удалённым репозиторием
When you run git branch --all, you will also see the local working branches. These can be linked with branches on the remote, or they could exist with no remote counterpart.

Clone (download) a repository that already exists on GitHub, including all of the files, branches, and commits.
git status: Always a good idea, this command shows you what branch you're on, what files are in the working or staging directory, and any other important information.

```sh
git clone [url]
```
## git push
Uploads all local branch commits to the remote.
```sh
git push
```
Force a push that would otherwise be blocked, usually because it will delete or overwrite existing commits (Use with caution!)
```sh
git push -f
```
Useful when pushing a new branch, this creates an upstream tracking branch with a lasting relationship to your local branch
```sh
git push -u origin [branch]
```
Push all branches
```sh
git push --all
```
Publish tags that aren't yet in the remote repository
```sh
git push --tags
```
## git pull
Updates your current local working branch with all new commits from the corresponding remote branch on GitHub.
git pull is a combination of git fetch and git merge. 
```sh
git pull
```
Update your local working branch with commits from the remote, but rewrite history so any local commits occur after all new commits coming from the remote, avoiding a merge commit.
```sh
git pull --rebase
```
This option allows you to force a fetch of a specific remote tracking branch when using the <refspec> option that would otherwise not be fetched due to conflicts. To force Git to overwrite your current branch to match the remote tracking branch, read below about using git reset.
```sh
git pull --force
```
Fetch all remotes - this is handy if you are working on a fork or in another use case with multiple remotes.
```sh
git pull --all
```
