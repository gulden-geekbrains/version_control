# Команды

## Общие команды

```sh
Инициализация репозитория
git init
```

```sh
Войти в папку
cd <folder name>
```

```sh
Поднятся в директорию уровня выше
cd ..
```

```sh
Создать директорию
mkdir <directory_name>
```

```sh
Статус репозитория
git status
```

```sh
Реестр коммитов
git log 
```

```sh
Реестр коммитов кратко
git log --oneline
```

```sh
Реестр коммитов кратко с ветвлением
git log --oneline --graph
```

```sh
Вывод имеющихся веток
git branch
```

## Команды сохранения

```sh
Добавение файла
git add <file_name>
```

```sh
Утверждение изменения
git commit -m "commit information"
```

## Команды изменения

```sh
Удаление ветки
git branch -d <branch_name>
```

## Команды слияния

```sh
Слияние веток
git merge <branch_name>
```

## Работа с репозиториями

```sh
Эта команда используется для просмотра подключенных удаленных репозиториев
git remote -v 
```

```sh
Более подробная информация о репозиториях
git remote show origin
```

```sh
Удаляет ветку удаленно с гитхаба
git push origin --delete <branch_name>
```

```sh
Команда скачивания всех изменений с сервера и их слияния
git pull --rebase
```


# Это репозиторий для обучения pull request

## Первые шаги

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория <https://git@github.com:gulden-geekbrains/version_control.git>
2. Выполняем команду клонирования из своей fork-копии
```sh
git clone git@github.com:*YOURE_GITHUB*/version_control.git
```
3. Создаем новую ветку и вносим необходимые изменения в файл
```sh
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```
4. Делаем push  
```sh
git push --set-upstream origin updatereadme
```
5. Переходим на свою страницу репозитория. Выбираем ветку **updatereadme** и жмем кнопку **Compare & pull request**

## Заметки

Что бы сделать push от другого пользователя необходимо выполнить команду
```sh
GIT_SSH_COMMAND='ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes' git push git@github.com:gulden-geekbrains/version_control.git
```

вместо *user-private-key* подставьте свой ключ

Можно прописать настройки для подсоединения по ssh
```sh
git config remote.origin.url git@github.com:gitusername/reponame
git config core.sshCommand "ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes"
```
## Как подружить git с github под Windows 10

Вот видео инструкция https://youtu.be/E8cIjbJMEpE


# Инструкция по языку MarkDown

Новая строка - это олна пустая строка

**Полужирный текст**

*Курсив текст*

## Цитирование
> Первый уровень
>> Второй уровень

## Списки
### Ненумерованные списки
* Лист 1
* Лист 2
### Нумерованные списки
1. Лист 1
2. Лист 2
3. Лист 3

## WEB ссылки
Текст [пример ссылки](http.example.com "Всплывающая подсказка")

## Работа с таблицами

Буква | Цифра | Символ
------ | ------|----------
a      | 4     | $
x      | 365    | (
b      |       | ^  

Буква|Цифра|Символ
---|---|---
a|4|$
 |365|(
b| |^  

Column | Column
------ | ------
\| Cell \|| \| Cell \|  


Column | Column | Column
:----- | :----: | -----:
Left   | Center | Right
align  | align  | align

## Картинки

### Это яблоко

![apple](apple.jpg)

### Это апельсин

![orange](orange.png)