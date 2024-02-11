# Инструкция для работы с Markdown

## Выделение текста

Cursive: For example, *like that* or using _ _like that_.

Bold: For example, **like that** or using __ __like that__.

Альтернативные способы выделения нужны для того, чтобы их совмещать. Например, _текст может быть курсивным и **полужирным**_ одновременно.

## Списки

Чтобы выделить ненумерованный список, используйте (*) или знаком +.

Non-numbered list:
* element_1
* element_2
* element_3
+ element_4

Numbered list:
1. element_1
2. element_2
3. element_3

## Работа с изображениями

To instert an image you have to do this:

![Foggy mountains](image_1.jpg)

## Ссылки

To insert a website link you have to do this:

[markdown cheatsheet](https://www.markdownguide.org/cheat-sheet/)

## Работа с таблицами

| Syntax | Description |
| ----------- | ----------- |
| Header | Title |
| Paragraph | Text |

## Цитаты

You can quote a text by using (>) symbol, to double quote use (>>):

> hello

>>world

## Дополнительно

cmd commands:
+ directory change - `cd C:\folder_name`
+ current directory listing - `dir`
+ file deletion - `del <filename>`

## GitHub instructions

**Чтобы создать свою копию уже имеющегося на GitHub репозитория на своем ПК нужно:**

1. Открыть имеющийся на GitHub репозиторий (public or private) и скопировать ссылку на него нажав на кнопку '<> Code'.
2. В терминале на своем ПК написать команду `git clone <link>` (например `git clone https://github.com/ShafigullinIK/guess_the_number.git`).

`git pull` - позволяет скачать все из текущего репозитория и автоматически сделать `merge` с нашей версией

`git push` - позволяет отправить нашу версию репозитория на внешний репозиторий (требует авторизации на внешнем репозитории)

**Чтобы отправить загрузить имеющийся репозиторий на GitHub нужно:**

1. Создать аккаунт на GitHub.
2. Создать новый репозиторий на GitHub. После создания нового репозитория сайт предложит набор команд для пуша (git push) уже существующего (локально, на вашем ПК) репозитория:
    * `git remote add origin https://github.com/vedr0/git_edu2.git`
    * `git branch -M main`
    * `git push -u origin main`

## Blackholes

![blackhole_1](image_2.jpg)
![blackhole_2](image_3.jpg)
![blackhole_3](image_4.jpg)
