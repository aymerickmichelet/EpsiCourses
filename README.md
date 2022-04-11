# bigdata mongobd

Ce tutoriel necessite l'installation de [docker](https://www.docker.com/products/docker-desktop/)

### lancer le serveur/container mongodb

```bash
docker-compose up -d
```

### rentrer dans le contrainer mongodb

```bash
docker exec -it "docker-mongodb" /bin/bash
```

Vous pouvez à présent executer des commandes mongo-db avec par exemple la commande:
```bash
mongod
```

### sortir du container

```bash
exit
```

### arrêter le serveur/container

```bash
docker-compose stop
```
