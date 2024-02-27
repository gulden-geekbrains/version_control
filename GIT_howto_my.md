# Подсказка по GIT

Создание репозитория:
```sh
git init
```

Индексация файла:
```sh
git add <filename>
```

Добавление коммита:
```sh
git commit -m "Message"
```

Вывод логов (коммитов):
```sh
git log
```

Вывод коротких логов (коммитов):
```sh
git log --oneline
```

Вывод логов (коммитов) графически:
```sh
git log --graph
```

Вывод коротких логов (коммитов) графически:
```sh
git log --oneline --graph
```

Переход к коммиту с номером commit code:
```sh
git checkout <commit_code>
```

Просмотр текущего состояния:
```sh
git status
```

Проcмотр различия между текущим и выбранным коммитами:
```sh
git diff <commit_code>
```

Отображение всех веток:
```sh
git branch
```

Создать новую ветку branch_name:
```sh
git branch <branch_name>
```

Переход к ветке с именем branch_name (master):
```sh
git checkout <branch_name>
```

Слить ветку branch_name с текущей веткой:
```sh
git merge <branch_name>
```

Удалить ветку branch_name:
```sh
git branch -d <branch_name>
```

Переименовать ветку:
```sh
git branch -M <name>
```

Клонировать удаленный репозиторий на ПК:
```sh
git clone <url>
```

Получить изменения и слить удаленный и локальный репозитории:
```sh
git pull
```

Разрешить конфликт локального и удаленного репозиториев:
```sh
git pull --rebase
```

Отправить локальную версию репозитория на удаленный:
```sh
git push
```

Просмотр удаленных репозиториев для записи (push) и чтения (fetch):
```sh
git remote show
git remote -v
```