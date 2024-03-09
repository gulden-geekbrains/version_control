# Подсказка по GIT

Создание репозитория:
```sh
git init
```

Добавить файл к индексации:
```sh
git add
```

Зафиксировать изменения
```sh
git commit -m "Message"
```

Посмотреть лог в полном виде:
```sh
git log
```

Посмотреть лог в сокращенном виде:
```sh
git log --oneline
```

Перемещение по веткам:
```sh
git checkout <branch_name>
```


Удаление ветки:
```sh
git branch -d <branch_name>
```

Создание новой ветки:
```sh
git branch <branch_name>
```

Отображение всех веток:
```sh
git branch
```

Отображения логово в виде дерева:
```sh
git log --graph
```

Объединение двух веток:
```sh
git merge <branch_name>
```

Просмотр разницы между двумя ветками:
```sh
git diff main <another_branch>
```