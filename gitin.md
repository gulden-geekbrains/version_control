# Инструкция по git :
Инициализация репозитория:
```sh
git init
```
Статус файла:
```sh
git status
```
Добавление файла в отслеживаемые (обновление файла)
```sh
git add имя_файла
```
Комментирование:
```sh
git commit -m "Сообщение"
```
История сохранения:
```sh
git log (git log --oneline --graph)
```
Переключиться на созранение или ветку:
```sh
git checkout
```
Список веток:
```sh
git branch
```
Создать новую ветку:
```sh
git branch имя_ветки
```
Слияние веток:
```sh
git merge имя_ветки 
```
Удаление ветки:
```sh
git branch -d имя_ветки
```
Клонирование файла из github:
```sh
git clone ссылка
```
Связывание локального и серверного файла:
```sh
git remote add origin https://github.com/artemkaog/-.git
git branch -M main
git push -u origin main
```
Выталкиваем обновление из локального:
```sh
git push
```
Вытягиваеи обновление из серверного:
```sh
git pull
```