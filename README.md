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

## Заметки

Что бы сделать push от другого пользователя необходимо выполнить команду
```sh
GIT_SSH_COMMAND='ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes' git push git@github.com:gulden-geekbrains/version_control.git
```

вместо *user-private-key* подставьте свой ключ

Можно прописать настройки для подсоединения по ssh
```sh
git config remote.origin.url git@github.com:gitusername/reponame
git config core.sshCommand "ssh -i ~/.ssh/user-private-key -o IdentitiesOnly=yes"
```
# Как подружить git с github под Windows 10

Вот видео инструкция https://youtu.be/E8cIjbJMEpE


# Создали my_first_repo
```sd
Добавили текст

Добавили текст через веб браузер

Добавим текст локально 

Добавили текст в новой ветке newbranch

Разрешаем конфликт в браузере

Добавляем конфликт 2.0 так как видеоурок был срезан и разрешим его
```

# Domashneye zadaniye

## Какая команда создает локальный репозиторий?

```sd
git init
```

## Какой командой можно сделать локальную копиюу даленного репозитория?

```sd
git clone
```

## Как называют копию чужого репозитория?

```sd
fork
```

## Как «стянуть/выкачать» все изменения из удаленного репозитория на свой компьютер?

```sd
git pull
```

## Чтоделает команда git pull?

```sd
Выкачивает данные из удаленного репо и делает слияние с локальным репо
```

## Какой командой отправить изменения в удаленный репозиторий?

```sd
git push
```

## Какие особенностиесть укоманды push?
 
```sd
git должен знать адрес удаленного репозитория;
git должен быть "авторизован" на внесение изменений в удаленном репозитории
```

## Какую операцию выполняет команда git add?

```sd
Добавляет файлу версионность в локальном репозитории
```

## Какая команда позволяет перемещаться между сохранениями?

```sd
git checkout
```

## Какая команда позволяет увидеть разницу между текущей изафиксированной версией файла?

```sd
git diff
```

## Какая команда позволяет зафиксировать изменения в репозитории?

```sd
git commit -m
```

## Как вывести список всех имеющихсяветок на экран?

```sd
git branch
```

## Как создать новуюветку?

```sd
git branch branch_name
```

## Какая команда позволяет слить ветки?

```sd
git merge branch_name
```

## Как сработает git merge lists?

```sd
В текущую ветку добавит информацию из ветки lists
```


