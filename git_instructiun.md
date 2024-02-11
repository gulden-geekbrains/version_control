# Работа с GIT

Для того чтобы гит начал работу с репазиторием
```sh
git init
```

Добавить файл в гит
```sh
git add
```

Для сохранения файла с сообщением
```sh
git commit -m "message"
```

Проверка статуса
```sh
git status
```

Для входа в нужный коммит
```sh
git checkout 5246
```

Список коммитов
```sh
git log --oneline
```

Список веток
```sh
git branch
```

Создать новую ветку 
```sh
git branch new_branch
```

Обьединить ветки
```sh
git merge new_branch
```

Удалить ветку
```sh
git branch -d new_branch
```

Логи в виде дерева
```sh
git log --graph
```

Работа с конфликтами
```sh
git pull/push --remote
```

аттестация

## GitHub

Как предложить свои изменения проекту:

1. Делаем форк
2. Делаем гит клон для нашей версии этого репазитория
3. При этом появляется наша версия на аккаунте
4. Создаем отдельную ветку с предлагаемыми изменениями
5. Производим все изменения только в этой ветке
6. Отпр изменения на свой акк ( пуш )
7. В окне на гитхаб появляется пул реквест с вашими изменениями

## GitHub
1. Create new repasitory
2. Connect local and remote repasitory
3. Send (push) locat repasitory to remote rep.
4. Make changes with other laptop
5. Pull (pull) actuality status from remote rep.