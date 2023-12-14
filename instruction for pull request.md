# Инструкция по работе с Git

![Git](https://git-scm.com/images/logo@2x.png) 

## Настройка данных пользователся
```sh
git config --global user.name "Dmitrii Zheludkov"
git config --global user.email "dv-zheludkov@yandex.ru"
```

## Основные команды
- инициализацировать локальный репозиторий
  ```sh
  git init
  ```
- получить информацию от git о его текущем состоянии
  ```sh
  git status
  ```
- добавить файл или файлы к следующему коммиту
  ```sh
  git add
  ```
- создать коммит
  ```sh
  git commit -m “message”
  ```
- вывести на экран истории всех коммитов с их хеш-кодами
  ```sh
  git  log 
  ```
- перейти к коммиту
  ```sh
  git checkout
  ```
- вернуться к актуальному состоянию и продолжить работу
  ```sh
  git checkout master
  ```
- показать разницу между текущим файлом и закоммиченным файлом
  ```sh
  git diff
  ```

Файл .gitignore в корневой папке предназначен для хранения списка файлов и папок, который git должен игнорировать и не отслежывать на предмет изменений

## Команды для работы с ветвями
- показать все ветки
  ```sh
  git branch
  ```
- создать новую ветку
  ```sh
  git branch branch_name
  ```
- перейти на другую ветку
  ```sh
  git checkout branch_name
  ```
- объединить ветки
  ```sh
  git merge branch_name
  ```
- удалить ветку
  ```sh
  git branch -d branch_name
  ```
- отобразить лог с визуализацией
  ```sh
  git log --graph
  ```
- отобразить лог в сокращенном виде
  ```sh
  git log --oneline
  ```

