# подсказки по командной строке

Создание репозитории
```sh
git init
```

Добавить файл в отслеживаемый
```sh
git add <filename>
```

Сделать коммит
```sh
git commit -m "message"
```

команда смены дируктории
```sh
cd c:\folder_name
```

команда отображения текущей дируктории
```sh
pwd
```

листинг текущей директории

Windows:
```sh
dir
```
MacOs, Linux:
```sh
ls
```

Удаление файла

Windows:
```sh
del <filename>
```
MacOs, Linux:
```sh
rm <filename>
```

Разница между файлами, коммитами ...
```sh
diff 
```

Чтобы увидеть все коммиты ...
```sh
git log
```

Чтобы увидеть все коммиты во всех ветках...
```sh
git log --graph
```

Просмотр всех веток
```sh
git branch
```

добавить новую ветку <name>
```sh
git branch <name>
```

Чтобы слить ветки, нужно перейти на Главную ветку (Master) и набрать команду
```sh
git merge <branchName>
```
Переход с одной ветки на другую
```sh
git checkout <branchName>
```

Удаление ветки
```sh
git branch -d <branchName>
```