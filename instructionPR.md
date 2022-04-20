# Инструкция по работе с удаленными репозиториями

1. Находим нужный репозиторий у пользователя GitHub.
2. Нажимаем "fork", тем самым копируя репозиторий в свой рабочий кабинет GitHub.
3. Копируем ссылку на свой репозиторий и заходим в терминал Git на своем рабочем компьютере.
4. Пишем команду 
```sh
git clone git@github.com:*YOURE_GITHUB*/*NAME_OF_REP*.git
```
5. Создаем новую ветку и вносим изменения:
```sh
git checkout -b "branch_name"
git add
git commit -m
```
6. Отправляем свои изменения на сайт:
```sh
git push --set-upstream "branch_name"
```
7. Делаем pull request на сайте (предлагаем свои правки разработчику).

# Необходимо знать

* Для добавления своего репозитория в кабинет Github нужно ввести:
```sh
git remote add origin https://github.com/*YOURE_GITHUB*/*NAME_OF_REP*.git
git branch -M main
git push -u origin main
```
* Для отправки версии с Github на рабочее устройство и слияния репозиториев, нужно ввести:
```sh
git pull
```
