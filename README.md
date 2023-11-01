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

# Раздел работы с удаленным репозиторием
# [GitHub](https://github.com "Перейти по ссылке")

Клонирование удаленного репозитория:
```sh
git clone <Url>
```
> *Создает локальную копию удаленного репозитория, указанного в Url.*

Получение изменений с удаленного репозитория:
```sh
git pull
```
Отправка изменений на удаленный репозиторий:
```sh
git push
```
> *git push origin main*
>*для отправки закоммиченных файлов в удаленный репозиторий в указанной ветке. Используйте эту команду, когда вы впервые отправляете файлы в удаленный репозиторий. Он зафиксирует место, куда вы отправляете эти файлы.*

Изменение адреса origin репозитория в git
```sh
Изменить origin адрес репозитория двумя способами:

1. Первый способ задать Url репозитория:

использовать команду git remote set-url origin, например:

git remote set-url origin git@github.com:organization/wi-backend.git

2. Второй способ:

Отредактировать файл .git/config: секция [remote "origin"] параметр - url. 
```

# Инструкция как создать pull request

Это руководство научит вас делать изменения в проекте на GitHub. 
Предполагается знание основ системы контроля версий Git. Вам также потребуется аккаунт на GitHub. Регистрация бесплатная и требует указания лишь имени пользователя и электронной почты.

<u>**Вот весь процесс пошагово:**</u>
```sh
1. Форкните проект.
2. Склонируйте репозиторий.
3. Создайте ветку для своей работы.
4. Сделайте необходимые изменения в файлах — коде, документации, тестах. Закоммитьте их в только что созданную ветку.
5. Убедитесь, что проект работает после ваших изменений.
6. Сделайте Pull Request.
7. Обсудите его с рецензентом в процессе Code Review. При необходимости, внесите изменения в свой Pull Request.
8. Когда все довольны, Pull Request принимают — с этого момента ваши изменения попали в исходный репозиторий (upstream) и являются частью проекта.
```