# Инструкция по **MarkDown**

![Git](https://content.timeweb.com/assets/e41e86c7-bcc2-4740-a783-b2fd6ff6f839?width=1920&height=1080 'логотип Git')

### Что такое **Git**?

>***Git** - система контроля версий, которая позволяет сразу нескольким разработчикам сохранять и отслеживать изменения в файлах вашего проекта.*

---------------------
## Некоторые команды для работы в терминале **Git**

* создание репозитория
```sh
git init
```

* отображение состояния рабочего каталога
```sh
git status
```

* сохранение файла
```sh
git add
```

* сохранение с изменениями
```sh
git commit -m "Message"
```

* просмотр истории изменений
```sh
git log
```

* краткий список изменений с комментариями
```sh
git log --oneline
```

* переключение на другую ветку
```sh
git checkout
```

* наше местоположение на ветках
```sh
git branch
```

* очистить терминал
```sh
git clear
```

* слияние с другой веткой
```sh
git merge
```

* удаление ветки
```sh
git branch -d
```

* история веток в виде графа
```sh
git log --graph
```

------------------
## Немного о разметке в **MarkDown**

![MarkDown](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRXmTyTEA53luoxWgJ9vjgQ4uzqrbC_UNzuSw&usqp=CAU 'логотип MarkDown')

>***Markdown** — это простой язык разметки, используемый для создания форматированного текста (например, HTML) с помощью текстового редактора.*

### Некоторые методы разметки

* *Курсивный шрифт*
```sh
*Слово*
```

* **Полужирный шрифт**
```sh
**Слово** либо __Слово__
```

* Ненумерованный список
```sh
* Пункт 1
* Пункт 2
```

* # Название
```sh
# Слово
```

* ~~Зачёркнутый шрифт~~
```sh
~~Слово~~
```

* >Цитирование
```sh
>Слово
```

### Вставка ссылок/изображений

* синтаксис ссылки
```sh
[название ссылки](ссылка 'всплывающая подсказка')
```

* синтаксис изображения
```sh
![название изображения](ссылка 'всплывающая подсказка')
```
![котик](https://i.pinimg.com/564x/61/24/c0/6124c0afb953619ae6613546ea39eeb8.jpg 'котииик')



# Обучение pull request

![GitHub](https://www.webfx.com/wp-content/uploads/2022/08/github-logo.png 'логотип GitHub')

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



---------------------
создано при поддержке [GeekBrains](https://gb.ru/ 'официальный сайт')
![GeekBrains](https://tmsearch.onlinepatent.ru/images/75a/75ad465e-1cf7-46c9-961d-6a20ac490e53.jpg 'логотип GeekBrains')
