# Подсказка по работе с GIT

Создание репозитория
```sh
git init
```
## Добавить файл в репозиторий
```sh
git add
```
## Добавить описания внесенных изменений и закрепить в ветке.
```sh
git commit - m "text"
```
## Посмотреть все внесенные изменения 
```sh
git log
```
## Посмотреть все внесенные изменения в 1 строку.
```sh
git log --oneline
```
## Вернутся к выбранной точке(ветке)
```sh
git checkout
```
===============================================
# Обработка текста в MarkDown

*курсив*

**полужирный**

Ссылка [www.ya.ru](www.yandex.ru)

### Как добавлять цитаты

> Первый уровень цитирования
>> Второй уровень цитирования
>>> Третий уровень цитирования

## Добавляем изображение:

![Текст описания](https://static.tildacdn.com/tild3365-3865-4664-b036-373038363434/Vector.svg)

## Таблицы

| Заголовок 1 | Заголовок 2 |
| ----------- | ----------- |
| Ячейка 1    | Ячейка 2   |
| Ячейка 3    | Ячейка 4   |

Горизонтальная линия

---
---
---

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


