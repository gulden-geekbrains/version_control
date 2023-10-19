
# Hints for GIT

### `git init`

To initialize a Git repository, you can use the following command:
```sh
git init
```

### `git add`

To stage changes and prepare them for the next commit, you can use the following command:

```sh
git add <file_name>
```

### `git commit -m`

To commit your changes along with a commit message, use the following command:

``` sh 
git commit -m "Your commit message here"
```

### `git log`
To view commits in a Git repository created on a specific date or range of dates, use the following command::

```sh
git log 
```
### `git log --online`
To display a concise, one-line commit history, use the following command:
```sh
git log --oneline
```
### `git checkout`
To switch the currently active branch/restore files, use the following command:
```sh
git checkout
```
### `git checkout master`
To switch to the master branch specifically, use the following command:
```sh
git checkout master
```
### `git diff`
To view the differences between your working directory and the last commit, use the following command:
```sh
git diff
```
### `Branch creation`
To create the branch as a parallel version with separate repository
```sh
git branch <branch_name>
```
### `Rename the branch`
To rename the brach name
```sh
<<<<<<< HEAD
git branch -m <new-branch-name>
=======
git branch
```
### `To merge`
To merge the branch with Master-branch

```sh
git merge
>>>>>>> 4_branch
```