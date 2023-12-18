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

# Инструкция по работе с Git-ом

> **git init** создание пустого репозитория в выбранной папке.

> **git add .** сохранить все файлы, что были добавлены в репозиторий.

> **git commit -m** создание коммита

> **git log**  вывод на экран истории всех коммитов с их хеш-кодами

> **git checkout** переход от одного коммита к другому.

> **git checkout master** вернуться к актуальному состоянию и продолжить работу.

> **git diff** увидеть разницу между текущим файлом и закоммиченным файлом.

> **git branch** вывести список уже имеющихся весток

![geek](/geek.jpeg)

> **git branch -d <название ветки>** – удалить ветку

> **git branch -D <название ветки>** – удалить ветку без проверки



> **git merge branch_name** эта команда позволяет слить ветки
также возможно создать конфликт

## Когда в разных ветках одна и та же строка написана по-разному возникает конфликт

> **git clone <url-адрес репозитория>** – клонирование внешнего репозитория на локальный ПК

> **git pull** – получение изменений и слияние с локальной версией

> **git push** – отправляет локальную версию репозитория на внешний






