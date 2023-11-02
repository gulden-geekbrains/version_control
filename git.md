# Комманды Git

Конфигурация не сисстемная только для текущего пользователя
```sh
git config --global user.name "User Name"
git config --global user.email "Email@yandex.ru"
```

Конфигурация на конкретный проект
```sh
git config --local user.name "User Name"
git config --local user.email "Email@yandex.ru"
```

Инициализация нового проекта
```sh
git init
```

Посмотреть текущее состояние
```sh
git status
```

Добавить файл к индексации
```sh
git add <filename>
```

Сделать коммит. Фиксация проиндексированных файлов
```sh
git commit -m "Коментарий"
```

Объединенная команда git add и git commit
```sh
git commit -am "Коментарий"
```

Просмотр коммитов
```sh
git log
```

Укороченное описание коммитов
```sh
git log --oneline
```

Переключение между ветками
```sh
git checkout <commitHash>
```

Отличие измененного не добавленного к индексу файла от последнего закомиченного
```sh
git diff
```

Отмена не добавленного к индексу изменения
```sh
git restore <filename>
```

Исследование содержимого blob (файлов в хранилище объектов, коммитов и деревьев)
```sh
git cat-file -p <hesh>
```

Просмотр содержимого индекса
```sh
git ls-files -s
```

Создать объект дерева из текущего индекса
```sh
git write-tree
```
- вернется хеш, затем по этому хешу можно получить состояние объекта в дереве командой
```sh
find .git/objects
```

Отображение всех веток
```sh
git branch
```

Создание ветки
```sh
git branch <name>
```

Переключение на ветку
```sh
git checkout <name>
```

Создание и переход на новую ветку
```sh
git checkout -b <name>
```
Удаление ветки
```sh
git branch -d <branch_name>
```

Вывод графа (дерева коммитов) на консоль
```sh
git log --graph
```

Ключи (начинаются на --) можно объединять
```sh
git log --oneline --graph
```

Объедининие веток - _**при этом важно перейти на основную ветку и подливать изменения в нее из ветки <branch_name>**_
```sh
git merge <branch_name>
```
