# <center> GIT </center>

<p align="center">
<img src="https://git-scm.com/images/logos/logomark-orange@2x.png" />


## <center> Что же такое **git ?** </center>

### git - *это распределенная система управления версиями.*

## История:

В 2005 году програмист по имени Линус Торвальдс создает проект для управления  разработой ядра  _Linux_.

Проект является общедостпным и свободным для всех пользователей, при неоьбходимости вы можете скачать его с официального сайта:
[git](https://git-scm.com "Официальный сайт проекта git")

## Основные команды используемые в git:
1. Как задать имя пользователя и адрес электронной почты
```sh
git config --global user.name "Mrs. Anderson"
```
```sh
git config --global user.email "neo@matrix.com"
```
2. Кэширование учетных данных:
```sh
git config --global
```
3. Инициализация репозитория:
```sh
git init
```
4. Добавление файлов в область подготовленных файлов:
```sh
git add matrix.red
```
5.  Проверка статуса репозитория:
```sh
git status
```
6. Внесение изменений с флагом -m "massage":
```sh
git commit -m "Stop trying to hit me and hit me, NEO"
```
7. Просмотр истории коммитов с изменениями:
```sh
git log
```
8. Просмотр изменений до коммита:
```sh
git diff matrix.red
```
9. Удаление отслеживаемых файлов из текущего рабочего древа: 
```sh
git rm smith.agent
```
11.  Переключение между различными версиями
```sh
git checkout <имя_ветки>
```

12. Отображение всех веток
```sh
git branch
```

13. Созщдание новой ветки
```sh
git branch <имя_ветки>
```

14. Удаление ветки
```sh
git branch -d <имя_ветки>
```

15. Отображение журнала фиксации в виде графика и просмотра истории по всем  веткам 
```sh
git log --oneline --graph
```
Для всех веток необходимо добавить (--all)
```sh
git log --all --oneline --graph
````
16. Слияние веток
```sh
git merge <имя_ветки>
```

<p align="center">
<img src="https://static.wikia.nocookie.net/matrix/images/4/4d/Wake_up_neo.png/revision/latest/scale-to-width-down/294?cb=20181025033723" />

