# Подсказки по командной строке

Команда смены директории:
```sh
cd ~\путь к файлу
```

Команда отображения текущей директории (для MacOs and Linux):
```sh
pwd
```

Листинг текущей директории
Windows:
```sh
dir
```
Linux, MacOs:
```sh
ls
```

Удаление файла в Windows:
```sh
del <filename>
```
в Linux, MacOs:
```sh
rm <filename>
```

Проверка версии git
```sh
git --version
```

Инициализация файла, чтобы git начал работать с этой папкой
```sh
git init
```

Статус работы Git
```sh
git status
```

Фиксация, сохранение текущего файла
```sh
git commit -m "Message"
```

Открыть список всех версий
```sh
git log
```
Показывает ветви сохранений
```sh
git log --graph
```

Показывает сокращенно ветви сохранений
```sh
git log --oneline --graph
```

Открыть сокращенный список всех версий
```sh
git log --oneline
```

Удаление файла на mac, linux / windows
```sh
del <file_name> / rv <file_name>
```

Выход
```sh
q
```

Выбор версии
```sh
git checkout <первые 4 символа>
```

Возврат на актуальную версию
```sh
git checkout master
```

Показывает разницу между текущим файлом и сохранением
```sh
git diff
```

Настройка для всех репозиториев или для одного
```sh
git config global/local
```

Создание репозитория
```sh
cd ~/Путь к файлу
```

Удаляет изменения сделанные в файле безвозвратно
```sh
git restore <file_name>
```

Выводит список всех веток
```sh
git branch
```

Очистить терминал
```sh
clear
```

Создать новую ветку с введенным именем
```sh
git branch <branch_name>
```

Переход на ветку name
```sh
git
```

Слиянение двух веток (присоединяет name branch к текущей)
```sh
git merge <branch_name>
```

Удаление ветки
```sh
git branch -d <branch_name>
```

Выйти из редактора (при слиянии веток иногда появляется редактор)
```sh
esc :wq
```

Скопировать репозиторий с GitHub на комп
```sh
git clone <wed adress>
```

Отправить файл на GitHub
```sh
git push
```

Слияние файла из Github с локальным
```sh
git pull
```

Сохранить изменения с GitHub на компе
```sh
git pull --rebase
```