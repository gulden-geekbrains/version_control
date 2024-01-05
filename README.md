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

## Дополнение к инструкции

### Основные команды Git для работы с ветками репозитория

> git branch **<branch_name>** - создать новую ветку с именем branch_name

> **git checkout  -b <branch_name>** - создание ветки и переход к ней

> **git commit -am “message”** – добавление файлов в отслеживание и       создание коммита.
> **git log --graph** - вывод на экран истории всех коммитов с их хеш-кодами в древовидной форме

### Основные команды Git для работы с удалёнными репозиториями

> **git clone <url-адрес репозитория>** – клонирование внешнего репозитория на  локальный ПК

> **git pull** – получение изменений и слияние с локальной версией

> **git push** – отправляет локальную версию репозитория на внешний
## Как происходит удалённая работа с репозиториями?

1. Для начала нам нужно зарегистрироваться на сайте __GitHub.com.__
2. После регистрации мы через (+) создаём __New repository.__
3. Во вкладке __Repository name__ придумываем имя своему репозиторию и жмём __Create repository.__
4. После чего заходим в свой проект и в терменале прописываем следующие коменды:
* git remote add origin (ссылка на репозиторий)
* git branch -m main - указываем основную ветку.
* git push -u origin main - выгружаем проект на GitHub.
5. Теперь во вкладке __Code__ мы всегда можем скопировать ссылку на него, если он нам понадобиться.
6. Скопированную ссылку мы добавляем в свой проект командой __Git clone (ссылка на репозиторий).__
7. Для работы с другими проектами, нам нужно сначала добавить их к нам в аккаунт GitHub, а уже после этого и добавить в свой проект командой __Git clone (ссылка на репозиторий, без скобок).__