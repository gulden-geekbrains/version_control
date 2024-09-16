# Подсказка по Git

## 1. Инициализация репозитория
В терминале переходим к папке, в которой хотим создать репозиторий. Выполняем команду 

```sh
git init
``` 
 В исходной папке появиться файл
 
 *.git*
 
 ## 2. Запись изменений в репозитарий

Для того чтобы посмотреть текущее состояние гита, определить есть ли изменения, которые нужно закоммитить применяем команду

```sh
git status
```
Чтобы добавить содержимое рабочего каталога
в индекс (staging area) для последующего коммита, применяем
 
 ```sh
 git add <имя файла>
```

 Фиксируем изменения с помощью команды

 ```sh
 git commit -m "комментарии"
 ```

## 3. Журнал изменений и переключение между версиями

Посмотреть журнал изменений можно используя команду

```sh
git log
```

Переключение между версиями.

```sh
git checkout <номер коммита>
```

Вернуться в коммит, в котором работаем

```sh
git checkout master
```

Посмотреть разницу между текущим файлом
и сохранённым
 
```sh
git diff
```

Посмотреть лог в полном виде
```sh
git log
```
Посмотреть лог в сокращенном виде
```sh
git log --oneline
```
Создание ветки 
```sh
git branch <имя_ветки>
```
Перемещение по веткам
```sh
git checkout <имя_ветки>
```
Отображение всех веток
```sh
git branch
```
Удалить ветку
```sh
git branch -d <имя_ветки>
```
Слияние веток (из ветки master)
```sh
git merge <имя_ветки>
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
# Как подружить git с github под Windows 10

Вот видео инструкция https://youtu.be/E8cIjbJMEpE


