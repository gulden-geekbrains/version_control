# Hint on GIT

Create respository and alteration
```sh
git init
```

> создание респозитория

```sh
git add
```

# Work in progress

> добавление изменений (название)

```sh
git commit -m "Message"
```

> добавление коментария, делается после предыдущей команды

```sh
git log (oneline)
```

> посмотреть изменения (изменения в коротком виде)

```sh
git checkout (number or name)
```

> возврат к комментарию или переход к ветке

```sh
git checkout master
```

> возврат к текущей ветке

```sh
git status
```

> проверка текущих изменений

```sh
git diff
```

> для сравнения 

```sh
git dir
```

> просмотр веток (добавление)

```sh
git branch (name branch)
```

> слияние веток

```sh
git merge (name_branch)
```

> удаление ветки

```sh
git branch -d
```

# Работа с удаленным респозиторием

```sh
clone (ссылка) - создание копии с GitHub
```

```sh
remote (ссылка)
```

```sh
push - отправить в удаленный респозиторий изменения
```

```sh
pull - отправить изменения из удаленного респозитория в локальный (также сразу делает команду merge)
```

```sh
request - отправить запрос об изменениях
```

[helpful information](https://1cloud.ru/blog/git_for_begginers_chapter_1)

- [+] Command add
- [+] Quotes
- [+] Links
- [+] Branch command (for conflict)

### Итоги работы: 
1. добавлено 4 ветки hw1-4
2. 1-2 внесли изменения, слиты и удалены
3. 3 создала конфликт который был решен (branch_command (for conflict))
4. Слита с веткой master и добавляет эти итоги.
