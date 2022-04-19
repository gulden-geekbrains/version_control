# Работа с удаленными репозиториями на примере GitHub

## Это репозиторий для обучения pull request

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория <https://git@github.com:gulden-geekbrains/version_control.git>
2. Выполняем команду клонирования из своей fork-копии в локальную версию файла
```sh
git clone git@github.com:*YOURE_GITHUB*/version_control.git
```
3. Создаем новую ветку и вносим необходимые изменения в файл
```sh
git checkout -b readme_add
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```
4. Выгружаем локальные изменения на GitHub 
```sh
git push --set-upstream origin updatereadme
```
5. Вносим необходмые изменения удаленно через GitHub в данный файл при необходимости. Для этого выбираем **Edit this File**. Затем создаем коммит в текущей ветке или создаем новую ветку и сохраняем коммит **Commit changes**.

6. Подтягиваем изменения в локальную копию файла
```sh
git pull
```
7. Для внесения дополнительных изменений в локальную версию файла повторяем пункты 3-4.

8. Переходим на свою страницу репозитория на GitHub. Выбираем ветку **readme_add** и жмем кнопку **Compare & pull request**

### Заметки

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


