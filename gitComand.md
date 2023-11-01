# Подсказка по GIT

Создание репозитория
```sh
git init
```

Сохранение изменений
```sh
git add
```

Создание комментария
```sh
git commit -m "text"
```

Просмотр изменений (полный)
```sh
git log
```

Просмотр изменений (краткий)
```sh
git log --oneline
```
Просмотр изменений (кратко с графическим изображением веток)
```sh
git log --oneline --graph
```


Воззащение к предыдущему сохранению
```sh
git checkout name_branch
```

Отображение всех веток
```sh
git branch
```

Создание новой ветки
```sh
git branch name_branch
```

Удаление ветки
```sh
git branch -d name_branch
```

Переименовать ветку
```sh
git branch -M main
```

Клонирование репозитория 
```sh
git clone web_reference
```

Сохранение репозитория
```sh
git push
```

Сохранить ветку в репозитории
```sh
git push --setupstream oriin name_branch
```

Удаление ветки из репозитория
```sh
git push origin --delete name_branch
```

Сохранить все изменения в репозиторий
```sh
git push -u origin main
```

Загрузка сохранений репозитория
```sh
git pull
```

Загрузка и слияние текущих изменений
```sh
git pull --rebase
```

зафиксировать все конфликты
```sh
git rebase --continue
```

Добавление фаила
```sh
echo "first string" >> file_name
```

добавление удаленного репозитория
```sh
git remote add origin web-link.git
```

показать сожранённые репозитории
```sh
git remote show
```

Показать сожранённые репозитории подробнее(только после входа)
```sh
git remote show -v
```

Показать более подробную информацию о репозитории
```sh
git remote show orgin
```