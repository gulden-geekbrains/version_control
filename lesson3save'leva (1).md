# Это репозиторий для обучения pull request

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

# Как включить ssh в Windows 10
В ОС Windows 10 по умолчанию уже есть ssh. Его надо только активировать.

Зайдите в Параметры - Приложения - Приложения и возможности - Дополнительные компоненты. В указанном спсике найдите Клиент OpenSSH, жмите установить.

Откройте cmd.

Наберите команду
```sh 
C:\Users\USER\>ssh 
использование: ssh [-46AaCfGgKkMNnqsTtVvXxYy] [-B bind_interface]
 [-b bind_address] [-c cipher_spec] [-D [bind_address:]порт]
 [-E log_file] [-e escape_char] [-F configfile] [-I pkcs11]
 [-i identity_file] [-J [user@]хост[:порт]] [-L адрес]
 [-l login_name] [-m mac_spec] [-O ctl_cmd] [-o опция] [-p порт]
 [-Q query_option] [-R адрес] [-S ctl_path] [-W хост: порт]
 [-w local_tun[:remote_tun]] пункт назначения [команда]
Перейдите к созданию ssh ключа.
```
# Что такое ssh
SSH (англ. Secure Shell — «безопасная оболочка»[1]) — сетевой протокол прикладного уровня, позволяющий производить удалённое управление операционной системой и туннелирование TCP-соединений (например, для передачи файлов). Схож по функциональности с протоколами Telnet и rlogin, но, в отличие от них, шифрует весь трафик, включая и передаваемые пароли. SSH допускает выбор различных алгоритмов шифрования. SSH-клиенты и SSH-серверы доступны для большинства сетевых операционных систем.

Как сгенерировать ssh ключ для github
Необходимо выполнить команду
```sh
ssh-keygen -t rsa -b 4096 -C "your_email@example.com"
```
Фразу пароль можно оставить пустой

> Введите кодовую фразу (пустую, поскольку кодовой фразы нет): [Введите кодовую фразу]
> Введите ту же кодовую фразу еще раз: [Введите кодовую фразу еще раз]
Задайте имя ключа. В текущей директории появится два файла:

new_key - закрытый ключ. Никому его не передавайте и храните в надежном месте!!!
new_key.pub - открытый ключ. Его необходимо загрузить на github