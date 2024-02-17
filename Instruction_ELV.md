# Инструкция по работе с Git
  
## Команды Git

* git --version - проверка настройки git

* git init - инициализация git

* git status - проверка статуса (текущего состояния файла)

* git add - добавление содержимого файла для последующего коммита

* git commit -m "Комментарий" - фиксация изменений с комментарием

* git log - просмотр журнала изменений

* git log --oneline - просмотр журнала изменений в сокращенном виде

* git log --graph - просмотр журнала изменений с ветками

* git log --oneline --graph - просмотр журнала изменений с ветками в сокращенном виде

* git checkout - переключение между версиями

* git checkout master - переключение на актуальную версию

* git checkout <имя_ветки> - переключение на нужную ветку

* git diff - просмотр разницы между текущим файлом и сохраненным

* git branch - отобразить ветки

* git branch <имя_ветки> - создать ветку

* git branch -d <имя_ветки> - удаление ветки

* git merge <имя_ветки> - слияние двух веток

* git ignore <имя_ветки> - исключение ненужных файлов.

## Создание pull request

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория https://git@github.com:gulden-geekbrains/version_control.git

2. Выполняем команду клонирования из своей fork-копии
git clone git@github.com:*YOURE_GITHUB*/version_control.git

3. Создаем новую ветку и вносим необходимые изменения в файл
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"

4. Делаем push
git push --set-upstream origin updatereadme
Переходим на свою страницу репозитория. 

5.  Выбираем ветку updatereadme и жмем кнопку Compare & pull request