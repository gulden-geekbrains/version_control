# Инструкция по языку MarkDown

Новая строка - это олна пустая строка

**Полужирный текст**

*Курсив текст*

## Цитирование
> Первый уровень
>> Второй уровень

## Списки
### Ненумерованные списки
* Лист 1
* Лист 2
### Нумерованные списки
1. Лист 1
2. Лист 2
3. Лист 3

## WEB ссылки
Текст [пример ссылки](http.example.com "Всплывающая подсказка")

## Работа с таблицами

Буква | Цифра | Символ
------ | ------|----------
a      | 4     | $
x      | 365    | (
b      |       | ^  

Буква|Цифра|Символ
---|---|---
a|4|$
 |365|(
b| |^  

Column | Column
------ | ------
\| Cell \|| \| Cell \|  


Column | Column | Column
:----- | :----: | -----:
Left   | Center | Right
align  | align  | align

## Картинки

### Это яблоко

![apple](apple.jpg)

### Это апельсин

![orange](orange.png)

# Работа с удаленными репозиториями
## Просмотр удаленных репозиториев
Для того, чтобы просмотреть список настроенных удалённых репозиториев, вы можете запустить команду git remote. Она выведет названия доступных удалённых репозиториев.

Например:
```sh
git remote
origin
```
Можно также указать ключ -v, чтобы просмотреть адреса для чтения и записи, привязанные к репозиторию:
```sh
git remote -v
origin  https://github.com/user/version_control.git (fetch)
origin  https://github.com/user/version_control.git (push)
```
Если хотите получить побольше информации об одном из удалённых репозиториев, вы можете использовать команду git remote show < remote >. Выполнив эту команду с некоторым именем, например, origin, вы получите следующий результат:
```sh
git remote show origin
 *remote origin
  Fetch URL: https://github.com/user/version_control.git
  Push  URL: https://github.com/user/version_control.git
  HEAD branch: main
  Remote branches:
    main                 tracked
    markdown_instruction tracked
  Local branches configured for 'git pull':
    main                 merges with remote main
    markdown_instruction merges with remote markdown_instruction
  Local refs configured for 'git push':
    main                 pushes to main                 (up to date)
    markdown_instruction pushes to markdown_instruction (up to date)
```
## Добавление удаленных репозиториев
Для того, чтобы добавить удалённый репозиторий и присвоить ему имя (shortname), просто выполните команду git remote add < shortname > < url >
```sh
git remote add origin https://github.com/user/version_control.git
```
## Получение изменений из удалённого репозитория — Fetch и Pull
Команда fetch связывается с указанным удалённым репозиторием и забирает все те данные, которых у вас ещё нет. После того как вы выполнили команду, у вас должны появиться ссылки на все ветки из этого удалённого репозитория, которые вы можете просмотреть или слить в любой момент.

Важно отметить, что команда git fetch забирает данные в ваш локальный репозиторий, но не сливает их с какими-либо вашими наработками и не модифицирует то, над чем вы работаете в данный момент. Вам необходимо вручную слить эти данные с вашими, когда вы будете готовы.

Команда pull -это фактически последовательное выполнение двух команд: git fetch и git merge.
## Отправка изменений в удалённый репозиторий (Push)
Когда вы хотите поделиться своими наработками, вам необходимо отправить их в удалённый репозиторий. Команда для этого действия: git push < remote-name > < branch-name >. Чтобы отправить вашу ветку main на сервер origin вы можете выполнить следующую команду для отправки ваших коммитов:
```sh
git push origin main
```
 ## Удаление ветки в удаленном репозитории
 Чтобы удалить ветку в удаленном репозитории можно использовать команду git push с параметром --delete:
 ```sh
 git push origin --delete newbranch
 ```
    
