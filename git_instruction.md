# Подсказки по GIT

### Cоздание локального репозитория
```sh
git init
```

### Статус
```sh
git status
```

### Добавление имя пользователя
```sh
git config --global user.name "Aleksandr Zimin"
```

### Добавление почты пользователя
```sh
git config --global user.email "uzao-rec@ya.ru"
```

### Отслеживание всех файлов
```sh
git add . 
```

### Создание коммита
```sh
git commit -m "комментарий к коммиту" 
```

### Логи (укороченный вариант *--oneline*)
```sh
git log --oneline
```
Еще один вариант

```sh
git log --graph
```

### Смена ветки
```sh
git checkout master
```

### Отображение всех веток
```sh
git branch
```

### Создать новую ветку
```sh
git branch branch_name
```

### Слить ветки
```sh
git merge branch_name
```

### Удалить слитую ветку
```sh
git branch -d <branch_name>
```

### Что было изменено
```sh
git diff
```

## Работа с удаленным репозиторием

### Сделать локальную копию удаленного репозитория
```sh
git clone
```
пример (клонируем удаленный репозиторий)
```sh
git clone https://github.com/AleksandrZimin/version_control.git
```


### «стянуть/выкачать» все изменения из удаленного репозитория
```sh
git pull
```

### Отправить изменения в удаленный репозиторий
```sh
git push
```
### Копия чужого репозитория
```sh
fork
```
