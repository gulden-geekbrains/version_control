# Git commands

Setting up email and name is like this:

```
git config --global user.name example
git config --global user.email example@example.com
```
"--global" sets the options as default for all repositories rather than only for one.

*Git init* to create an empty repository inside the directory you are in.

### Basic management

You can write **git status** to check the overall state of the branch, with it you can see the untracked, changed and deleted files along with some other things.

You can add and remove files this way:

```
git add some_file  # says git to track the file
git rm other_file  # deletes the file for git
```

You can also discard unwanted changes with *git restore*:
```
git restore main
```

I said that that git will track changed files. You can *commit* and git will take care of the changes.

```
git commit -a -m "description of changes"
```
**-a** commits all changes, **-m** sets a message for the commit.

### Logging

You can see the commits with their author, message and date using *git log*. The otput will look somewhat like this:

```
commit d83246dc218af86ef80d0cec5e39660c70b9a74f (HEAD -> master)
Author: ZeFirst <levbatura@rambler.ru>
Date:   Wed Jan 10 22:18:40 2024 +0800

    capiltalized msg struct, added msg reading function

commit 88717836ae97e75efc82bf77e4808f87bbb41c71
Author: ZeFirst <levbatura@rambler.ru>
Date:   Tue Jan 9 19:23:33 2024 +0800

    Wrote message structure with str and amount
```

Useful, but too heavy and not at all concise, isn't it? Most of the time you don't need the full hash, author and date. You can reject such bells and whistles by adding *--oneline* to the command:

```
git log --oneline
d83246d (HEAD -> master) capiltalized msg struct, added msg reading function
8871783 Wrote message structure with str and amount
```

You can write *git diff* to see the uncommitted changes in modified files.
Another quality of life trick: add --graph option at the end of git log to see commits in a more structured way.
```
git log --graph
```

### Branches

Sometimes you need to switch the branch of the project, whether it is a version or some deviation from the main code. You can do this with git checkout.

```
git checkout master
git checkout 8871783
```
Project files will be set to the state that it was in the commit with 8871783 hash or in the master branch.

You can *switch* back using this:

```
switch -
```

And the project will return to the current state of the master branch.

You can also merge branches:
```
git merge development
```
The branch you are in will be merged with development

After merge you might want to delete the branch:
```
git branch -d feat_effect
```
If you will give the git -d flag, it will warn you in some circumstances that data might be destroyed or something bad can happen. -D will delete the branch no matter what.

### Remote repositories, aka pulling, pulling, pushing, pushing 

You can add a remote repository using a command like this:
```
git remote add rep_name https://site.com/owner/repository.git
```

You can also view their names with this:
```
git remote
```

And delete them with this:
```
git remote rm rep_name
```

#### You can add your changes to the distant repository like this:

Pushing first time you would need to write something similar to this:
```
git push -u origin master
```

After that you can do this.
```
git push origin
```

In case remote and local are different and git push fails you can do this:
```
git pull --rebase
```
It would try to apply your changes on top of the changes of the remote repository.
*--continue option* llows to continue the rebase after changing anything and resolving conflicts.
```
git rebase --continue
```
&nbsp;

You can also delete branches with git push:
```
git push --delete origin some_branch
```

Sometimes you don't have the permission to push like that. So you can use git pull to make a pull request

You can also use git pull to get your repository up to date with the remote one.

If a branch does not exist in the remote repository you can push it like this:
```
git push --set-upstream origin new_local_branch
```

![Link probably got deleted and all websites from the past are slowly "dying" and shutting offline forever. Or you just don't have internet. ](https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2F6%2F68%2FOrange_tabby_cat_sitting_on_fallen_leaves-Hisashi-01A.jpg&f=1&nofb=1&ipt=9fd845840b7db9aa3eae62da831b8cf246cd1e920bf85077db566771c49c405a&ipo=images)
