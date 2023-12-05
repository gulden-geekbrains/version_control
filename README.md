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

# Инструкция по работе с удаленными репозиториями

1. Для начала нужна клонировать репозиторий с GitHub.
2. Далее нам нужно добавить репозиторий для работы - cd имя папки.
3. Затем внести изменения.
4. Далее что-бы выгрузить в локальный репозиторий, мы используем команду "git push"
5. Для выгрузки на репозитория, мы используем команду "git pull"

# Инструкция по основным командам GIT

1. Для начала работы с какой либо папкой - git init
2. Для просмотра статуса репозитория - git status
3. После каких либо изменений мы можем закоммитить, для сохранения процесса - git commit -m "Текст"
4. Для просмотра веток - git branch
5. Для создания веток - git branch название ветки
6. Для перехода на другую ветку - git checkout название ветки
