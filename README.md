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

# Инструкция по github

1. регистрируемся в github

2. находим у другого пользователя репозиторий, который необходимо скачать

3. fork

4. создаем локальную папку

5. указываем в git путь к папке cd ~

6. создаем файл git_init.md, в который будем сохранять инструкцию по изменению репозитория в github

7. скачиваем в рабочую папку репозиторий github - git clone 

8. следуем инструкциям на сайте github

9. меняем название главной локальной ветки на main git branch -M main

10. устанавливаем удаленный репозиторий по умолчанию git remote add origin <URL>

11. проверяем путь от/к удаленному репозиторию git remote -v

12. завершаем создание инструкции save - git add <file.md> - git commit -m ""

завершили!

