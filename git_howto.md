# Подсказка по GIT

## Создание репозитория:
```sh
git init
```

## Добавить файл к отслеживанию
После изменения файла сохраняем его (ctrl+s)
```sh
git add <filename.md>
```

## Делаем коммит
Делаем коммит и добавляем сообщение, что конкретно мы изменили
```sh
git commit -m "message"
```
## Смотрим историю изменения файла
Для этого есть команда
```sh
git log 
```
Или, если хотим вывести историю изменения в одну строку
```sh
git log --oneline
```

## Просмотр статуса Git'a
После сохранения файла мы можем посмотреть, есть ли у нас какие-либо несохранённые изменения

Для этого используется команда
```sh
git status
```
Вывод команды может быть разным, например
* Если файл изменён, но изменения не сохранены
```sh 
On branch master
Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   git_howto.md

no changes added to commit (use "git add" and/or "git commit -a")
```
Для решения этой проблемы необходимо добавить файл (см. выше) и сделать commit

* Если изменения были сохранены

Должно быть выведено сообщение
```sh
On branch master
nothing to commit, working tree clean
```

* Если после добавления не был сделан commit и были сделаны ещё изменения
```sh
On branch master
Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        modified:   git_howto.md

Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   git_howto.md
```
Предлагается либо 
1. Восстановить изменения с помощью команды 
```sh
git restore --staged 
```

2. Закоммитить только первые изменения
```sh
git commit -m "message"
```
3. Добавить файл по новой и сделать коммит уже с новыми изменениями
```sh
git add <filename>
git commit -m "message"
```

## 
Для этого используется комманда 
```sh
git restore --staged
```
staged показывает до какого коммита мы восстанавливаем сохранения. несохранённые же изменения просто напросто удалятся

## Переключаемся между коммитами
Для того, чтобы переключиться между коммитами, используем команду 
```sh
git checkout <номер коммита>
```


## Просмотр изменений
* Между последним коммитом и сохранённым файлом
Для этого можно ввести команду 
```sh
git diff
```
Пример вывода:
```sh
diff --git a/git_howto.md b/git_howto.md
index 6725906..23c6d5a 100644
--- a/git_howto.md
+++ b/git_howto.md
@@ -89,3 +89,15 @@ git restore --staged
  ```.
 staged показывает до какого коммита мы восстанавливаем сохранения. несохранённые же изменения просто напросто удалятся

+## Переключаемся между коммитами
+Для того, чтобы переключиться между коммитами, используем команду 
```
2. Если мы хотим посмотреть изменения между двумя конкретными коммитами, вводим дополнительно ещё номера двух коммитов
```sh
git diff <номер 1 коммита> <номер 2 коммита>
```

Пример ввода/вывода:
```sh
git diff c1bb864 b0fb91f
```
```sh
diff --git a/git_howto.md b/git_howto.md
deleted file mode 100644
index dbd79c3..0000000
--- a/git_howto.md
+++ /dev/null
@@ -1,14 +0,0 @@
-# Подсказка по GIT
-
-Создание репозитория:
-```sh
-git init
```

## Git config
Необходимо для просмотра версии git'a и остальных его параметров
```sh
git config
```
Для просмотра имени пользователя необходимо добавить user.name
```sh
git config user.name
```
Для просмотра email'a пользователя необходимо добавить user.email
```sh
git config user.email
```



**На этом всё** 


# Второе занятие - ветвление

**Перемещение по веткам**
```sh
git checkout <branch_name>
```

**Отображение всех веток**
```sh
git branch
```

**Создание новой ветки**
```sh
git branch <имя новой ветки>
```

**Удаление ветки**
```sh
git branch -d <branch_name>
```

**Вывод log в виде графа**
```sh
git log --oneline --graph
```
*__или__*
```sh
git log --graph
```

**Слияние веток**

Необходимо перейти в первую ветку через git checkout, в которую мы добавляем вторую, а в команде
записать имя второй ветки
```sh
git merge <branch_name>
```

**Что я узнал при удалении**

Если Вы не слили ветки, и при этом хотите удалить одну из них, при вводе команды 
```sh
git branch -d <branch_name>
```
Терминал выдаст ошибку в виде
```sh
error: the branch 'sos' is not fully merged.
If you are sure you want to delete it, run 'git branch -D sos
```
Если же Вы уверены в том, что ветку необходимо удалить, используйте флажок -D
```sh
git branch -D <branch_name>
```
**ТАКЖЕ**

Если Вы хотите удалить ветку, но при этом Вы на ней находитесь, Вы не сможете её удалить, терминал выдаст ошибку 
```sh
error: cannot delete branch 'sos' used by worktree at 'C:/Users/1/Desktop/git01'
```
'C:/Users/1/Desktop/git01' - полный путь до папки, в которой Вы работаете

**И ещё немного:**

Если Вы удалили ветку, в которой работали, и вдруг захотели в неё вернуться, у Вас не получится, терминал выдаст ошибку
```sh
error: pathspec '<branch_name>' did not match any file(s) known to git
```

## Подсказки по работе с удаленными репозиториями

Если мы хотим подтянуть репозиторий из Github, необходимо это сделать с помощью команды
```sh
git clone <ссылка на репозиторий>
```

