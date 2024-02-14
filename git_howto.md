# Подсказка по GIT

Создание репозитория:
```sh
git init
```
Добавление изменений в коммит:
```sh
git add
```
Добавление коммита:
```sh
git commit -m "Message_text"
```
Посмотреть все коммиты:
```sh
git log
```
Посмотреть все коммиты в  компактном виде:
```sh
git log --oneline
```
Переключение между коммитами:
```sh
git checkout <имя_ветки>
```

Отображение всех веток:
```sh
git branch
```

Создание новой ветки:
```sh
git branch <имя_ветки>
```

Удаление ветки:
```sh
git branch -d <имя_ветки>
```
## Делаем Pull Request:

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория.
2. Выполняем команду клонирования из своей fork-копии
```sh
git clone git@github.com:*YOURE_GITHUB*/name_repositarium.git
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

5. Переходим на свою страницу репозитория. Выбираем ветку updatereadme и жмем кнопку Compare & pull request
