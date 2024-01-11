# Подсказка по гиту

### Инициализация git
```sh
git init
```

### Индексация файла в git
```sh
git add
```

### Добавление коммита в git репозиторий
```sh
git commit -m <"message commit">
```

### Проверка статуса работы с файлами и сохранений git
```sh
git status
```

### Просмотр лога, полный листинг
```sh
git log
```

### Просмотр лога, короткий листинг
```sh
git log --oneline
```

### Просмотр лога, короткий листинг + визуальные изменения по веткам
```sh
git log --oneline --graph
```

### Переход на работу в другую ветку
```sh
git checkout <branch_name>
```

### Посмотреть текущий статус, в какой именно ветке идет работа и какие ветки доступны
```sh
git branch
```

### Создание новой ветки/переключение между ветками
```sh
git branch <file_name>
```

### Слить ветки
```sh
git merge
```

### Удалить ветку
```sh
git git branch -d <name_branch>
```

### Загрузить созданный репозиторий

git remote add origin https://github.com/Greedsinus/lection.git - куда грузим

### указываем ветку

git branch -M main - указываем ветку

### отправляем

git push -u origin main - отправляем

### Клонирование

git clone - далее адрес откуда копируем