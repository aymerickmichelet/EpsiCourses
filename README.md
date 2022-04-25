# Bottleflip Api

[FR]
Bottleflip est un site web de partage de blague. On peut en demander où en proposer. 

[EN]
Bottleflip is a website where there is joke sharing. We can ask or give a joke.

## Database

**Jokes (table)**

id | joke | author | step
:---: | --- | --- | ---

## api python

url: https://bottleflip.aymerickmichelet.fr/api

app.py | db_mysql.py | script.sh | Dockerfile
:---: | :---: | :---: | :---:
contient l'ensemble des routes de l'api | permet de setup la base de donnée à la première utilisation | utilitaire | Dockerfile

### routes

**step** |
:---: |
VALIDATION_REQUIRED |
JOKE_ACCEPTED |
JOKE_REFUSED |


route | request type | body | return |explication
:--- | :---: | :---: | :---: | :---
/database | GET | x | x | setup database first time
/joke | GET | x | ![image](https://user-images.githubusercontent.com/32719398/115148586-898dac80-a060-11eb-9596-41484f38c130.png) | return 1 joke with step = "JOKE_ACCEPTED"
/joke/all | GET | x | ![image](https://user-images.githubusercontent.com/32719398/115148832-aaa2cd00-a061-11eb-98dc-0be363b31a3c.png) | return all joke
/joke/all/`step` | GET | x | ![image](https://user-images.githubusercontent.com/32719398/115148918-e9d11e00-a061-11eb-9075-7a6c920dd25e.png) | return all jokes with a same step<br>step: validation or accepted or refused
/joke | POST | ![image](https://user-images.githubusercontent.com/32719398/115148961-108f5480-a062-11eb-8027-9bafdf606da7.png) | ![image](https://user-images.githubusercontent.com/32719398/115149147-06ba2100-a063-11eb-9b1f-29e966e7b705.png) | send joke (with author)
/joke/`id`/`step` | PUT | x | ![image](https://user-images.githubusercontent.com/32719398/115149176-2d785780-a063-11eb-9ff8-25504f50d6a0.png) | permet de modifier l'etape d'une blague<br>step: validation or accepted or refused



BottleFlipApi | |
