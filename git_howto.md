# How to work with git

## Основные команды Git

* Инициализация локального репозитория:
    ```sh
    git init
    ```

* Получить информацию от git о его текущем состоянии:
    ```sh
    git status
    ```

* Добавить файл или файлы к следующему коммиту:
    ```sh
    git add file_name
    ```

* Создание коммита:
    ```sh
    git commit -m “message”
    ```

* Вывод на экран истории всех коммитов с их хеш-кодами:
    ```sh
    git log
    ```

* Переход от одного коммита к другому:
    ```sh
    git checkout HEX_Addr
    ```

* Вернуться к актуальному состоянию и продолжить работу:
    ```sh
    git checkout master
    ```

* Увидеть разницу между текущим файлом и закоммиченным файлом:
    ```sh
    git diff
    ```

* Выполнить клонирование из Githab
    ```sh
    git clone git@github.com:*YOURE_GITHUB*/version_control.git
    ```

* Выполнить загрузку репозитория в Github
    ```sh
    git push
    ```

* Выполнить выгрузку репозитория из Github
    ```sh
    git pull
    ```
