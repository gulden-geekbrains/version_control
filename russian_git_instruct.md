# Команды git`а

Можно настроить своё имя и адрес почты этими командами:

```
git config --global user.name example
git config --global user.email example@example.com
```
"--global" ставит эти настройки по умолчанию для всех репозиториев.

*Git init* для того, чтобы создать репозиторий внутри папки, в который терминал.

## Простое управление

Можно написать **git status** для того, чтобы увидеть общее состояние ветки, эта команда покажет все недобавленные, измененные и удалённые файлы.

Можно удалять и добавлять файлы для git`а вот так:

```
git add some_file  # говорит git`у отслеживать файл
git rm other_file  # удаляет файл для git`а
```

Можно "отказаться" от внесённых изменений с помощью *git restore*:
```
git restore main.c
```

Я говорил о том, что git будет отслеживать изменённые файлы. Можно использовать команду *commit* и гит добавит изменения.

```
git commit -a -m "description of changes"
```
**-a** добавляет все изменения, **-m** добавляет сообщение к коммиту.

### Логи

Можно увидеть коммиты вместе с их автором и датой с помощью *git log*. Выведет что-то в подобном роде:

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

Полезно, но слишком громоздко, не так ли?  Большую часть времени не нужен полный хеш, автор и дата. Можно убрать такие ненужные детали с помощью добавления *--oneline* к команде:

```
git log --oneline
d83246d (HEAD -> master) capiltalized msg struct, added msg reading function
8871783 Wrote message structure with str and amount
```

Можно написать *git diff* для того, чтобы посмотреть на изменения в файлах.
Также можно добавить *--graph* как опцию для git log. Это сделает логи более структурированными и красивыми.
```
git log --graph
```

### Ветки

Часто бывает так, что надо изменить ветку проекта, будь это другой версией, либо подвидом основной ветки. Это можно сделать с git checkout.

```
git checkout master
git checkout 8871783
```
Файлы проекта вернуться в то состояние, в котором они были в коммите с хешом 8871783 или в ветке master.

Можно использовать *switch*, чтобы вернуться обратно:

```
switch -
```

И проект вернётся в своё обычное состояние.

Ветки также можно мержить, сливать в одно целое:
```
git merge development
```
Эта команда смержит текущую ветку с веткой development.

После того, как ветка смержена может оказаться, что эту самую ветку надо удалить:
```
git branch -d feat_effect
```
Опция -d сделает так, что при возможности удаления информации или при других чаще всего не очень хороших обстоятельства git не будет удалять. Если информация не нужна, а причина не проблема, то опция -D удалит ветку без возражений.

### Удалённые репозитории, а если точнее - пуллинг, пуллинг, пушинг, пушинг

Такой командой можно связать удалённый репозиторий с локальным:
```
git remote add rep_name https://site.com/owner/repository.git
```

С помощью такой команды без чего-либо дополнительного можно увидеть имена удалённых репозиториев
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

![Изображение недоступно.](https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2F6%2F68%2FOrange_tabby_cat_sitting_on_fallen_leaves-Hisashi-01A.jpg&f=1&nofb=1&ipt=9fd845840b7db9aa3eae62da831b8cf246cd1e920bf85077db566771c49c405a&ipo=images)
