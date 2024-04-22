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

## Как рабоать с push and pull

1. Создали аккаунт на GitHub.com
2. Создать локальный репозиторий
3. "Подружить" ваш локальный и удалённый репозитории. GitHub при создании нового репозитория подскажет как это можно сделать.
4. Отправить (push) ваш локальный репозиторий в удалённый (на GitHub), при этом вам, возможно, нужно будет авторизоваться на удалённом репозитории.
5. Провести изменения с "Другого компьютера".
6. Выкачать (pull) актуальное состояние с удалённого репозитория.


## Как форкать и вносить изменения в чужой проект

1. Кнопка fork на gitHub, копируем к себе в аккаунт репозиторий.
2. Далее git clone <link>, копируем на компьютер удалённый репозиторий.
3. Создаём отдельную ветку (git branch <branch_name>)
4. Создаём файл README.md
5. Вносим свои предложения в файл README
6. git add + git commit
7. Затем отправляем в свой репозиторий на GitHub
8. И уже со своего аккаунта делаем pull request.
