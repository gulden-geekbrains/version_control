# Подсказка по GIT

* Создание репозитория:
```sh
git init
```
* Добавление файла и изменений в нем:
```sh
git add
```
* Добавление commit
```sh
git commit -m "Massage"
```
* Просмотр добавленных commit
```sh
git log
```
* Просмотр добавленных commit списком
```sh
git log --oneline
```
* Что изменилось (в чем разница)
```sh
git diff
```
* Переход к интересующему cammit
```sh
git checkout
```
* Отображение всех веток
```sh
git branch
```
* создание новой ветки 
```sh
git branch new_list
```
* удалить ненужную ветку new_list
```sh
git branch -d new_list
```
* переход на новую ветку 
```sh
git checkout new_list
```
* перенос новой ветки
```sh
git merge new_list
```
* просмотр лога изменений по веткам
```sh
git log --graph
```
Метью перри
![Метью Перри](555.jpeg)

## Работа с удаленными репозиториями

* Открыть удаленный репозиторий
```sh
git clone ссылка на удаленный репозиторий
```
* Создание нового удаленного репозитория 
```sh
echo "# 123" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/AndrewShadow/123.git
git push -u origin main
---или если он уже создан---
git remote add origin https://github.com/AndrewShadow/123.git
git branch -M main
git push -u origin main
```
* Внесение изменений в удаленный репозиторий
```sh
git push
```
* Внесение изменений в новой ветке
```sh
git push --set-upstream origin new_branch
```