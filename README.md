# Подсказка по GIT

Создание репозитория:
```sh
git init - создание локального репозитория
```
Работа с изменениями:
```sh
git add Example.md- добавление файлу версионность в локальном репозитории

git commit -m "Message" - фиксация изменений и показ новых версий файлов
```
Просмотр истории сохранений
```sh
git log - список всех сохранений

git log --online - список всех сохранений(в укороченном формате)
```
Работа с сохранениями:
```sh
git checkout - перемещение между сохранениями и ветками
```
Работа с ветками:
```sh
git branch - создание ветки

git branch -d - удаление ветки

git checkout - переключение между ветками

git merge - слияние веток

git status - состояние ветки
```
Древо коммитов:
```sh
git log --graph  - дерево сохранений
```
Дополнительные команды:
```sh
cd - переход в определенный каталог

pwd - отображение текущего рабочего каталога

q - выход

Ctrl+S - сохранение

сlear - очистить терминал

Tab - автоматическое  заполнение названия в терминале
```
Дополнительные папки:
```sh
.gitignore - папка игнорирования файлов,фото и т.д.
```
Выход из редактора WIM:
```sh
Нажать Esc и написать :wq
```
Работа с удаленным репозиторием:
```sh
git clone - копирование удаленного репозитория на локальный компьютер
(Команда git clone составная: она не только загружает все изменения, но и пытается слить все ветки на локальном компьютере и в
удаленном репозитории)

git pull - скачивание версии из удаленного репозитория и автоматическое слияние с нашей версией

git push - отправка своей версии репозитория в удаленный репозиторий

fork - копирование чужого удаленного репозитория

pull request - команда для предложения изменений и запрос на вливание изменений в удаленный репозиторий
```

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


