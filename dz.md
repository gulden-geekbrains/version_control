# Инструкция по работе с GIT 
 ## Что такое Git?
 Git- самая популярная система управления версиями с распределенной архитектурой.

  ## Базовые команды 
  ## Команды начала работы
* git version - проверить версию GIT
* <u>Команды персонализации</u>: 
  1. Git config -- global.user.name "name"- персонализация (имя автора) 
  2. Git config -- global.user.email <почта> - персонализация (почта автора). 

*Эти две команды персонализации нужны для того, чтобы  при случае знать, кто уронил приложение и навалять ему.*
* Git init - создание репозитория ( по умолчанию в текущей папке)

*При написании настоящей инструкции на языке MARKdown использовались источники* <http://skillbox.ru/media/code/>
## Создание конфликта
Для фиксации состояния файла (создания commit) необходимо:
* сохранить файл 
* добавить его к индексации командой
 ``` git add < name file с расширением>```
 * создать commit командой `````` git commit - m "Комментарии - суть изменений"``````
 ## Ветвление
![Карелия](foto.jpg)
* git branch - вывод (просмотр) всех веток
* git branch < name branch> - создание новой ветки
* git checkout < name branch> - переход на нужную ветку
**** По умолчанию базовая-главная ветка всегда master. Текущая ветка (где находимся в данный момент) выделяется шрифтом зеленого цвета со звездочкой*
* git branch -d <имя ветки>-удалить ветку
  ## Создание удаленного репозитория
  Это репозиторий для обучения pull request

## Первые шаги

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория <https://git@github.com:gulden-geekbrains/version_control.git>
2. Выполняем команду клонирования из своей fork-копии
```sh
git clone git@github.com:*YOURE_GITHUB*/version_control.git
```
3. Создаем новую ветку и вносим необходимые изменения в файл
```sh
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```
4. Делаем push  
```sh
git push --set-upstream origin updatereadme
```
5. Переходим на свою страницу репозитория. Выбираем ветку **updatereadme** и жмем кнопку **Compare & pull request**

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
