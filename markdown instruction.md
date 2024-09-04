# Инструкция для работы с MARKDOWN

## Выделение текста

Выделение текста курсивом (*), *ПРИМЕР* или (_), _ПРИМЕР_

Выделение текса полужирным (**), **ПРИМЕР** или (__), __ПРИМЕР__

Альтернативные способы нужны для совмещения форматирования
**_полужиный курсив_**

## Списки

Ненумерованный список выделяем (*)
* пример 1
* пример 2
* пример 3
* пример 4
Нумерованные списки просто пронумеровываем
1. пункт 1
2. пункт 2
3. пункт 3

## Изображения

Для добавление картнки в текст:
![Схема](Image.png)

## Ссылки

Это [**ссылка задания**](https://gb.ru/lessons/426438/homework "Task") с заголовком

[_Эта ссылка_](https://gb.ru/lessons/426438/homework) без заголовка

<https://gb.ru/lessons/426438/homework> – а это безанкорная ссылка

## Таблицы

Для таблицы используются символ (|) и (-)

Пример:
|Язык|Метка|
|-|-|
|JavaScript|*javascript*|
|C++|*cpp*|
|HTML|*html*|
|Markdown|*md*|
|Python|*python*|

## Цитаты

Для добавления цитаты нужно вставить (>)

> **Привет!** Это цитата

> Это тоже _цитата_

> Это **еще одна** цитата

>>Это ее продолжение (показываем отступом >> )

>>> * это тоже
>>> * и это...

Будет

>

> Одна целая цитата

## Заключение

Все, чего не хватает здесь **ищи САМ!**


# Как сделать pull request

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