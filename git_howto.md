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



