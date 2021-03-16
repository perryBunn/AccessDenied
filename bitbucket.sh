#!bin/bash

git remote add bitbucket https://bitbucket.org/perryBunn/accessdenied.git

git remote -v | read message

match = "Bitbucket.*https:\/\/bitbucket\.org\/perryBunn\/accessdenied\.git"
if [[ $message == *$match* ]]; then
	echo "Remote added successfully!"
else
	echo "Remote failed, check for error message"
fi

