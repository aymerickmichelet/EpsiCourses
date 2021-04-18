import mysql.connector


def setup():
    config = {
        'user': 'root',
        'password': 'weshalors',
        'host': 'bottleflip-db',
        'port': 3306
    }

    cnx = mysql.connector.connect(**config)
    cursor = cnx.cursor(dictionary=True)

    cursor.execute("CREATE DATABASE IF NOT EXISTS bottleflip")

    cursor.execute("USE bottleflip")

    cursor.execute('SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO"')
    cursor.execute('SET time_zone = "+00:00"')

    cursor.execute('CREATE TABLE IF NOT EXISTS `jokes` (`id` int(11) NOT NULL, `joke` varchar(2000) NOT NULL, `author` varchar(20) DEFAULT NULL, `step` varchar(30) NOT NULL DEFAULT "VALIDATION_REQUIRED") ENGINE=InnoDB DEFAULT CHARSET=utf8')

    totoJoke1 = """La maîtresse dit :
- Que celui qui se sent bête se lève.
Et Toto se lève.
- Tu te trouves bête Toto, demande la maîtresse ?
- Non madame, répondit Toto sûr de lui, mais ça me faisait de la peine de vous voir toute seule debout..."""

    totoJoke2 = """C est Toto et un copain à lui qui discutent de la valeur intrinsèque de leurs parents respectifs.
Le copain dit :
- Ouais, eh ben ma maman, elle est meilleure que ta maman !
Toto réfléchit deux secondes et répond :
- Ouais, jpense que tas raison, mon père dit la même chose que toi !"""

    cursor.execute("""INSERT INTO `jokes` (`id`, `joke`, `author`, `step`) VALUES
                   (1, 'Qu est-ce qui est jaune et qui attend ?\r\nJohnathan', 'Bouzoula', 'JOKE_ACCEPTED'),
                   (2, '"""+totoJoke1+"""', 'Bouzoula', 'JOKE_ACCEPTED'),
                   (3, '"""+totoJoke2+"""', 'Bouzoula', 'JOKE_ACCEPTED');""")

    cursor.execute('ALTER TABLE `jokes` ADD PRIMARY KEY (`id`)')
    cursor.execute('ALTER TABLE `jokes` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16')
