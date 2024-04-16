### Домашнее задние MarkDown и Git ветки

# Основные команды

git init to initialize folder

git commit -m 'commit text' for commiting new added save

git status check-check

git log ⇒ list of savings

git checkout + code of commit ⇒ previous save

git checkout main ⇒ go to actual

git log —oneline (one line)

git log —graph (branches)

# Разметка

_Текст для **конфликта** в пользу старой версии_


# Ветки

_Текст для **конфликта** в пользу обоих версий_

git branch (branch lists)

git checkout branch_name (move to)

git merge branch_name (from main branch to merge changes)

git branch -d branch_name (delete merged branch)

git log --graph (log with branches)

# Изображения

Чтобы добавить изображение нужно поставить восклицательный знак и заключить его в квадратные скобки, в круглых скобках прописав отображаемое в случае ошибки ссылки на файл имя

![Logo](GDlogo.JPG)

### GitHub

Для того чтобы склонировать уже готовый удаленный репозиторий себе в папку

```sh
git clone
```

Чтобы увидеть все ветки нового скачанного репозитория. Иначе ветки могут быть скрыты, пока к ним не обратишься напрямую

```sh
git branch --all
```

Чтобы увидеть связи удаленного репозитория с локальным

```sh
git remote show origin
```

Для решения конфликтов между удаленным репозиторием и локальным
```sh
git push --rebase
git pull --rebase
```

Для того чтобы склонировать уже готовый удаленный репозиторий себе в папку

```sh
git clone
```

Для того чтобы склонировать уже готовый удаленный репозиторий себе в папку

```sh
git clone
```

Совместная работа на GitHub

1. Делаем форк (fork) интересующего репозитория
2. Делаем git clone для Нашей версии репозитория
3. Создаем ветку с предлагаемыми изменениями
4. Производим все изменения только в этой ветке
5. Отправляем изменения на свой аккаунт (push)
6. В окне GitHub появляется возможность отправить pull request