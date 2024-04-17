# Подсказки по командной строке

команда смены директории
```sh
cd c:\folder_name
```

Команда отображения текущей директории
```sh
cd
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

Удаление файла в Windows
```sh
del <filename>
```
в Linux, MacOs:
```sh
rm <filename>
```
Перемещение по веткам
```sh
git checkout
```
 Создание новой ветки
 ```sh
 git branch <filename>
 ```
Переход на новую ветку
```sh
git checkout <filename>
```
Объединение двух веток
```sh
 git merge <filename>
 ```
 Создание одной новой ветки
 ```sh
git branch <имя_ветки>
 ```
 Удаление ветки
 ```sh
git branch -d <filename>
 ```
Выход из редактора win
```sh
esc :wq
```
log в линию
```sh
git log --oneline 
```
стереть ветку
```sh
git log --oneline --graph
```
Копировать репозиторий
```
git clone <filename>
```
Извлечь и загрузить содержимое из удаленного репозитория для обновление локального
```
git pull
```
Передать в удаленный репозиторий изменения, сделанные в локальном репозитории
```
git push
```
Внедрить изменения из одной ветки в другую
```
git pull --rebase
```