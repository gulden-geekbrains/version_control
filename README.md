# Это репозиторий для обучения pull request

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
```
# Как подружить git с github под Windows 10

Вот видео инструкция https://youtu.be/E8cIjbJMEpE


# Командные и опозновательные знаки 

## Списки 

* Текст
* Текст

+ Текст
+ Текст

1. Текст
2. Текст

## Выделение текста

**Текст Жирный**

*Текст Курсив*

_**Текст Курсив и жирный**_

```
Текст цитаты
```

~~Зачёркнутый текст~~

> Оформление цитатой
последовательных строк
внутри одного параграфа

## Фото и ссылки 

Текст [Ссылка на Гоблина](https://www.youtube.com/watch?v=X_codI8-xUI "Ссылка на видео в YouTube")

Фото 

![Чёткое фото](create.jpeg)

# Добавим пару команд git 

* git branch name - создаёт ветку
* git checkout - переключает между ветками и сохранениями
* git branch - проверяет ветки

* git add - доавбить или зафиксировать
* git commit - m "текст" - сохранить изменения 
* git status - узнать состояние

* git clone - Копирования репозитория

* git log - показ сохраненеий
* git log --oneline - показ сохраненеий укороченый
* git log --graph - показ сохраненеий с графиком изменением ветокgit checkout -b updatereadme

* git push - вывод на удалённый репозиторий
* git pull - ввод с удалёного репозитория