# Getting started

This repository of the project is to setup the server. 

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