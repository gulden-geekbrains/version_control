
# Базовые операции Git

## инициализация папки в Git

```sh
 git init
``` 
## Добавление содержимого файла 

```sh
 git add name_of_file
```
## Фиксация изменений с комментарием

```sh
 git commit -m "Мой комментарий что я делал"
```
## Просмотр истории операций

```sh
 git log
``` 

## Получение текущего статуса папки

```sh
 git status 

```
# Операции с ветками

## Определить сколько веток 
```sh
git branch  
```
## Добавление(создание) новой ветки

```sh
git branch  name_of_branch
```
## Переименование ветки

```sh
git branch -M name_of_branch
```

## Слияние веток
1. Перейти ветку, к которой прицепляешь
2. Набрать команду, где указать какую ветку прицепляешь.

```sh
git merge name_of_branch
```

## Переход между ветками

```sh
git checkout name_of_branch
```
## Удаление веток

```sh
git branch -d name_of_branch
```

# Команды работы с репозиториями

## Связывание с удаленным репозиторием

```sh
git remote add origin https://github.com/username/repo.git
```
## Клонирование с удаленного репозитория

```sh
git clone https://github.com/username/repo.git
```
## Заброс на удаленный репозиторий

```sh
git push https://github.com/username/repo.git
```
## Чтение с удаленного репозитория

```sh
git push https://github.com/username/repo.git
```