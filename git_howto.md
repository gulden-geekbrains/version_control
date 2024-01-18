# <font size = 15>GIT TUTORIAL </font> 

><font size = 6>"Consider Your Origins: You Were not Made to Live as Brutes, but to Follow Virtue and Knowledge."</font>

<font size = 5> Quote by Dante Alighieri </font>

# Подсказка по гиту

<font size = 4>Here are some rules on how to work within GIT for File Version Control. Please follow the recommendations to track your file versions correctly.

First things first. You need to start up the GIT. Use the following command to initialize the progrram.

## Инициализация репозитория

```sh
git init
```

You also need to introduce yourself to the GIT as all your comits and changes to the file will be marked with your name and contact e-mail adress. So before starting work with Terminal do the following configuration commands, please.

* <font color = yellow>git</font> config user.name "Alex Smith" " - Put your own name inbetween the quotation marks.

* <font color = yellow>git</font> config user.email "alex.smith@gmail.com" - Put your contact e-mail adress.

>Why is it important to place your true information?
>>Because your code could be available to any person on the NET and if they want to contact you they should have your true e-mail and name so you can proove the copyright and, as a result, receive a job offer!

**NOTE!** The Program is not verifying the Name and e-mail adress you may put any information you like, but it is recommended to add your TRUE information to the NET</font>

## <font size = 10>Basic Commands in GIT</font>

<font size = 4>After you have initialized GIT at your device you need to check if the GIT is installed correctly. To check it follow the command given below.

```sh
git --version
```

So what we do next? We need to track the file and all the changes to it throughout the working process.
Let's add some directory where all the files we need to track will be.

Go the left side of VSC and add folder. in the updoming window you can choose the path to the directory or paste the address to your local folder. After that let's create a file inside of the folder. When the file is created check if you have stated the resolution to the file (for example .md, .exe., etc.)

Once the file is created let's add it to the tracking list of the GIT  for Version Control. Follow the next command and put the name of the file correctly.

"<font color = yellow>git</font> add <font color = lightblue>*name_of_the_file.md*</font>"  - you can just press TAB button to chose in between those files inside the folder you created. each time you press TAB button the name of file is filled-in automatically.


Here is the list of the key functions at GIT to navigate


## Статус репозитория

```sh
git status
```
"<font color = yellow>git</font> log" - shows the log of commits with indexes and all versions to the saved file

"<font color = yellow>git</font> log -- oneline" - shows the log of commits with indexes in a short form

"<font color = yellow>git</font> diff" - shows the differences between the last saved bersion of the file and unsaved changes.

It is not the full list of commands but we will return to them later on.</font>

For more information please foolow [the link](https://medium.com/make-apps-simple/git-commands-9541debf2f4a)

## <font size = 10>Commiting the File Versions through GIT</font>

<font size = 4>We have already mentioned this word "comit" in the paragrap abave, so let's try to aknow;edge what it means. When you work with a file you constantly change something. the file is changing it evolves but sometimes we need to track those changes, to see the evolution. So here comes the term "comit"

The following comand for GIT helps to maintain all the changes under your personal control. You can add some comment (a message to each commit)

"<font color = yellow> git</font> comit -m "<font color = lightblue>Comment</font>" " - where you put your comment inside the quotation marks.

If you feel necessary to return backward to some previous version of your file be sure you have commited the changes so it will help you to navigate between versions. The following commands will help you to work with some changes in the file.

"<font color = yellow>git</font> restore" - you may discard all the changes to the last saved option you have on your GIT.

"<font color = yellow>git</font> checkout <font color = yellow>XXXX</font> - where XXXX is first four characters of the commit you would like to return to. All of the commits have long unique codes, but only four first characters is enough.

"<font color = yellow>git</font> checkout master - if you want to reeturn to the final version of the file you could just use the name "master" as it is always the last saved aand added to GIT version of the file.

Here is how you can see it in a Terminal. The Number of a commit is given in HEX numeral system. 
![Commits in the log](<Commits in order.png>)</font>

## <font size = 10>How to Save New Version of the File</font>

<font size = 4>It is very important to follow the right order of the commands to keep all changes to your file in order. Here is the order of actions and commands to follow to get correct understanding. Follow it and you will succeed in Version Control.

1. add some changes to the file 
2. save changes to the file (CTRL+S)
3. git add name_of_the_file.md
4. git commit -m "Comment"