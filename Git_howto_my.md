# Подсказка по GIT

## Команды по GIT

Создание репозитория:
```sh
git init
```

Сохранение текущего состояния объекта
```sh
git add
```

Создание коммита изменения
```sh
git commit -m "Message"
```

Отображение версий репозитория
```sh
git log
```

Отображение версий репозитория кратко
```sh
git log --oneline
```

Возвращение к определённой версии Git
```sh
git checkout
```

Перемещение по веткам
```sh
git checkout <branch_name>
```

Отображение всех веток
```sh
git branch
```

Создание новой ветки
```sh
git branch <branch_name>
```

Слияние веток
```sh
git merge <branch_name>
```

Удаление ветки
```sh
git branch -d <branch_name>
```

Лог графами
```sh
git checkout --graph
```

Создание новой папки
```sh
mkdir <name_folder>
```

Проверка существование репозитория origin
```sh
git remote
```

Перенести изменение в gitHub
```sh
git push
```

Вывести информацию о репозитории на gitHub 
```sh
git remote show origin
```

Запросить изменение с онлайн-репозитория
```sh
git pull
```

Перенести изменение в онлайн-репозиторий и удалить ветку
```sh
git push origin --delete <name_branch> 
```

Клонировать онлайн-репозиторий
```sh
git clone<htttp>
```