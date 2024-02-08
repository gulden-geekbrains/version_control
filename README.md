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

1. **Форкните** репозиторий, чтобы создать свою копию проекта.
2. **Склонируйте** свой форк на локальную машину с помощью команды `git clone`.
3. Создайте **ветку** для своей работы с помощью команды `git checkout -b my-feature-branch`.
4. Внесите **необходимые изменения** в файлы (код, документацию, тесты и т. д.).
5. **Закоммитьте** ваши изменения в только что созданную ветку с помощью команды `git commit`.
6. Убедитесь, что проект **работает корректно** после ваших изменений.
7. **Создайте pull request** на GitHub:
    - На странице вашего форка перейдите в раздел **Pull Requests**.
    - Нажмите кнопку **New Pull Request**.
    - Выберите ветку, которую вы хотите включить в основной репозиторий (обычно это ветка `main` или `master`).
    - Введите **заголовок** и **описание** для вашего pull request.
    - Нажмите **Create Pull Request**.
8. Если вы хотите создать **черновой** pull request, используйте выпадающее меню и выберите **Create Draft Pull Request**, затем нажмите **Draft Pull Request**.

Теперь вы можете предложить свои изменения в репозитории и совместно работать над ними! 🚀
