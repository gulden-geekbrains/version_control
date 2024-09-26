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

## Отправка локального репозитория на GitHub
|Команда|Значение|
|:----------------------------|:----------------------------------------|
|git remote add origin ссылка на репозиторий в GitHub|Добавление удалённого репозитория|
|git branch -M main|Назначение мастер-ветки|
|git push -u origin main|Отправить свой репозиторий на GitHub|

# Pull request
1. Делаем форк (Fork) интересующего нас репозитория
2. Делаем git clone для нашей версии этого репозитория
3. Создаём ветку с предлагаемыми изменениями. Производим все изменения только в этой ветке
5. Отправляем эти изменения на свой аккаунт
6. В окне на гитхаб появляется возможность отправить pull request

# Заметки
* Fork — удаленная копия репозитория на сервере, отличная от оригинала.
* Clone — это не то же самое, что и fork. Клон удаленного репозитория располагается локально. Фактически при клонировании копируются все данные, включая историю коммитов и существующие ветки.
