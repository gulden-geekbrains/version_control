# При старте
Создание репозитория:
```sh
git init
```

Смена директории:
```sh
cd <адрес>
```

Показать, в какой директории находимся
для Windows:
```sh
dir
```
Для Linox и MacOs:
```sh
ls
```

## Базовые команды 
Отображение текущего статуса. Для понимания: на какой ветке находимся, какие есть изменения, какие файлы отслеживаются, какие сохранены:
```sh
git status
```

Команда для отслеживания файла. (В том числе для последующего сохранения новых изменений. Используется в связке Сtrl+s --> git add --> git commit -m)
```sh
git add
```

Команда для сохранения изменений в файле. Также позволяет оставлять комментарии о том, что было изменено. 

```sh
git commit -m "Message"
```

## Другие команды

Команда, которая показывает все точки сохранений в файле. (А также позволяет переключаться между точками сохранения и ветками (см дальше)).
```sh
git checkout
```

Показать, что было изменено:
```sh 
git dif
```

## Все о командах git log

Команда для просмотра осуществленных изменениях в файле.

```sh
git log
```

Та же функция, только выводит изменения в сокращенном виде (в одну строчку каждое изменение)
```sh
git log --oneline
```

Для отображения взаимосвязей 
```sh
git log --graph
```

В идеале использовать сразу 2 ключа:
oneline + graph

```sh
git log --oneline --graph
```

## О командах branch

Команда, которая показывает _ветку_ в файле, на которой мы находимся. Также показывает вообще все ветки, которые есть:
```sh
git branch
```

Переключение между ветками:
```sh
git checkout <имя_ветки>
```
Команда для объединения веток:
```sh
git merge <название_ветки>
```
При этом важно помнить: указываемая для присоединения ветка будет присоединена к той ветке, в которой мы находимся на момент слияния.

Удаление ненужной ветки:
```sh
git branch -d <имя_ветки>
```

# Обучение pull request

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

Пока все! До новых встреч!
