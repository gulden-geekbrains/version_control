# Подсказки по Git

## Проверка

Проверить, что Git установлен и отвечает на команды.

Выполнить команду:
```bash
git --version
```

Если все нормально работает в ответ получим версию программы
```bash
git version 2.31.1.windows.1
```

## Настройки Git

После установки необходимо «представиться» системе контроля версий Git. 
Это нужно сделать всего один раз, и Git запомнит вас.

#### Для этого нужно ввести в терминале 2 команды:

##### 1. Установим имя пользователя, которым будут подписаны коммиты
Выполнить команду:
```bash
# Вместо <ваше_имя> можно ввести, например, Vasya Pupkin
# Кавычки оставляем
git config --global user.name «Ваше имя англ буквами»
```

##### 2. Установим электронную почту, которая будет отображаться в описании коммита.
Выполнить команду:
```bash
# Вместо <ваша почта@example.com> можно ввести, например, pupkin@company.com
# Кавычки оставляем
git config --global user.email «ваша почта@example.com»
```

#### Проверить/посмотреть имя или электронную почту

```bash
# Проверить/посмотреть, имя:
git config user.name

# Проверить/посмотреть, электронную почту:
git config user.email
```

#### Совет с просторов интернет для ОС Windows:

```bash
# Включить преобразование окончаний строк из CRLF в LF:
git config --global core.autocrlf true 
```

## Создание локального репозитория

#### 1. Запускаем установленный "GitBash"

#### 2. Создаем папку проекта 

Например создадим папку проекта с названием `02_lab`

Выполнить команду: 
```bash
mkdir '/m/KURSES/[GB]_Нейрохищник/GIT/02/02_lab/'
```
#### 3. Перейти в папку проекта

Выполнить команду: 
```bash
cd '/m/KURSES/[GB]_Нейрохищник/GIT/02/02_lab/'
```

#### 4. Инициализируем локальный репозиторий

> **Репозиторий** — это все файлы, находящиеся под контролем версий, вместе с историей их изменения и другой служебной информацией.
> 
> Репозиторий Git можно создать, либо выбрав любую папку на компьютере, либо клонировав себе уже существующий репозиторий, например у работодателя.

Создаем репозиторий Git из папки проекта `02_lab`, для этого

Выполнить команду: 
```bash
git init 
```
По итогу создаётся скрытая папка `.git` в которой Git хранит всю информацию о данном репозитории и Git начнёт отслеживать изменения в папке проекта `02_lab`. 


## Указание неотслеживаемых файлов

Файлы и каталоги, которые не нужно включать в репозиторий, указываются в файле `.gitignore`. Обычно это устанавливаемые зависимости (`node_modules/`, `bower_components/`), готовая сборка `build/` или `dist/` и подобные файлы, создаваемые при установке или запуске. Каждый файл или директория указываются с новой строки.

Пример файла:
```bash
.gitignore
.DS_Store
```

.gitignore - можно игнорировать индексацию самого файла `.gitignore`

.DS_Store - папка создается в ОС Mac


## Создание коммитов

### git status
Для того, чтобы получить информацию от git о его текущем состоянии.
Показывает текущее состояние Git, есть ли изменения, которые нужно закоммитить (сохранить).

Команду выполнять находясь в корне папке репозитория.

Выполнить команду: 
```bash
git status 
```
Вы увидите были ли изменения в файлах проекта, или их не было.

#### Пример:
##### Создадим файл "hello world.md"

##### Проверим стату репозитория
Выполнить команду: 
```bash
git status 
```
Результат: 
```bash
No commits yet # нет commit, и ничего не зафиксировано
```

### git add
Добавляет содержимое рабочего каталога в staging area (index) в Git для последующего коммита. 

(Добавляет файлу версионность в локальном репозитории.)

Эта команда выполняется после добавления файлов. 

Выполнить команду: 
```bash
git add <имя файла>
```

#### Пример:
Добавить файл `hello world.md` к индексации.

Выполнить команду: 
```bash
git add '.\hello world.md'
```


---
### git commit

Команда `git commit` берёт все данные, добавленные в индекс с помощью `git add`, 
и сохраняет их слепок во внутренней базе данных, 
а затем сдвигает указатель текущей ветки на этот слепок.

Команду `git commit` кратко можно понимать так - зафиксировать или сохранить состояние репозитория. Для создания коммита

Выполнить команду: 
```bash
git commit -m "message"

# git commit - команда
# m "add new file hello world.md" - m - ключ оставить коментарий,
# и "message" - непосредственно сам коментарий в ковычках  
```

#### Пример:
Создадим коммит для указаном выше `git add` для `hello world.md`.

```bash
git commit m "add new file hello world.md"
```

## git log

Журнал изменений, выводит список всех коммитов (сохранений) в хронологическом
порядке.

Перед переключением версии файла в Git используйте команду git log, 
чтобы увидеть количество сохранений

