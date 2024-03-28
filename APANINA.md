# Подсказка по GIT
![Logotip git](https://i.pinimg.com/originals/a0/c0/bc/a0c0bcdfeedf076ee4d6d4ccc437d169.png)

<div style='text-align: justify;'>

**Git** - это распределенная система управления версиями, которая устанавливается на машину, где будет вестись работа над проектом.

Скачать данную программу можно по [ссылке](https://git-scm.com/downloads)
</div>

## Создание репозитория:
```sh
git init

Инициализация или создание репозитория производится командой git init в директории проекта.
```
```sh
git add

Добавить все файлы и подкаталоги проекта в индекс можно командой git add., затем командой git status можно посмотреть, какие файлы и изменения подготовлены для коммита
```
```sh
git commit -m "Message text"

Добавление изменений в репозиторий. Зафиксировать заметку
```
```sh
git log

Показывает все коммиты от новых к старым
```
```sh
git log --oneline

Вывод коммитов в одну строку. Показывает только хэш коммита и commit message
```
```sh

git checkout <имя_ветки>


Отвечает за переключение между отдельными ветками репозитория.
```

```sh
git merge

Данная команда выполняет слияние отдельных направлений разработки, созданных с помощью команды git branch, в единую ветку.
```

```sh
git branch

Отображение всех веток
```

```sh
git branch <имя_ветки>

Создание новой ветки
```

```sh
git branch -d <имя ветки>

Удаление ветки
```

```sh
git log --oneline --graph

Данный параметр выводит дерево зависимостей для всех коммитов
```

# Это репозиторий pull request

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
# Как подружить git с github под Windows 10

Вот видео инструкция https://youtu.be/E8cIjbJMEpE
