#!/bin/bash
echo 'Create repository for "devday-git-1"'
gh repo create Snapbean/devday-git-1 \
	--enable-issues=false --enable-wiki=false \
	--public --gitignore=VisualStudio --license=MIT -y

echo 'Create application "devday-git-1"'
cd ./devday-git-1
dotnet new console
git add .
git commit -m 'Initial commit'
git push -u origin main
cd ..

echo 'Create repository for "devday-git-2"'
gh repo create Snapbean/devday-git-2 \
	--enable-issues=false --enable-wiki=false \
	--public --gitignore=VisualStudio --license=MIT -y

echo 'Create application "devday-git-2"'
cd ./devday-git-2
dotnet new console
git add .
git commit -m 'Initial commit'
git push -u origin main
cd ..
