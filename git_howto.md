# How to work with git

In this instruction reviewed:

1. [Basic commands](#basic-commandlets)
2. [Commands for remote work](#remote-work-with-versions-in-github)
<br>

> ## Basic Commandlets:

* git init - initialization of local repository

* git status

* git add - add files for next commit
	
        --all - adding to index all modified files


* git commit - commit transaction

	        -a - commit for ALL modified files bypassing "git add file_name"
	        -m "message" - adding message for commit

* git diff file1.ext file2.ext

* git branch - show branches
	        
            -d branch_name - delete branch

* git branch new_name - create new branch

* git checkout branch_name - swith to branch
	
        -b new_name - create new branch and switch to it

* git merge branch_name - merge active branch with branch_name
		
        --abort - cancel merging if there's any conflict

* git log - show log
	    
        --oneline - one line description
        --graph - show log tree

* git restore file_name - restore deleted file

* git rm file_name - delete file from git

> ## Remote work with versions in Github:

* **To upload your local reposutory to Github:**

    - create new repository in Github
    - you'll be suggested several ways to link your local repo with an online one:

    ![capture](Linkrepo.jpg)

    After creating a repository at Github you have to link a local repository with an online Github repository using command: 
    
        *git remote add origin link_to_repository*

    Link is on the right top corner of the screenshot.

    - Create new branch in the online repository 

    - To upload a local repository use command:
    
                *git push -u origin branch_name_created_in_the_previous_step*
 *Note* that all the links are available for copy-paste
 
 <br>

* **To download existing repository from Github:**

  - __*fork*__ existing repository at Github

  - Clone it to your local repository:

        git clone link_to_online_repo

  - Create new branch and work with initial files only in created by you branch
  - To upload changed repository to github use command:
        
        git push

  - Send "pull request" to originator of the repository:
  ![pull](PullRequest.JPG)

  - To download changes from Github open local repository linked to the online reposiroty and use command:
        
        git pull

