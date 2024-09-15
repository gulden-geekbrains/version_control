## Работа с удалённым репозиторием

### Переносим репозиторий с GH 
```sh
git clone [URL]
dir or ls
cd /...
git status
git log --oneline
git log --oneline --graph
```
// просмотри
```sh
echo "# name" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin [URL]
git remote show 
git remote show -v 
```
**совершаем некие действия с нужным файлом**
```sh 
git push -u origin main   [толкаем файл на GH с local на удаленный]
git remote -v  (посмотреть какие репозитории есть)
git remote show origin (более подробная инфа по репозиторию)
```
## Редактируем файл с помощью браузера 
//заходим в GH и делаем все необходимое 
так же можем оставить commit 
переходим в git bash 
```sh
git pull (запрос изменений с удаленного на local)
git log
git push (отправляем с local на удаленный в GH)
```
## Создаем новую ветку и вытолкаем ее на сервер
```sh
git branch [NAME]
git checkout [NAME]

//вносим изменения в ветке
//сохраняем + commit

git push
//используем подсказку

git push origin --delete [NAME] если нужно удалить ненужную ветку с удаленного репозитория
```

## Конфликт 
//вносим изменения отдельно в local и отдельно в удаленный репозиторий 
```sh
git pull --rebase (скачиваем все и мержим local и удаленку)
**некий конфликт** 
git add
git status
git rebase --continue
git push
```
## Pull requests