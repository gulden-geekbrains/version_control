# Подсказка по Git

##  Команды

Инициализация откржения git 
```sh
git init
```

Добавить изменения в репозиторий
```sh
git add file_name
```

Зафиксировать, запомнить состояние с комментарием
```sh
git commit -m "содержание комментария"
git commit -m "Initial  
```

Разница между редактируемым файлом и сохраненным с комитом
```sh
git diff 
```

Вывести список всех комитов, которые мы сделали во всех ветках / сокращенно
```sh
git log
git log --oneline 
git log --oneline --graph
```
добавим и сюда текста для тестирования конфликта

Переход между разными комитами
```sh
git checkout [номер комита] или [branch_name]
```

Ветки в git 
```sh
git branch
git branch new_branch_name
git branch -d branch_name_to_delete
git branch --graph
git checkout branch_name
git merge branch_name_to_current_branch
```
Еще добавили теекста в новой ветке :-)

Удаленный репозиторий
```sh
git clone [https адрес] // скачать себе  

git pull // скачать все актуальное из удаленного репозитория (команда составная - мёрджит)  

git push // отправляет наш репозиторий на удаленный. Требует авторизации.
```

