# Pun API Technical Documentation

## Getting install

1. Clone this repository with `git clone git@github.com:aymerickmichelet/AlainFini.git`
2. Setup database settings inside `.env` file
3. Run `docker compose up` command
4. Run `docker exec -it pun-back /bin/sh` command
5. Run `yarn run typeorm migration:run` command
6. Run `yarn run dev` command

## Migration:
1. Run `docker exec -it pun-back /bin/sh` command
2. Run `yarn run typeorm migration:generate -n "my-migration"` command
3. Run `yarn run typeorm migration:run` command

## Database

### Schema

### ORM Class

## Route API

Request type | request | body
-- | -- | --
GET | /pun?id=01 | :x:
POST | /pun |

```json{
	"firstname": "Alain",
	"lastname": "Fini",
	"author": "aymnms"
}
```
PUT | /pun |
```json
{
	"id": 01,
	"firstname": "Alain",
	"lastname": "Fini",
	"author": "aymnms"
}
```



