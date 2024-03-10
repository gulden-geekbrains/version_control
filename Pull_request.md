# Домашнее задание по Pull_request

1. Fork gulden_geekbrains/versio_control

2. Клонируем: 
```sh
git clone https://github.com/AnnaWolfgang/version_control.git 
```
3. Переходим в папку version_control

4. Создаем новую ветки: 
```sh
git checkout -b updatereadme
```
5. Создаем файл Pull_request.md

6. Фиксируем, коммитим

7. Выталкиваем в githab: 
```sh
git push
```
 и следуем подсказке терминала: 
 ```sh
 git push --set-upstream origin updatereadme
 ```
 8. В файле Pull_request.md создаем список проделанных шагов, фиксируем, коммитим.

 9. В github добавляем список проделанных шагов для конфликта

 10. Выталкиваем репозиторий в github

11. При возникновении конфликта разрешаем его запросом с github:  
```sh
git pull
```

12. Через VS Code в файле вносим изменения после конфликта, фиксируем, коммитим.

13. Добавляем список проделанных шагов, фиксируем, коммитим.

13. Повторяем выталкивание в github: 
```sh
git push
```
Отправляем на предложенный вариант хозяину
```sh
pull request
```
