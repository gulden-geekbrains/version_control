# Подсказки по Git
## Гитхаки в работе** 
1. Стрелочками переключаем предыдущие команды
2. Через TAB дописываем название файлов и команды
## Команды 
Первичная настройка гита для командной работы
```sh
git config --global user.name "write_name"
git config --global email.name "write_email"
```
Создаем каталог в котором будем работать
```sh
mkdir <name_folder>
```
Создаем файл в VSCODE и заходим в созданную директорию
```sh
create new file with extension.
cd ~/Desktop/path_to_folder
```
Инициализируем git
```sh
git init
```

Написали новый код или видоизменили его, добавляем файл в git
```sh
git add <file_name>
```

Делаем сохранение коммита с текущими комментариями
```sh
git commit -m "message"
```

Отображение коммитов, переключаем стрелочками
```sh
git log
```
Коммиты одной строкой
```sh
git log --oneline 
```

Переключение на другой коммит
```sh
git checkout <номер_коммита>
```

Вернуться к текущему коммиту
```sh
git checkout main
```
Чтобы игнорировать файлы создаем файл .gitignore или создаем через VSCODE
```sh
nano .gitignore
.DS_Store
etc
```

Посмотреть последние изменения коммита
```sh
git diff <commit_number>
```


## Ветки

Ветки нужны для разных задач, для написания другого кода внутри программы. Также их можно использовать как черновик.

Создание новой ветки
```sh
git branch <name_branch>
```
Отображение всех веток
```sh
git branch 
```
Переключение между ветками 
```sh
git checkout <branch_name>
```
Слияние файлов. Вызывается оттуда - куда хотим добавить.
```sh
git merge <branch_name>
```
Удаление ветки
```sh
git branch -d <name_branch>
```
Графическое представление commits
```sh
git log --graph
```
еще одна команда графического представления
```sh
git log --oneline --graph
```

# Работа с удаленными репозиториями, форки
Клонирование другого репозитория
```sh
git clone <https_link_from_github>
```
Стянуть изменения с гитхаба на локальный компьютер, pull составная команда, сразу делает merge.
```sh
git pull
```
Загрузить в гитхаб с локального компьютера
```sh
git push
```
Форк репо с последующими pull&requests 
```sh
Заходим в репозиторий проекта, делаем fork, делаем git clone со своего аккаунта, cd to name, git branch new и начинаем воркать, затем делаем git push, pull & request 
```
## Еще instruction 
1. Нажать fork 
2. Сделать git clone
3. cd папка проекта
4. создать ветку git branch <name>, перейти в нее
5. начать воркать 
6. Сделать git push с новой ветки
7. Сделать pull & request

Узнать в каком удаленном репозитории лежит программа 
```sh
git remote -v 
```
## Команды Linux

list - список файлов и папок в текущей директории

```sh
ls 
```
Print working directory - показать путь текущей директории
```sh
pwd 
```
Создать папку
```sh
mkdir <name_folder>
```
Clear - очистить workspace in terminal
```sh
mkdir <name_folder>
```

### Other Notes
Редактировать код можно внтури Github

Pull & request - запрос на вливание изменений в репо. Для командной работы. Для коммитов и контрибьютов в проекты. 
 
 В гит фотки не кладем.

