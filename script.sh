#!/bin/sh

projectname="docker-init"
codelocal="program"
codecontainer="/program"

if [ $1 = 'build' ]
then
    echo '[script] build...'
    docker build -t $projectname -f Dockerfile .
    echo '[script] done'
elif [ $1 = 'run' ]
then
    echo '[script] run...'
    docker run -v $(pwd)/$codelocal:$codecontainer --name $projectname $projectname
    echo '[script] done'
elif [ $1 = 'stop' ]
then
    echo '[script] stop...'
    docker stop $projectname
    echo '[script] done'
elif [ $1 = 'delete' ]
then
    echo '[script] delete...'
    docker rm $projectname
    echo '[script] done'
else
    echo '[script] ./script.sh [build/run]'
fi