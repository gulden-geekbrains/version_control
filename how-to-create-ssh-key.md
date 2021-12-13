# Что такое ssh

#  Как сгенерировать ssh ключ для github

Необходимо выполнить команду
```sh
ssh-keygen -t rsa -b 4096 -C "your_email@example.com"
```

Фразу пароль можно оставить пустой
```sh
> Enter passphrase (empty for no passphrase): [Type a passphrase]
> Enter same passphrase again: [Type passphrase again]
```

Задайте имя ключа. В текущей директории появится два файла:
- *new_key* - закрытый ключ. Никому его не передавайте и храните в надежном месте!!!
- *new_key.pub* - открытый ключ. Его необходимо загрузить на github
