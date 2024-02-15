### Подсказка по GIT

* Проверили наличие и версию GIT
```sh
git --version
```
* Саздание репозитория
```sh
git init
```
* Добавиление содержимого рабочего коталога
```sh
git add <filename>
```
* Фиксация или сохранение
```sh
git commit -m "massage"
```
* Журнал изменений
```sh
git log
```
* Сокращенный журнал изменений
```sh
git log --oneline
```
* Вызов конкретного сохранения
```sh
git checkout
```
* Возвращение к последней актуальной версии
```sh
git checkout main(MASTER)
```
* Разница между текущим файлом и сохраненным
```sh
git diff
```
* Удаление не добавленного в git
```sh
git restore
```
* Отображение всех веток
```sh
git branch
```
* Переход между ветками
```sh
git checkout <branch_name>
```
* Создать новую ветку
```sh
git branch <branch_name>
```
* Слияние веток в основную
```sh
git merge <branch_name>
```
* Удаление не нужных веток
```sh
git branch -d <branch_name>
```
* Просмотр графика изменений по веткам
```sh
git log --oneline --graph
```
* Сделать копию из удаленного репозитория
```sh
git clone <link>
```
* Скачать из удаленного репозитория
```sh
git pull
```
* Перенести файлы из локального репозитория в удаленный
```sh
git push
```