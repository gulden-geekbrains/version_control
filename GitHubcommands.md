# Команды для управления GitHub, с помощью Терминала

1. Для размещения репозитория на сервере GitHub (далее ГитХаб) рассматривается следующие основные возможные варианты-случаи-процедуры:
    * Создание репозиторя на сервере ГитХаб и затем его клонирование-копирование-скачивание-вытягивание на локальный компьютер. _Далее этот случай будем называть "репо с локального компьютера._
    * Клонирование-копирование-закачивание-заталкивание уже существующего репозитория на локальном компьютере на сервер ГитХаб. *Далее этот случай будем называть "репо с сервера ГитХаб*

Команды для осуществления этих процедур, различны и содержаться в форме подсказок-напоминалок в ГитХаб, которые появляются в браузере, при работе с ГитХаб над создание репозиториев.

2. Отдельно нужно выделить процедуру создания Fork (далее Вилка):

    * Создание Вилки (копии) репозитория какого-нибудь пользователя на ГитХаб, для последующей отправки репозитория, с предварительно созданной отдельной веткой репозитория, содержащей изменения, которые предлагется внести хозяину репозитория в отправляемый репозиторий.

 3. Для копирования-клонирования репозитория используется команда clone.
 
 4. Для отправки изменений репозитория, сделанных на локальном компьютере, применяется команда push (выталкивание, заталкивание), а для скачивания изменений сделанных на сервере применяется команда pull (вытаскивание).

 5. Для работы с репозиториями используются уже известные команды, содержащиеся в файле Gitcommands.md

 ## Примеры действий при работе с удалёнными репозиториями

 ### 1. Репо с сервера ГитХаб.

 **1.1 Клонируем уже существующий на ГитХаб репозиторий (он же "репо", далее без кавычек):**

 ```Sh
 $ cd g/ВАЛЕКС/GeekBrains/GitHub/GitHub_tes_1
bash: cd: g/ВАЛЕКС/GeekBrains/GitHub/GitHub_tes_1: No such file or directory

АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /
$ cd g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_1

копируем из ГитХаб, нажав кнопку Code ссылку на удалённый репозиторий (аналог имени репозитория) и вставляем после команды git clone
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_1
$ git clone https://github.com/ilnar-geekbrains/version_control_lection_3.git

Cloning into 'version_control_lection_3'...
remote: Enumerating objects: 43, done.
remote: Total 43 (delta 0), reused 0 (delta 0), pack-reused 43
Receiving objects: 100% (43/43), 5.50 KiB | 208.00 KiB/s, done.
Resolving deltas: 100% (12/12), done.


АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_1
$ git status
fatal: not a git repository (or any of the parent directories): .git


исправляем недоразумение = переходим в нужную папку = репозиторий
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_1
$ cd version_control_lection_3/

АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_1/version_control_lection_3 (master)
$ git status
On branch master
Your branch is up to date with 'origin/master'.

nothing to commit, working tree clean

теперь видим, что Git видит репозиторий и в ветке master не было никаких изменений, можно далее продолжать работу с этим репозиторием.
 ```
