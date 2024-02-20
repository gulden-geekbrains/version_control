# Instruction and tips on the command line

## Text stylization

### Title / Subtitle:

``` sh
# Title 1 
## Subtitle 2
### SubTitle 3
```

### Quoting:

> First level 
>> Second level

``` sh
> First level
>> Second Level
```

### Lists:

* List 1 
* List 2 

``` sh
* List 1
* List 2
```
### Nambered lists: 

1. List 1
2. List 2

``` sh
1. List 1
2. List 2
```

### Web - link

[Moscowfc.ru](moscowfc.ru "theatre")

``` sh
[Moscowfc.ru](moscowfc.ru "theatre") - a tooltip
```

## Command line prompts:

Directory change command
``` sh
cd c:/full location file
```

Command of the current directory
``` sh
pwd
```

Listing the current directory
``` sh 
ls
```

Delete the file
``` sh
rm <file name>
```

### Cоздание репозитория

```sh
git init
git cd
git add
git commit -m "message"
git log --oneline
got checkout
```

### Conflict exmpl

```sh
Конфликт при слиянии веток - можно принять одну или вторую версию, или сразу обе. Так же можно внести изменения вручную
```
Deleted branch
```sh
git branch -d <branch name>
```

### Step-by-step instructions
```sh
git init
cd < full adress >
ls (листинг текущей директории)
git status
git branch - текущая ветка
git checkout - основная ветка
git chekout <name_branch>
внести изменения в ветку
git add
git commit -m "message"
git status
git log / git log --oneline
```
# Images
```sh
![meme_stosh] (meme_shtosh.jpg)
```

![meme_shtosh](meme_shtosh.jpg)