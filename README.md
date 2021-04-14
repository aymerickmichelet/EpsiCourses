# docker-init

docker init project. To start a docker project with a script to build, run, stop and delete image/container easily.

### import the project

```git clone git@github.com:aymerickmichelet/docker-init.git <project name>```

### how to use the script ?

After edit Dockerfile file, you must complete the 3 variables in `script.sh`:
- projectname: image & container name
- codelocal: relative folder where the local code is
- codecontainer: absolute folder where the container code is.

```bash
projectname="docker-init"
codelocal="program"
codecontainer="/program"
```

Now, you can execute script file with 4 posibilities:
- ```./script.sh build```: Build docker image
- ```./script.sh run```: Run docker image
- ```./script.sh stop```: Stop docker container
- ```./script.sh delete```: Delete docker container