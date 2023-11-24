# Знакомство с командами терминала для работы с Git

## основные команды

1. Создание репозитария в текущей папке
> git init
2. Вывод работающей версии программы git
> git --version
3. Перед работой необходимо представится 
> git config --global user.name <us_name>

> git config --global user.email <us_email> 
4. Просмотр файлов в папке, с которыми работает git
> git status 
5. Добавление файла под контроль git
> git add <file_name>
6. Отчистить терминал
> clear

## Работа с commitami (сохранениями)

1. Создать сохранение
> git commit -m "Текст пояснения"
2. Показать еще не сохранненные изменнения
> git diff
3. показать различие между двумя сохранениями
> git diff <№_commit> <№_commit>
4. отменить еще не сохраненные изменения
> git restore <file_name>

## Работа с базами сохранений

1. Просмотр всех сохранненных commitov
> git log
2. Упрощенный просмотр commitov
> git log --oneline
3. Просмотр коммитов с учетом разветвления
> git log --graph
4. -//- но упрощено
> git log --graph --oneline
5. Открыть нужный коммит
> git checkout <№_commit>

## работа с ветками

1. просмотр существующих веток
> git branch
2. создание новой ветки
> git branch <branch_name>
3. перейти на нужную ветку
> git checkout <branch_name>
4. Слияние веток. Выполняется из главной ветки, в которую мы хотим вставить второстепенную.
> git merge <branch_name>
5. удаление ненужной ветки
> git branch -d <branch_name>

## работа c удаленным репозиторием

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория.
2. Выполняем команду клонирования из своей fork-копии
```sh
git clone <ссылка на удаленный репозиторий>
```
3. Создаем новую ветку и вносим необходимые изменения в файл
```sh
git checkout -b <имя создоваемой ветки>
(vim README.md) - непонятный шаг
git add <имя файла>
git commit -m "Комментарий"
```
4. Делаем push  
```sh
git push --set-upstream origin <имя ветки>
```
5. Переходим на свою страницу репозитория. Выбираем ветку **<имя ветки>** и жмем кнопку **Compare & pull request**

## Заметки

Что бы сделать push от другого пользователя необходимо выполнить команду
```sh
GIT_SSH_COMMAND='ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes' git push git@github.com:gulden-geekbrains/version_control.git
```

вместо *user-private-key* подставьте свой ключ

Можно прописать настройки для подсоединения по ssh
```sh
git config remote.origin.url git@github.com:gitusername/reponame
git config core.sshCommand "ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes"
```
# Как подружить git с github под Windows 10

Вот видео инструкция https://youtu.be/E8cIjbJMEpE
