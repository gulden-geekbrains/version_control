# Инструкция по языку MarkDown

## Стилизация текста

Обычный текст

Новая строка.

**полужирный текст**

*курсив*

## цитирование в маркдаун
> первый уровень цитирования
>> второй уровень цитирования

## списки
### не нумерованные списки
* Лист
* Лист

### Нумерованный список
1. лист
2. лист

## WEB ссылки  
текст [пример ссылки](http.example.com "Всплывающая подсказка")

# Как добавлять картинки в маркдаун. 
Собака
! [Собака](Sobaka.webp)

# Pull request
## Первые шаги

1. Делаем fork репозитория, в которой потом хотим сделать pull request. Ищем кнопку Fork на странице репозитория https://git@github.com:gulden-geekbrains/version_control.git


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

4. Делаем Push
```sh
git push --set-upstream origin updatereadme
```
5. Перезодим на свою страницу репозитория. Выбираем ветку **updatereadme** и жмем кнопку **Compare & pull request**