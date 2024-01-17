# Подсказка по GIT

Переход в директорию с проектом:
```sh
cd <путь до папки>
``` 
Инициализируем проект:
```
 git init
```
Проверяем commit и статус:
```sh 
git status
```
Для добавления файла 
```sh
git add <имя файла>
```
Для сохранения изменений
```sh
 git commit -m "Massage"
```
Показать историю commit 
```sh
git log
```
Показать историю commit списком (удобно) 
```sh
git log –oneline
```
Переключится на другой commit
```sh
 git checkout index
```  
Вернуться на самый последний commit 
```sh
git checkout master
```
Не сохранять изменения
```sh
git restore <filename>
git stage <filename>
```
Показать отличие текущего файла и последнего commit 
```sh
git diff
```
Показать разницу одного или нескольких коммитов
```sh
git diff index
git diff index index
```

Перенести в ветку:
```sh
git merge <ветка>
```

Отображение всех веток
```sh
git branch
```

Переключение между ветками текст
```sh
git branch <ветка>
```

Создание новой ветки
```sh
git branch <существующая ветка>
```

Переименовать основную ветку в main
```sh
git branch -M main
```

## Работа с GitHub

Указать удаленный репозиторий
```sh
git remote add origin <ссылка>
```

Клонировать удалённый репозиторий
```sh
git clone <ссылка>
```

Скачать изменения с удалённого репозитория
```sh
git pull
```

Скачать изменения с удаленного репозитория и постараться слить
```sh
git pull --rebase
```

Передать изменения на сервер
```sh
git push
```

Передать все изменения на сервер, ветка main
```sh
git push -u origin main
```

Посмотреть какой удалённый репозиторий привязан к нашему локальному
```sh
git remote -v
```

Подробные сведенья про удалённый репозиторий
```sh
git remote show origin
```

Толкнуть новую ветку на сервер
```sh
git push --set-upstream origin <имя ветки>
```

Удалить ветку с сервера
```sh
git push origin <ветка>
```
