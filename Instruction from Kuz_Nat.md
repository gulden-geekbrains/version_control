# Инструкция по языку Markdown

## Стилизация текста

Обычный текст набираем как есть.

Новая строка.

**Полужирный текст**

*Курсив*

## Цитирование  
>Первый уровень
>>Второй уровень

## Списки
### Ненумерованный список
* Лист

* Лист 2

### Нумерованный список
1. Лист
2. Лист 2

## Web ссылки

Текст [Пример ссылки](http.example.com "Всплывающая подсказка")

# Как добавлять картинки в Markdown

![Апельсин](orange.png)

## Инструкция для начала работы  сайта GitHub

echo "# for_study" >> README.md

  git init

  git add README.md

  git commit -m "first commit"

  git branch -M main

  git remote add origin https://github.com/kuznetsovanatalex/for_study.git

  git push -u origin main

  ## Основные команды:

  ```sh
  git clone https://github.com/kuznetsovanatalex/version_control_KZ.git (ссылка с сайта GITHuB)
  ```
копирует репозиторий с сервера на сайте
```sh
  git remote + show -v 
  ```
Показывает связь локального репозитория и сервера
  ```sh
  git pull/push 
  ```
Выгрузка изменений с сервера/ Загрузка изменений на сервер
  ```sh
  git push origin --delete 
  ```
  удаление ветки

```sh
git pull --rebase
  ```
При конфликте версии с сервера и локального, выгружает сначала данные с сервера.
Потом на локальном принимаются исправления, и далее исправляется конфликт