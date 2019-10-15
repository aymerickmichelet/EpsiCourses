#!/bin/bash

if [ ! -d "vignettes" ]
then
    echo "create folder 'vignettes'";
    mkdir vignettes
fi

echo "change length .jpg";
mogrify -resize 1920x920 *.jpg

echo "create miniatures vignettes/";
mogrify -resize 100x100 -path vignettes *.jpg

cat header.html > index.html

for i in *.jpg
do
    # <a href="" title=""><img src=""></a>
    echo -e "\t<a href=\"$i\" title=\"Affiche $i\"><img src=\"vignettes/$i\"></a>" >> index.html;
done

cat footer.html >> index.html





# Dans un fichier script qui se nommera gallerie.sh vous devez :

# vérifier l'existence du répertoire vignettes
# s'il n'existe pas alors vous le créez
# ensuite à partir des images contenues dans le fichier zip 
# vous devez modifier la taille en la mettant à 1280x960
# vous devez créer des mignatures de 100x100
# Utilisez mogrify 
# Ensuite vous générez un fichier index.html valide qui vous
# permettra d'afficher les vignettes et en cliquant dessus d'afficher l'image d'origine
# le fichier à produire est identique à celui en annexe