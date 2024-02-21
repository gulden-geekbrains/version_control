# TIPS FOR GIT

## Начало работы с git

Команда смены директории
```sh
cd c:\folder_name
```
Команда отображения текущей директории MacOs/Linux
```sh
pwd
```
Листинг текущей директории  
* Windows
```sh
dir
```
* MacOs/Linux
```sh
ls
```
## Создание репозитория
Команда инициализации
```sh
git init
```
Команда просмотра статуса репозитория
```sh
git status
```
## Редактирование репозитория
*Инициализация файла или его добавление к отслеживанию обязательно перед коммитом. **Но сначала файл необходимо сохранить***

Добавить файл к отслеживанию
```sh
git add <filename>
```
Команда коммита или сохранения версии файла с добавлением комментария 
```sh
git commit -m "message text"
```
Удалить или стереть файл 
* MacOs/Linux
```sh
rm <filename>
```
* Windows
```sh
del <filename>
```
## Просмотр истории изменений 

Просмотреть зафиксированные коммиты *(чтобы покинуть просмотр, нужно нажать Q)*
```sh
git log 
```
Просмотреть вкратце зафиксированные коммиты
```sh
git log --oneline
```
Посмотреть скрытые (из-за количества) коммиты вкратце
```sh
git log --oneline --graph
```
Переключиться на определенную версию
```sh
git checkout <commitcode>
```
Переключиться на  самое последнее состояние
```sh
git checkout master
```
Посмотреть отличия коммитов
```sh
git diff <commitcode1> <commitcode2>
```

## Работа с ветками
Отобразить все ветки
```sh
git branch
```
Создать новую ветку 
```sh
git branch <branch_name> (example git branch new_branch)
```
Переключиться на ветку 
```sh
git checkout <branch_name>
```
Слить новую ветку с веткой мастер *(при этом обязательно необходимо находиться в ветке master)*
```sh
git merge <branch_name>
```
При сливании веток может произойти конфликт, который можно разрешить вручную, сохранить и закоммитить или принять изменения. Изменения без конфликта сливаются в ветку мастер автоматически. Если открывается редактор, то можно нажать escape  и затем  shift :Q

Удалить ветку
```sh
git branch -d branch_name
```

## Работа с удаленными репозиториями 

Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория 
```sh
https://git@github.com:account-name/folder-name.git
```
Выполняем команду клонирования из своей fork-копии
```sh
git clone git@github.com:*MY_GITHUB*/folder-name.git
```
Делаем push и публикуем данные в браузере
```sh
git push 
```
Делаем pull и тянем изменения из браузера в локальный репозиторий
```sh
git pull
```

При создании репозитория в браузере, можно использовать инструкцию в самом гите

> create a new repository on the command line
>>echo "# smth" >> README.md
>>git init
>>git add README.md
>>git commit -m "first commit"
>>git branch -M main
>>git remote add origin https://github.com/viktory7se/smth.git
>>git push -u origin main

>…or push an existing repository from the command line
>>git remote add origin https://github.com/viktory7se/smth.git
>>git branch -M main
>>git push -u origin main