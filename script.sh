#!/bin/sh

docker container rm docker-mongoapp
docker rmi $(docker images |grep 'docker-mongoapp')

cd template_app/
docker-compose up