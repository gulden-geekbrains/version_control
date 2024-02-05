# Это репозиторий для обучения pull request

## Первые шаги

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория <https://git@github.com:gulden-geekbrains/version_control.git>
2. Выполняем команду клонирования из своей fork-копии
# Инструкция по языку Markdown

## Стилизация текста
Обычный текст набираем как есть.

Новая строка.


 *Курсивный текст*

**Жирный текст**

~~Зачеркнутый текст~~

Цитирование в языке Markdown
>Первый уровень цитирования
>>Второй уровень

## Списки
### Ненумерованный список
* Пункт один
* Пункт два

### Нумерованный список
1. Один
2. Два

## Web-ссылки

Текст [пример ссылки](http.example.com "Всплывающая подсказка")

Добавили текст 
Добавить ещё немного текста


## Изображения

### *Первый способ*
Добавление изображения из папки
![Вид на Сицилию](/Users/ekaterinagordienko/Desktop/lesson1/сицилия.jpg "Cицилия")
<image src="/Users/ekaterinagordienko/Desktop/lesson1/сицилия.jpg" alt="Вид на Сицилию">


### *Второй способ*
Добавление изображения из ссылки
![Изображение](https://sneg.top/uploads/posts/2023-04/1681287833_sneg-top-p-zheltie-tyulpani-kartinki-pinterest-1.jpg "Букет тюльпанов")


# Добавим картинки в Markdown
Actor
![Это актёр](benedict.jpg "Бенедикт")
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

Вот видео инструкция https://youtu.be/E8cIjbJM
