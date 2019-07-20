@echo off

REM NATION (exemple: French=fr, German=ge, Europe=eu...)
set nation=fr
REM PSEUDO
set pseudo=aymnms
REM NAME OF YOU PROJECT
set project_name=test
REM NAME OF YOU MAINE SOURCE FILE WITHOUT FORMAT
set main_file_name=Test
REM Destination File (WITHOUT FILE NAME)
set name_jar=C:\Users\aymerick\Documents\Projets\MC\serv\plugins\
REM JavaBuildPath (path1;path2;...;)
set classpath=.;res\spigot-1.8.8.jar;



echo Suppression du bin...
rm -r bin
mkdir bin
echo Suppression du bin Done!

echo Compilation...
javac -d bin src\%nation%\%pseudo%\%project_name%\%main_file_name%.java
echo Compilation Done!

echo plugin.yml...
cp plugin.yml bin\plugin.yml
echo plugin.yml Done!

echo Archivage...
cd bin
jar -cf %name_jar%\%project_name%.jar %nation%\%pseudo%\%project_name%\%main_file_name%.class plugin.yml
cd ..
echo Archivage Done!

echo End.
pause