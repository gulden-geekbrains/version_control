# Подсказка по GIT

1. **Создания Репозитория:**
```sh
git init
```
2. **Добавляет в индекс все файлы независимо от того, в какой директории вы находитесь**
```sh
git add
```
3. **Команда для записи индексированных изменений в репозиторий Git**
```sh
git commit
```
4. **Для просмотра истории коммитов, начиная с самого свежего и уходя к истокам проекта**
```sh
git log
```

5. **Покажет все ваши коммиты только с первой частью хэша**
```sh
git log --oneline
```

6. **позволяет переключаться между последними коммитами**
```sh
git chekout
```

# Репозиторий pull request

## Первые шаги

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория
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
git push --set-исходное обновление для вышестоящего источника
```

5. Переходим на свою страницу репозитория. Выбираем ветку updatereadme и жмем кнопку Compare & pull request

## Заметки

Что бы сделать push от другого пользователя необходимо выполнить команду
```sh
GIT_SSH_COMMAND='ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes' git push git@github.com:gulden-geekbrains/version_control.git
```

вместо <em>user-private-key</em> подставьте свой ключ

Можно прописать настройки для подсоединения по ssh
```sh
git config remote.origin.url git@github.com:gitusername/reponame
git config core.sshCommand "ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes"
```