# Инструкция по языку MarkDown

## Заголовок второго уровня
### Заголовок 3го уровня

Обыйчный текст

Новая строка начинается с 2х пробелов

Самостоятельно зафиксировал комит

**Полужирный текст**

*Курсив*

## Цитирование в языке MD
> первый уровень цитирования
>> второй уровень цитирования

### SСписки

### Не пронумерованный список

* Лист 1
* Лист 2 

### Пронумерованный список

1. Лист 1
2. Лист 2

git diff

## WEB ссылки
Текст [пример ссылки](http.example.com "Всплывающая подсказка")

# Добавление картинок в MD
Это Париж
![Париж](image.jpeg)

## Делаем pull request

**My repo - https://github.com/enj0yka/version_control_my**

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