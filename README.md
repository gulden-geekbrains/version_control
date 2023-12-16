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

github  и работа с ним

1. создаем пустую папку, НЕ регистрируем ее в GIT 
2. заходим в guthub.com , ище репозиторий который нам нужен
2. кнопка CODE
3. копируем ссылку на адрес репозитория
4. в VSK - копируем в пустую папку - git clone ________ (скопированный адрес репозитория)
5. переходим в скопированный репозиторий, он уже отслеживается git

размещение репозитория в github
данные подсказки есть в github
git remote add origin https://github.com/ivenskikh/Test.git
git branch -M main
git push -u origin main

Обновление репозитория в github локальной информацией 
git push - и все должно обновиться!

Обновление ЛОКАЛЬНОГО репозитория новой инфой с github
git pull

работа с репозиторием другого пользователя:
в github в выбранном репозитории нажимаем иконку Fork (переводится - вилка), 
копируя данный репозиторий к себе в аккаунт 
далее - через клонирование репозитория кнопкой CODE в пустую папку
для работы сделаем новую ветку через git branch ___
переходим в ветку git checkout ____
и начинаем вносить изменения
после внесения изменений: git push + то что подскажет git
потом в github в репозитории появится кнопка Compare and pull request - 
отправляется запрос на сравнение и изменения в репозитории хозяина. 
