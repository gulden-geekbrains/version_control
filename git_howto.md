# Подсказка по гиту

## Инициализация репозитория

```sh
git init
```

## Статус репозитория

```sh
git status
```

## Добавление версии

```sh
git add <file name> 
```

## Добавление коммита

```sh
git commit -m “<message>”
```

## Add и commit одной командой

```sh
git commit -am “<message>” 
```

## Отображение всех коммитов

```sh
git log
```
--oneline *Более компактное отображение*
--graph *Отображение структуры веток*

## Смена состояния или ветки

```sh
git checkout <commit_key/branch_name>
```

## Отображение разницы между файлами

```sh
git diff

## Отображение всех веток

```sh
git branch
```

## Создание новой ветки

```sh
git branch <branch_name>
```

## Создать новую ветку и переключиться на нее

```sh
git checkout -b <branch_name>
```

## Слияние веток

```sh
git merge <branch_name>
```
**Нужно выполнять из под ветки, в которую надо направить другую.**

## Удаление ветки

```sh
git branch -d <branch_name>
```

