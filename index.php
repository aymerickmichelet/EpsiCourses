<?php
include "utilisateur.php";
include "professeur.php";
include "eleve.php";
?>

<!-- 6 élèves, 3 professeurs
3 eleves niveau 1, 3 eleves de niveau 2,
les profs ont des matières
les profs ont des dispo
    prof 1: lundi mardi jeudi
    prof 2: lundi jeudi vendredi
    prof 3: mardi mercredi jeudi vendredi
les profs ont des levels
    prof 1: level 1
    prof 2: level 2
    prof 3: level 1 et 2 -->

<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Php_object</title>
</head>
<body>
    <div>
        <table>
            <thead>
                <tr>
                    <th colspan="2">EPSI B2 ELEVE</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>name</td>
                    <td>lastname</td>
                    <td>level</td>
                </tr>
<?php

$eleve1 = new eleve("Wesh", "Alors", 1);
$eleve2 = new eleve("Hola", "Quetal", 1);
$eleve3 = new eleve("Pas", "Content", 1);
$eleve4 = new eleve("Jean", "Neymar", 2);
$eleve5 = new eleve("Jean", "Eude", 2);
$eleve6 = new eleve("Jean", "Christophe", 2);

for($i = 1, $imax = 6; $i <= $imax; $i++){ 
    echo "<tr>";
    echo "<td>".${eleve.$i}->getName()."</td>";
    echo "<td>".${eleve.$i}->getLastname()."</td>";
    echo "<td>".${eleve.$i}->getLevel()."</td>";
    echo "</tr>";
}

?>
            </tbody>
        </table>
        <table>
            <thead>
                <tr>
                    <th colspan="2">EPSI B2 PROF</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>name</td>
                    <td>lastname</td>
                    <td>level</td>
                    <td>disponibility</td>
                    <td>school_subject</td>
                </tr>
<?php

$prof1 = new professeur("fabrice", "lenoble", [1],["lundi", "mardi", "jeudi"], "js");
$prof2 = new professeur("alexandre", "peneau", [2],["lundi", "jeudi", "vendredi"], "php");
$prof3 = new professeur("bouzoula", "rpz", [1,2],["mardi", "mercredi", "jeudi", "vendredi"], "TOUT");

for($i = 1, $imax = 3; $i <= $imax; $i++){
    echo "<tr>";
    echo "<td>".${prof.$i}->getName()."</td>";
    echo "<td>".${prof.$i}->getLastname()."</td>";
    echo "<td>";
    for($j = 0, $jmax = sizeof(${prof.$i}->getLevel()); $j < $jmax; $j++){
        echo ${prof.$i}->getLevel()[$j]." ";
    }
    echo "</td>";
    echo "<td>";
    for($j = 0, $jmax = sizeof(${prof.$i}->getDisponibility()); $j < $jmax; $j++){
        echo ${prof.$i}->getDisponibility()[$j]." ";
    }
    echo "</td>";
    echo "<td>".${prof.$i}->getSchoolSubject()."</td>";
    echo "</tr>";
}

?>
            </tbody>
        </table>
    </div>
</body>
</html>