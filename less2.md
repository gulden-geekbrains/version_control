# less2_ready!!!

## Instructions for working with GIT

### ! Be sure to specify file names with extensions and do not lose "spaces".

### ! Remember that GIT manages saved files, not those in the process of editing.

Initializing the local repository  

```sh
Git init
```  
Get information from git about it's current state  

```sh
Git status
```  

Add files to repository (adds a version of the file in the local repository)

```sh
Git add “name_file”
```  

Save all files that have been added to our repository. Added **30** images - git add . will save all **30** files at once  

```sh
Git add .
```  

Creating a commit  

```sh  
Git commit  -m “message”
```  

Creating a change and committing it (the first commit is usually “initial commit”) - WORKS ONLY WITH SAVED FILES!!!

```sh
Git commit -am “message”
```  

Show a list of all branches on the screen   

```sh    
Git branch
```  
   
Moving from one branch to another   

```sh  
Git checkout "name branch"
```  

Creating a branch and moving to it  

```sh  
Git checkout -b "branch_name"
```  

Return to the current state and continue working

```sh  
Git checkout master
```  

Deleting branches  

```sh  
Git branch -d (-D) branch_name
```  
**Git branch -d branch_name** - *deletion algorithm:*

#### 1. check for the existence of a branch 
#### 2. if it exists, then delete the branch.
#### "-d - delete"

Displaying the history of all commits with their hash codes  

```sh  
Git log
```  

View the log in a shortened version  

```sh  
Git log --oneline
```  

The graf switch in conjunction with the log command allows you to display commits in the form of a tree  

```sh  
Git log --Graph
```  

See the difference between the current file and the committed file  

```sh  
Git diff
```  

Pull all the branches into one

```sh
Git pull
```  

Clone the repository on your laptop

```sh  
Git clone
```  

### Text selection

```sh
To highlight text in italics, you must frame it with asterisks (*) or underscore (_). For example, *like this* or _like this_.
```  

```sh  
To make text bold, you need to surround it with double asterisks (**) or double underscore (__). For example, **like this** or __like this__.  

Alternative methods of highlighting text in bold or cursive are needed so that we can combine both of these methods. For example, _text can be in italics and still be **bold**_.
```   

### Lists

```sh
To add unnumbered lists, you must highlight items with an asterisk (*) or plus sign +. For example, like this:   

* Element 1  
* Element 2  
* Element 3  
+ Element 4

To add numbered lists, you simply need to number the items.
For example, like this:  

1. first point
2. second point
```

### Working with images

To insert an image into text, just write the following:  

![Hello, this is kitty](kitty.jpg)  

### links

### Web links  

text [example link](httml.example.com "tooltip")

### Working with tables

### Quotes

### Conclusion