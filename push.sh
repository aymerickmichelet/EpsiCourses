github=("NomDuProjetGithub" "NomDuProjetGithub2")
projectname=("NomDeLaBranche" "NomDeLaBranche2")

for i in 0
do
    echo "[UPLOAD] > Cloning project ${github[$i]}"
    git clone git@github.com:aymerickmichelet/${github[$i]}.git project
    cd project
    echo "[UPLOAD] > Projet clonner"
    echo "[UPLOAD] > Création Nouvelle branche"
    git checkout -b ${projectname[$i]}
    git remote remove origin
    git remote add origin git@github.com:aymerickmichelet/EpsiCoursesProjects.git
    echo "[UPLOAD] > Push du projet sur github.com:aymerickmichelet/EpsiCoursesProjects.git"
    git push --set-upstream origin ${projectname[$i]}
    cd ..
    echo "[UPLOAD] > Suppression du dossier"
    sudo rm -r project
    echo "[UPLOAD] > FIN"
done
