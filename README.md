## Инструкция по работе с GIT

## Добавление имени
```sh
git config --global user.name "Alex"
```
## Добавление email
```sh
git config --global user.email ipzhbankov@yandex.ru
```
## Добавление конфигурации
```sh
git config --list
```
## Инициализация
```sh
git init
```
## Статус 
```sh
git status
```
## Индексирование
```sh
git add .\имя файла
```
## Сохраненлие изменения
```sh
git commit -m "название сохранения"
```
## Создание новых веток
```sh
git branch -m "имя ветки"
```
## Стягивание всех изменений из удаленного репозитория
```sh
git pull
```
## Отправление всех изменений в удаленный репозиторий
```sh
git pull
```
## Локальная копия удаленного репозитория
```sh
git clone
```
## Предложений изменений кода в чужом репозитории
```sh
pull request
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
Add some text

Вот видео инструкция https://youtu.be/E8cIjbJMEpE


