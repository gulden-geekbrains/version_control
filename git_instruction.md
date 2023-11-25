# Инструкция для git

## Иницализация репозитория 
```sh
git init
```
## Создание коммитов

```sh
git add <имя файла>
```
## Потом сохраняем изменения и оставлям коментария

```sh
git commit m-
```
## Потом с помощю логов смотрим наши комити

```sh
git log
```
## С помощю чекаутов вернём предущую версию
```sh
git checkout "hesh commita"
```

## Для подклучения удаленного репозиторю
```sh
echo "# git" >> README.md
  git init
  git add README.md
  git commit -m "first commit"
  git branch -M main
  git remote add origin https://github.com/erik2232/git.git
  git push -u origin main
```
## для клонирования   удаленного репозиторю 
```sh
git clone ( адресс  репозиторю )

```
## для получения изм из  удаленного репозиторю
```sh
git pull
```
## для отправления измю на удаленного репозиторю
```sh
git push
```