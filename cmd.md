# Подсказки по командно строке

Команла смены директории

```sh
cd Documents 
``````

Комнада отображения текущей директории.
Macos, Linux

```sh
pwd
``````

Листинг теущей директории
Windows:

```sh
dir
``````

Linux, MacOs:
```sh
dir 
```

Удаление файла Windows:
```sh
del
```

в liux, MacOs:
```sh
rm
````

отображает проделанную работу
если добавить --online, то покажет список укороченный  последних действий. 
![git log --online](log--online.png)
Если же приписать graph, то покажет визуально весь рабочий процесс с созданием и слиянием новых веток.
![git log --graph](graph.png)
```sh
git log 
```

переключение между ветками Git
```sh
git checkout + номер файла 
```

слияние двух веток. Чтобы слить ветки необходимо перейти в ветку master, а потом прописать данную команду.
```sh
git merge 
```

добавление комментария 
```sh
git commit --m "комментарий"
```

показывает список веток и в какой ветке сейчас находимся. Если приписать название, то данная команда создаст новую ветку
```sh
git branch 
```
>PS C:\Users\Asus\Desktop\гит> git branch
  graph
 -master
  new_txt

отображает статус нашего файла(изменения, сохранение)
```sh
git status 
```
>On branch master
Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        modified:   .gitignore
        modified:   cmd.md
        modified:   insruction.md