Выполнить команду: 
```bash
git log
```

Результат:
```bash
commit 692a500882a600c7ce9a99ec019f27cd67521418 (HEAD -> master)
Author: Mikhail Tambasov <mail@tambasov.mn>
Date:   Wed Nov 13 05:06:28 2024 +0300

    Добавили новую строку в файл hello world.md

commit 02e64cdb148b03425d0ee684424d549f9236c84a
Author: Mikhail Tambasov <mail@tambasov.mn>
Date:   Wed Nov 13 04:56:45 2024 +0300

    Создали новый файл hello world.md
```

Перемещение по журналу стрелками вверх, вниз на клавиатуре.

Выход - кнопка `q`

## git log --oneline

Выполнить команду: 
```bash
git log --oneline
```
Результат:
```bash
e69de44 (HEAD -> master) test old file delete
0f3f025 test rename file 04
706fa74 added design to Markdown and a couple of blocks
a710521 test rename file 02
98f6308 test rename file 01
ef30b16 added design to Markdown and a couple of blocks
2b74dff test del file hallo world.md
119d8ff test rename files 2
1a2d44c test rename files
58c4636 added design to Markdown and a couple of blocks
5f84f0f added line web links
2d7ca36 added notes file instruction MarkDown
```
Перемещение по журналу стрелками вверх, вниз на клавиатуре.

Выход - кнопка `q`


## git checkout

Переключение между версиями (коммитами/сохранениями).
Для работы нужно указать не только интересующий вас коммит,
между сохранениями
```bash
git checkout
```

### Пример 1 перемещение по коммитам:

#### 1. Находим нужный коммит в `git log`

Выполнить команду: 
```bash
git log
```

Результат:
```bash
...
commit 6cdccb2d8bc4fc804e6a3a9d5b8f9ed9321443b9 (HEAD -> master)
Author: Mikhail Tambasov <mail@tambasov.mn>
Date:   Tue Nov 26 05:13:33 2024 +0300

    added design to Markdown block git log and rename files

commit e69de44d73d8fd56b33580bb8cffd81ae8db3dfb
Author: Mikhail Tambasov <mail@tambasov.mn>
Date:   Tue Nov 26 04:43:34 2024 +0300

    test old file delete
```

#### 2. Получаем ID нужного коммита
Берем ID нужного коммита, например возьмем коммит:
commit `e69de44d73d8fd56b33580bb8cffd81ae8db3dfb`

Достаточно первых 4х символов !!!
Берем первые 4 символа : `e69d`

#### 3. Перейдем на версию файла

Выполнить команду: 
```bash
git checkout e69d
```

### Пример 2 вернуться на актуальную версию (самая последняя по коммитам):

!!! После того, как поработали - нужно переключиться на АКТУАЛЬНУЮ ВЕРСИЮ ФАЙЛА !!!

Выполнить команду: 
```bash
git checkout master
```

## git diff

Показывает разницу между текущей и уже зафиксированной версией файла.

Понятнее - показывает РАЗНИЦУ между [СОХРАНЕННЫМИ ФАЙЛАМИ ПК] и [СОХРАНЕННЫМИ ФАЙЛАМИ В GIT]. (те можно увидеть, что не записано, или еще не попало в GIT)

Выполнить команду: 
```bash
git diff
```
Если файлы идентичны, то ничего - не отобразится
Если есть разница, то покажится что-то примерно так:

Результат:
```bash
index 493d15a..068160c 100644
--- a/hello_world.md
+++ b/hello_world.md
@@ -17,4 +17,3 @@
 1. Элемент нумерованный
 2. Элемент нумерованный
 3. Элемент нумерованный
```

### Пример 1 Можно сравнивать разницу между двумя коммитами:

Выполнить команду: 
```bash
git diff 692a 02e6
```

### Пример 2 Поиск:

Можно искать например в каком коммит была например изменена какая нить функция (искать по имени функции)


но об этом далее...


## git branch

### git branch - посмотреть список веток
Ветки 

Выполнить команду: 
```bash
git branch
```

Результат:
```bash
# * - показывает в какой ветке находимся/выбрана
* master
```

### git branch - создать новую ветку

Создадим новую ветку `branch text_formating`, как черновик 

Выполнить команду: 
```bash
git branch text_formating
```

Посмотрим ветки

Выполнить команду: 
```bash
git branch
```

Результат:
```bash
* master
  text_formating
```
Ветка добавилась


### git branch - переключиться на другую ветку

Выполнить команду: 
```bash
git checkout text_formating
```

Посмотрим ветки

Выполнить команду: 
```bash
git branch
```

Результат:
```bash
  master
* text_formating
```
Переключились на ветку `branch text_formating`


### git merge - совмещение двух веток

Чтобы слить любую ветку с текущей, вызываем 

Выполнить команду: 
```bash
git merge <имя ветки для слияния с текущей>
```

