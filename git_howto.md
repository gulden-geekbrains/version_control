# How to work with git

## Первый запуск Git
После того как вы установили Git, первым делом нужно представится, делается это так:
```sh
git config --global user.name "Your username"
git config --global user.email "Your email" 
```

Псмотреть UserName, Mail и другие настройки мжно командой
```sh
git config --list
```
или
```sh
git config --list --show-origin
```

По умлчанию Git использует стандартный редактор в вашей системе, если вы хотите изменить редактр в котором будете набирать сообщения в Git, сделать это можно с помощью команды:
```sh
git config --global core.editor nvim
```
nvim - это редактор который будет использоваться в Git.


## Инициализация репозитория

```sh
git init
```

main commands

