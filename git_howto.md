# Подсказка по гиту

## Инициализация репозитория

```sh
git init
```

## Статус репозитория

```sh
git status
```

## Создаем новую ветку и вносим необходимые изменения в файл

```sh
git clone <ссылка на репозиторий в github>
```

## Создаем новую ветку и вносим необходимые изменения в файл

```sh
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```

## Делаем push

```sh
git push --st -upstream origin updatereadme
```