______
______
______
______
______
**1.2 Создаём новый репозиторий на ГитХаб и затем клонируем его на локальный компьютер:**
 ```sh
 создание новой папки, кроме того, необходимо знать, что когда создаём папку для привязки её к созданному удалённому репозиторию в аккаунте GitHub, желательно, чтобы название папки было таким же, как и у папки-репозитория в GitHub, чтобы не путаться
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2
$ mkdir GB_homework_control_version_1

mkdir и далее название новой папки

создание файла README.md
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1
$ echo "# GB_homework_control_version_1" >> README.md

переименование главной ветки: в нашем случае ветку с названием master переименовываем в main
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (master)
$ git branch -M main

АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$

назначаем-добавляем источник удалённого репозитория = репозиторий созданный на GitHub  
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$ git remote add origin https://github.com/TRAVALIN/GB_homework_control_version_1.git


просмотр удалённого репозитория
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$ git remote show
origin

Видим, что название удалённого репозитория = origin = источник, а не полное имя папки-репозитория, созданного в аккаунте GitHub. Это сделано для упрощения обращения к этому репозиторию с помощью командной строки в терминале. 


отправка репозитория на удалённый сервер
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$ git push -u origin main


просмотр дополнительной информации об удалённом репозитории
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$ git remote -v

origin  https://github.com/TRAVALIN/GB_homework_control_version_1.git (fetch)
origin  https://github.com/TRAVALIN/GB_homework_control_version_1.git (push)

fetch - репозиторий для записи
push - репозиторий для чтения


просмотр более подробной информации об удалённом репозитории
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$ git remote show origin

* remote origin
  Fetch URL: https://github.com/TRAVALIN/GB_homework_control_version_1.git
  Push  URL: https://github.com/TRAVALIN/GB_homework_control_version_1.git
  HEAD branch: main
  Remote branch:
    main tracked
  Local branch configured for 'git pull':
    main merges with remote main
  Local ref configured for 'git push':
    main pushes to main (up to date)


забираем изменения из репозитория в GitHub
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$ git pull

remote: Enumerating objects: 5, done.
remote: Counting objects: 100% (5/5), done.
remote: Compressing objects: 100% (2/2), done.
remote: Total 3 (delta 0), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (3/3), 1.13 KiB | 1024 bytes/s, done.
From https://github.com/TRAVALIN/GB_homework_control_version_1
   27388c8..24fd1c0  main       -> origin/main
Updating 27388c8..24fd1c0
Fast-forward
 README.md | 3 ++-
 1 file changed, 2 insertions(+), 1 deletion(-)


выталкиваем новую ветку на сервер. важно! что только одну ветку выталкиваем - ту, которую создали и в которой создали изменения
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (newbranch)
$ git push --set-upstream origin newbranch

Enumerating objects: 5, done.
Counting objects: 100% (5/5), done.
Delta compression using up to 2 threads
Compressing objects: 100% (2/2), done.
Writing objects: 100% (3/3), 358 bytes | 179.00 KiB/s, done.
Total 3 (delta 1), reused 0 (delta 0), pack-reused 0
remote: Resolving deltas: 100% (1/1), completed with 1 local object.
remote:
remote: Create a pull request for 'newbranch' on GitHub by visiting:
remote:      https://github.com/TRAVALIN/GB_homework_control_version_1/pull/new/newbranch
remote:
To https://github.com/TRAVALIN/GB_homework_control_version_1.git
 * [new branch]      newbranch -> newbranch
branch 'newbranch' set up to track 'origin/newbranch'.


удаление ветки на сервере в репозитории 
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$ git push origin --delete newbranch

To https://github.com/TRAVALIN/GB_homework_control_version_1.git
 - [deleted]         newbranch


при возникновении конфликта: наличии изменений в файле репозитория и на сервере и на локальном компьютере команда push не работает, из-за этого самого конфликта; 
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$ git push

To https://github.com/TRAVALIN/GB_homework_control_version_1.git
 ! [rejected]        main -> main (fetch first)
error: failed to push some refs to 'https://github.com/TRAVALIN/GB_homework_control_version_1.git'
hint: Updates were rejected because the remote contains work that you do not
hint: have locally. This is usually caused by another repository pushing to
hint: the same ref. If you want to integrate the remote changes, use
hint: 'git pull' before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.


в этом случае нужно:

1. применить команду для вытаскивания изменений с сервера с функцией слияния и в Git принять необходимые изменения
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main)
$ git pull --rebase

remote: Enumerating objects: 8, done.
remote: Counting objects: 100% (8/8), done.
remote: Compressing objects: 100% (4/4), done.
remote: Total 6 (delta 2), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (6/6), 1.90 KiB | 4.00 KiB/s, done.
From https://github.com/TRAVALIN/GB_homework_control_version_1
   47ad6c2..01402fe  main       -> origin/main
Auto-merging README.md
CONFLICT (content): Merge conflict in README.md
error: could not apply b5d0e4e... Editing CONFLICT
hint: Resolve all conflicts manually, mark them as resolved with
hint: "git add/rm <conflicted_files>", then run "git rebase --continue".
hint: You can instead skip this commit: run "git rebase --skip".
hint: To abort and get back to the state before "git rebase", run "git rebase --abort".
Could not apply b5d0e4e... Editing CONFLICT

2. закончить разрешение конфликта отправкой = выталкиванием файла с принятыми внесёнными изменениями
АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main|REBASE 1/1)
$ git add README.md

АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main|REBASE 1/1)
$ git status

interactive rebase in progress; onto 01402fe
Last command done (1 command done):
   pick b5d0e4e Editing CONFLICT
No commands remaining.
You are currently rebasing branch 'main' on '01402fe'.
  (all conflicts fixed: run "git rebase --continue")

Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        modified:   README.md

АФФТОRПИЛЛОТ@DESKTOP-3877456 MINGW64 /g/ВАЛЕКС/GeekBrains/GitHub/GitHub_test_2/GB_homework_control_version_1 (main|REBASE 1/1)
$ git rebase --continue

[detached HEAD ddf5a4a] Editing CONFLICT
 1 file changed, 1 insertion(+), 1 deletion(-)
Successfully rebased and updated refs/heads/main.
Deletion of directory '.git/rebase-merge' failed. Should I try again? (y/n)
Sorry, I did not understand your answer. Please type 'y' or 'n'
Deletion of directory '.git/rebase-merge' failed. Should I try again? (y/n) y
Deletion of directory '.git/rebase-merge' failed. Should I try again? (y/n) n
error: could not remove '.git/rebase-merge'
 ```
______
______
______
______
______
### 2. Создание вилки

Для использования репозитория любого пользователя GitHub, и что важно! для последующего предложения внесённых изменений в репозиторий другого пользователя пользуемся кнопкой Fork на GitHub, рядом с репозиторием этого другого пользователя
![Alt text](image.png)

после создания Вилки клонируем репозиторий на свой компьютер и вносим изменения в отдельной, новой ветке, после чего выталкиваем репозиторий на сервер и делаем pull request = предлагаем изменения владельцу репозитория, от которого сделали Вилку = Fork.

### 3. Репо с локального компьютера.

Для пермещения репо, существующего на локальном компьютере, необходимо ввыполнить команды-подсказки от ГитХаб, после создания и присваивания имени репо на ГитХаб. Дальнейшая работа с репо осуществляется с помощью уже известных, описанных ранее команд.
