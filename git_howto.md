# Основные команды Git

## Инициализация репозитария
```sh
git init
```

## Показать статус репозитария
```sh
git status
```

## Добавить файл(ы) в индекс
```sh
git add/git add .
```

## Создать коммит с сообщением
```sh
git commit -m 'message'
```

## Просмотреть историю коммитов
```sh
git log/git log --oneline/git log -s
```

## Перейти к другому коммиту по хэшу
```sh
git checkout
```

## Перейти к последнему (актуальному) коммиту
```sh
git checkout master
```

## Посмотреть разницу между коммитами
```sh
git diff
```

# Ветки
## Просмотреть список всех веток
 ```sh
git branch
```
## Создать ветку
```sh
git branch <branch_name>
```
## Создать ветку сразу с переходом на нее
```sh
git branch -b <branch_name>
```
## Переход на другую ветку
```sh
git checkout <branch_name>
```
## Удаление ветки
```sh
git branch -d <branch_name>
```

