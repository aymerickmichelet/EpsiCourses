# Getting started

This repository of the project is to setup the minecraft server. 

## Installation

*Installation required: [docker](https://docs.docker.com/engine/install/ubuntu/)

Clone the project
```bash
git clone git@github.com:EpsiWisBES/MinecraftDocker.git
```

## Usage

Start all servers:
```bash
docker-compose up -d
```

Start just 1 server:
```bash
docker-compose up <container_name> -d // container_name: epsiwis-bungeecord, epsiwis-main
```

Get logs:
```bash
docker-compose logs
```

Stop all servers:
```bash
docker-compose stop
```

Stop 1 server:
```bash
docker-compose stop <container_name>
```

## WebConsole

To connect in webconsole minecraft, click [here](https://mc.epsiwis.fr)

Clic on "Your servers" and "Add server"

![image](https://user-images.githubusercontent.com/32719398/138145371-bc3f61ee-f9d3-4866-8734-44e10a1e1e7a.png)

Complete the form with this information:
```
Server name: epsiwis-main
Server Ip: localhost
WebConsole port: 25564
Server is SSL enabled: No
```
![image](https://user-images.githubusercontent.com/32719398/138145416-bdc4f4d4-cd1c-4a73-ba38-e3d3f51e75a9.png)

Enter the password as you can see in webconsole config in /main/plugins/webconsole/config.yaml
