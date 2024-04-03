# Это репозиторий для обучения pull request

## Первые шаги

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория <https://git@github.com:gulden-geekbrains/version_control.git>
2. Выполняем команду клонирования из своей fork-копии
```sh
git clone git@github.com:*YOURE_GITHUB*/version_control.git
```
3. Создаем новую ветку и вносим необходимые изменения в файл
```sh
git checkout -b updatereadme
vim README.md
git add README.md
git commit -m "Добавили инструкцию как создать pull request"
```
4. Делаем push  
```sh
git push --set-upstream origin updatereadme
```
5. Переходим на свою страницу репозитория. Выбираем ветку **updatereadme** и жмем кнопку **Compare & pull request**

## Новые команды:

Создание папки:

```sh
mkdir <name_folder>
```

Переход в папку:

```sh
cd <name_folder>/
```

Переименовать ветку master:

```sh
git branch -M main
```

Команда для просмотра подключенных удаленных репозиториев:
```sh
git remote -v
```

Команда позволяет просматривать, добавлять и удалять удаленные репозитории:
```sh
git remote 
```

Подробная информация об удаленном репозитории:
```sh
git remote show origin
```

Удалить ветку на удаленном репозитории:
```sh
git push origin --delete branch_name
```

Соединить изменения сетевого репозитория с локальной веткой:
```sh
git pull --rebase
```

Забрать изменения из удалённого репозитория, а затем слить их с текущей веткой:
```sh
git pull
```

Установить связь с удалённым репозиторием, вычислить локальные изменений, отсутствующие в нём, и передачи ихв вышеупомянутый репозиторий:

```sh
git push
```



