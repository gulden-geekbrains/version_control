# Подсказка по гиту

## Инициализация репозитория

```sh
git init
```

## Статус репозитория

```sh
git status
```

# Команды  Git

## Работа с репозиторием

### Инициализация репозитория
```sh
git init
```
### Добавление файлов под версионный контроль
```sh
git git add <file>
```
### Добавление всех файлов под версионный контроль
```sh
git add .
```
### Фиксация изменений
```sh
git commit
```
### Игнорирование индексации
```sh
git commit -a -m "comment"
```
### Изменение последнего коммита
```sh
git commit --amend
```
### Клонирование удаленного репозитория
```sh
git clone <remote>
```
### Клонирование удаленного репозитория в указанный каталог
```sh
git clone  <remote> <dir>
```
### Определение состояния файлов
```sh
git status
```
### Просмотр измененных, но не проиндексированных файлов
```sh
git diff
```
### Просмотр проиндексированных файлов, которые войдут в следующий коммит
```sh
git diff --staged
```
### Удаление файла с индексацией
```sh
git rm <file>
```
### Удаление файла из индекса (при этом файл остается в рабочем каталоге)
```sh
git rm --cached <file>
```
### Перемещение файлов
```sh
git mv <old file> <new file>
```
### Просмотр истории коммитов
```sh
git log
```
### Отмена индексации файла
```sh
git reset HEAD <file>
```
### Отмена изменений файла
```sh
git checkout -- <file>
```

## Ветвление

### Показ существующих веток
```sh
git branch
```
### Создание новой ветки
```sh
git branch <branch>
```
### Удаление ветки
```sh
git -d <branch>
```
### Просмотр последнего коммита на каждой из веток
```sh
git branch -v
```
### Просмотр веток, для которых выполнено слияние
```sh
git branch --merged
```
### Просмотр веток, для которых не выполнено слияние
```sh
git branch --no-merged
```
### Принудительное удаление  ветки
```sh
git branch -D <branch>
```
### Создание новой ветки из ветки на удаленном сервере
```sh
git branch --track <branch> <remote branch>
```
###  Переход на ветку
```sh
git checkout <branch>
```
### Создание ветки с переходом на нее
```sh
git checkout -b <branch>
```
### Слияние веток
```sh
git merge <branch>
```
### Запуск графического инструмента для разрешения конфликтов
```sh
git mergetool
```
### Отправка ветки на удаленный сервер
```sh
git push <remote> <branch>
```
### Удаление ветки на удаленном сервере
```sh
git push <remote> :<branch>
```

## Работа с метками

### Просмотр меток
```sh
git tag
```
### Созданиае аннотированных меток
```sh
git tag -a <tag> -m "comment"
```
### Создание легковесной метки
```sh
git tag <tag>
```
### Выставление меток позже
```sh
git tag -a <tag> <hash>
```
### Просмотр данных метки вместе с коммитом
```sh
git show <tag>
```
### Обмен метками
```sh
git push <remote> <tag>
```
### Отправка всех меток за один раз
```sh
git push <remote> --tags
```

## Работа с удаленным репозиторием

### Отображение удаленных репозиториев
```sh
git remote
```
### Добавление удаленных репозиториев
```sh
git remote add <alias> <remote>
```
### Информация об удаленном репозитории
```sh
git remote show <remote>
```
### Переименовывание удаленных репозиториев
```sh
git remote  rename <old name> <new name>
```
### Удаление удаленных репозиториев
```sh
git remote rm <remote>
```
### Получение данных из удаленных репозиториев
```sh
git fetch <remote>
```
### Получение данных из удаленного репозитория и слияние с локальным
```sh
git pull <remote> <branch>
```
### Отправление локальных изменений на удаленный сервер
```sh
git push <remote> <branch>
```

## Конфигурация

### Имя пользователя
```sh
git config --global user.name "Firstname Lastname"
```
### Адрес электронной почты пользователя
```sh
git config --global user.email mail@example.com
```
### Выбор редактора
```sh
git config --global core.editor emacs
```
### Утилита сравнения
```sh
git config --global merge.tool vimdiff
```
### Пофайловое отображение изменений
```sh
git config --global status.showUntrackedFiles all
```
### Создание псевдонимов для команд
```sh
git config alias.<alias> <command>
```
### Проверка настроек
```sh
git config --list
```