### git branch - удалить ветку

Удалить ветку с именем `branch_rip`

Выполнить команду: 
```bash
git branch -d branch_rip
```

Посмотрим ветки

Выполнить команду: 
```bash
git branch
```

Результат:
```bash
  master
* text_formating
```

### git log --graph

Тоже самое, что и git log но с визуализацией всех веток позволяет отобразить коммиты в виде дерева.

Выполнить команду: 
```bash
git log --graph
```

Результат:
```bash
* |   commit b4345e4a7758df8e6f5b27df016ce5c88d92526f
|\ \  Merge: dd23e31 f626f2c
| | | Author: Mikhail Tambasov <mail@tambasov.mn>
| | | Date:   Tue Nov 26 14:33:10 2024 +0300
| | |
| | |     Merge branch 'text_formating'
| | |
| * | commit f626f2c2382031f0334707b7534e6144ceb3d7c1
| |/  Author: Mikhail Tambasov <mail@tambasov.mn>
| |   Date:   Tue Nov 26 14:31:53 2024 +0300
| |
| |       added some text in README.md
```

# Git Hub

## Зарегистрироваться на GitHub

## Создать репозиторий на GitHub

## Подружить репозитории на GitHub и Локальный на ПК

## git clone
Эта команда позволяет склонировать внешний репозиторий на наш ПК.

Узнать ссылку по типу:
https://github.com/ilnar-geekbrains/version_control_lection_3.git

Выполнить команду: 
```bash
git clone https://github.com/ilnar-geekbrains/version_control_lection_3.git
```

## git pull
«стянуть/выкачать» все изменения из удаленного репозитория на свой ПК.
Команда gitpull выкачивает данные из удаленного репозитория и делает merge с локальным репозиторием.

Выполнить команду: 
```bash
git pull
```

## git push
Эта команда позволяет отправить нашу версию репозитория на внешний репозиторий. 
При первом её использовании нужна авторизация на внешнем репозитории.

Нужно :
#### 1. git должен знать адрес удаленного репозитория;

#### 2 git должен быть "авторизован" на внесение изменений в удаленном репозитории 

Выполнить команду: 
```bash
git push
```

## Как сделать pull request

В больших компаниях один ответственный за проект создает аккаунт. 

Другие пользователи дают команду pull request. 
Предлагать изменения на GitHub нужно в отдельной ветке. 

Сначала пользователь копирует репозиторий на свой компьютер, делает fork репозитория, затем клонирует версию на своём ПК, создаёт ветку с предлагаемыми изменениями, отправляет изменения командой push в свой аккаунт на GitHub и даёт команду pull request. 

1. Делаем fork репозитория 
2. Делаем git clone СВОЕЙ версии репозитория 
3. Создаем новую ветку и в НЕЕ вносим свои изменения 
4. Фиксируем изменения (делаем коммиты)
5. Отправляем свою версию в свой GitHub
6. На сайте GitHub нажимаем кнопку pull request


## Заметки

### Пример 1: Если нужно переименовать файл

#### 1. Переименуем файл

Например был файл `Instruction_Markdown2.md`, далее он был переименован в файл `Instruction_Markdown.md`. Проверяем статус `git status`

Выполнить команду: 
```bash
git status
```

Результат:
```bash
On branch master
Changes not staged for commit:
  (use "git add/rm <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        deleted:    Instruction_Markdown2.md

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        Instruction_Markdown.md

no changes added to commit (use "git add" and/or "git commit -a")
```
Показано, что файл `Instruction_Markdown2.md` deleted - удален.

#### 2. Сохраним `новый файл`, для этого выполним `git add` и `git commit`

##### 2.1. git add для нового файла `Instruction_Markdown.md`

Выполнить команду: 
```bash
git add .\Instruction_Markdown.md
```

##### 2.2. git commit для нового файла `Instruction_Markdown.md`

Выполнить команду: 
```bash
git commit -m "test rename file"
```

##### 2.3. Проверяем статус `git status`

Выполнить команду: 
```bash
git status
```
Результат:
```bash
On branch master
Changes not staged for commit:
  (use "git add/rm <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        deleted:    Instruction_Markdown2.md

no changes added to commit (use "git add" and/or "git commit -a")
```

#### 3. Удалим `старый файл`

##### 3.1. Удалим `старый файл` `Instruction_Markdown2.md`
Выполнить команду: 
```bash
git rm '.\Instruction_Markdown2.md'

# Удалим файл из cached
# git rm --cached .\Instruction_CMD.md
```

##### 3.2. git commit для нового файла `Instruction_Markdown2.md`

Выполнить команду: 
```bash
git commit -m "test rename file, del file Instruction_Markdown2.md"
```

##### 3.3. Проверяем статус `git status`

Выполнить команду: 
```bash
git status
```
Результат:
```bash
On branch master
nothing to commit, working tree clean
```

Готово.

---