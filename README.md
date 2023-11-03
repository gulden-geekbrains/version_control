# Это репозиторий для обучения pull request

## Первые шаги

## Как взять чужой репозиторий и отправить изменения на слияния

В GitHub есть кнопка Fork (вилка), при нажатии копирует польностью репозиторий в наш репозиторий. И его можно клонируем на локальную машину.
Принято давать описание в файле README.MD к проекту на GitHub.
1. Делаем Fork
2. Делаем git clone для нашей версии этого репозитория
3. Создаем ветку с предполагаемыми изменениями
4. Вносим изменения только в этой ветке
5. Отправляем эти изменения на свой аккаунт (push)
6. Отправляем запрос на pull request 

## Удаление ветки на удаленном репозитории

```sh
git push origin --delete 'Название ветки'
```

## Решение конфликтов
Скачивание удаленного репозитория и внесение изменений с локальным с сохраненим в удаленном
```sh
git pull --rebase
```
Решаем конфликт. Сохраняем локальный репозиторий и выполняем

```sh
git rebase --continue
```
```sh
git push
```

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


