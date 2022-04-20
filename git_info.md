# Инструкция по работе с git

git —version - version of git

git init - initialize git to current folder

git status - current git status

git add + filiname - add file to git control

git commit -m “=text=” - save commit

git log - view all saved commits

git checkout + hashtag - return to commit with hastag

git log —oneline  - all commits per one line

got diff hash1 hash2 - difference between the hash1 and the hash2

 //—————————————-Exercise————————————————

cd - change directory

dir - view all directory

pwd - view current way

git diff - difference between current and committed sessions

git config --list - view list for git info

.gitignor - file contains strings with ignoring files

git branch - view brunches

clear - clear the viewed text in the console

git branch + branchName - create new branch

git checkout + branchName - switch to the branch what has name “branchName”

**git merge + branchName** - merging the master branch and branchName

git branch -d + deletingBranch - delete the branch after merge

git log —graph - графическое отображение веток

file **.gitignor** - используем для расположения в нем файлов, которые не подлежат сохранению

//——————————————OLD INFO———————————————

1. ls - list directory
2. cd + [Dir.Name](http://dir.name/) - inside [dir.name](http://dir.name/)
3. cd ~ - return to home directory
4. cd .. - return to one step in directory's stairway
5. cd ../.. - return to two step in directory's stairway
6. mkdir + DirName - create directory
7. touch + fl.txt - create file
8. cp fl.txt fl_tst.txt - copy file where fl.txt it's "from", and fl_tst.txt it's "to"
9. mv fl.xt fl_new.txt - rename from to
10. echo "MyText" > fl.txt - write text to file
11. cat fl.txt - display the contents of the file
12. rm fl.txt - remove (delete) file
13. rm -R DirName - remove directory
14. ls -a - viewing all elements to the directory
15. git init - initialize git repository in the current directory
16. git status - current git status
17. git remote add origin + link - sinc the local git and the github link
18. git remote -v - view the connections' list
19. git add filename.fn - add to commit
20. git rm --cached filename.fn - get out in commit list
21. git commit - создание слепка изменений
22. i (в режиме сохранения) - режим записи текста о изменении Esc окончание записи
23. :rq - запись и выход
24. git commit -m'commit message' - запись коммит с сообщением о изменении
25. git log - история коммитов
26. git log --oneline - история репозитория упрощенная
27. git reset + hash - возврат к передыдущему состоянию без удаления коммита
28. git reflog - история всех коммитов, текущий + ресеты
29. git revert + hash - новый коммит c удалением изменений в указанном хэше
30. git restore - сброс состояния файла на указанное
31. git branch - проверка количества веток с указанием в какой ветке мы находимся
32. git branch + bn - создание новой ветки с именем bn
33. git checkout bn - переключение на ветку bn
34. clear - очистка терминала
35. git branch + bn + master - создание новой ветки с коммитами из мастера
36. git checkout -b dev-test - переключение в dtnre dev-test, но если такой ветки нет то -b создаст такую ветку
37. ssh-keygen - генратор ключа SSH
38. git clone [git@github.com](mailto:git@github.com):Sleem28/project.git - клонирование репозитория на ПК
39. git push -u origin dev - копируем репо с ПК на GitHub
40. git pull - копируем изменения с Хаба