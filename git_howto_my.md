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
