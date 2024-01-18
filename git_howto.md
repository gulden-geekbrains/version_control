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

