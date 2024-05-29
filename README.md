clean# Это репозиторий для обучения pull request

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

# Инструкция по MarkDown
## 2-е решётки - заголовок второго уровня

### 3- решётки - 3-го уровня

и т.д.

Новая строка начинается через строку, иначе пишет последовательно

**Полужирный текст - две звёздочки в начале и конце**

*Одна Звезда в начале и конце - курсив*

## Цитирование в MarkDown 
> Первый уровень - один знак больше
>> Второй уровень - 2 знака больше

и т.д.

## Списки не нумерованные
* Первый
* Второй

Проверяем dif




### Нумерованные списки

1. Первый
2. Второй

1 и n с точкой

и т.д.

#### Web ссылки

Текст [пример ссылки]("http.example.com" "Всплывающая подсказка")

Над буквой Ё `
```sh
д.з.
```
Инструкция по pullrequest

Захожу на github

Ищу нужный репозиторий в поиске

Нажимаю на вилку Fork

Перенёс в свой github

Копирую, но уже со своим github

Клонирую локально git clone ctrl+v

Делаю изменения в своей ветке

Отправляю на свой сервер git puch

Со своего сервера делаю pull request на удалённый 

ВСЁ!













