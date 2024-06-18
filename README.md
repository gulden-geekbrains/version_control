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


## Реквест (fork) для репозитория на GitHub

В открытых OpenSource проектах доступ к исходному коду есть у ограниченного круга программистов. Однако всегда есть желающие поработать над проектом и для того чтобы это сделать, можно копировать репозиторий и уже в нём попробовать проделать некую работу. Fork - это функция копирования репозитория на ГитХабе или других ресурсах. От англ. FORK - вилка, потому что ветвления веток репозитория похоже на вилку. Форкирование(копирование) можно сделать с помощью соответствующей кнопки на ресурсе. Идея предложенная в чей-то проект ВСЕГДА делается на отдельной ветке. После проделанной работы, можно предложить создателю свою работу. Для этого делают реквест на оригинальный репозиторий.

1. Делаем fork репозитория.
2. Делаем clone СВОЕЙ версии репозитория.
3. Создаем новую ветку и в НЕЕ вносим свои изменения.
4. Фиксируем изменения (делаем коммиты).
5. Отправляем свою версию в свой GitHub.
6. На сайте GitHub нажимаем кнопку pull request.