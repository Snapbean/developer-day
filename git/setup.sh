#!/bin/bash

echo 'Create application "devday-git-1"'
dotnet new console -n devday-git-1
echo 'Create application "devday-git-2"'
dotnet new console -n devday-git-2

echo 'Create repository for "devday-git-1"'
cd ./devday-git-1
gh repo create Snapbean/devday-git-1 \
	--enable-issues=false --enable-wiki=false \
	--public --gitignore=VisualStudio -y

echo 'Create repository for "devday-git-2"'
cd ../devday-git-2
gh repo create Snapbean/devday-git-2 \
	--enable-issues=false --enable-wiki=false \
	--public --gitignore=VisualStudio -y

cd ..
