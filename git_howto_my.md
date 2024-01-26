# Основные команды Git 

## Команды Git для работы в локальном репозитории

* Выведение версии git-a на экран

        git --version

* Инициализация локального репозитория

        git init
* Информация от  git  о его текущем состоянии

        git status
* Команда, которая занесет в конфигурационный файл имя и емайл

        git config --global user. name "User Name"
        git config --global user. email "useremail"


* Добавление (индексация) файла подготовка для коммита

        git add <falename>
* Фиксация изменений в файле

        git commit -m "mesage schimbari"
* Индексация и фиксация одновременно

        git commit -am "mesage schimbari"
* Вывод на экран истории всех коммитов с их хеш-кодами

        git log\ git log --oneline\ git log --oneline --all      
* Переход от одного коммита к другому

        git checkout <hash-cod>
* Переход к актуальному состоянию 
        
        git checkout master
* Разница вежду текущим файлом и закоммиченным, используется сразу после сохранения, до того как мы его индексируем

        git diff 

Второй вариант, смотрим разницу между хеш-кодами после команды git log

        git diff hash_cod_1 hash_cod_n
* Удаление изменений в файле
       
        git restore <file>

*  Вывод списка веток в репозитории

        git branch
* Создание новой ветки

        git branch <new_branch_name>
* Удаление ветки

        git branch -d
* Переход с одной ветки на другую

        git checkout <branch_name>
* Слияние веток

        git ceckout <main(home)_branch>

         git merge <new_branch_name>
* Вывод на экран списка коммитов c их хеш-кодами по веткам

        git log --graph
        git log --oneline --graph
* Переименование репозитория

        git branch -M <name_branch>
## Основные команды  работы с удаленными репозиториями, команды  слияния локальных и удаленных репозиториев и работы в них
* Скачивание файла из GitHub, что бы они стали файлами локального репозитория

        git clone <address din github>
* Устанавливается удаленный ркпозиторий в качестве репозитория по умолчанию

        git remote add origin http://github.com/inagrigor/<name_repo>.git
* Демонстрация удаленного репозитория

        git remote show
* Выталкивание всех изменений в удаленный репозиторий <origin - удаленный>

        git push -u origin main 
* Удаление ветки в удаленном репозитории

        git push origin --delete <name_branch>
* Скачивание и 

* Скачивание всех изьенений из удаленого репозиториия и слив их с текущей веткой

        git pull /   git pull --rebase
* Cоздание и переход в новую ветку
 
        git checkout -b <name_branch>
*  Демонстрация привязаного репозитория

        git remote -v / git remote show origin

