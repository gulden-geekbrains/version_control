# Команды по гиту

Создание репозитория
```sh
git init 
```

Посмотреть статус
```sh
git status
```

Добавить в изменения файл
```sh
git add <filename>
```

Добавить коммит 
```sh
git commit -m "сообщение коммита"
```

Посмотреть лог
```sh
git log 
```

Посмотреть лог в одну строку и с графиком веток
```sh
git log --oneline --graph 
```

Переключится к коммиту
```sh
git checkout <commit>
```

Посмотреть разницу изменения
```sh
git diff
```

Посмотреть разницу изменения между 2мя коммитами
```sh
git diff <commit1> <commit2>
```

Отображение всех веток
```sh
git branch
```

Переключится на ветку

```sh
git checkout <branch>
```

Создание новой ветки

```sh
git branch <branch>
```

Удаление ветки

```sh
git branch -d <branch>
```