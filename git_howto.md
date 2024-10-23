# Подсказка по гиту

## Инициализация репозитория

```sh
git init
```

## Статус репозитория

```sh
git status
```

сохранение
```sh
git add
```
добавление комментариев, чтобы были как закладки с пометками
```sh
git commit -m"Message"
```

проверка статуса и общего состояния:
```sh
git status
```

вывод журнала, всей истории с изменениями
```sh
git log
```

мини версия журнала с красткими адресами
```sh
git log --oneline
```
наглядное представление веток
```sh
git log --oneline --graph
```

команда позволяет переходить по журналу в нужный момент или на нужную ветку
```sh
git checkout
```

## pull request 

Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория

Выполняем команду клонирования из своей fork-копии, например:
```sh
https://git@github.com:gulden-geekbrains/version_control.git
```
```sh
git clone
```
Создаем новую ветку и вносим необходимые изменения в файл

```sh
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```
Делаем push
```sh
git push --set-upstream origin updatereadme
```

Переходим на свою страницу репозитория. Выбираем ветку updatereadme и жмем кнопку Compare & pull request

  *обязательно подружить git с github* 