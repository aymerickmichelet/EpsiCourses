BLUE='\033[0;34m' # Blue
GREEN='\033[0;32m' # Green
RED='\033[0;31m' # Red
DARK_GRAY='\033[1;30m' # DARK_GRAY
NC='\033[0m' # No Color

for project in $@
do
    echo "${BLUE}push.sh > start $project${DARK_GRAY}"
    git clone git@github.com:aymerickmichelet/$project.git project
    if [ -d "project" ]
    then
        echo "${GREEN}push.sh > cloned project $project${DARK_GRAY} "
        cd project
        git checkout -b $project
        git remote remove origin
        git remote add origin git@github.com:aymerickmichelet/EpsiCourses.git
        git push --set-upstream origin $project
        echo "${GREEN}push.sh > $project push on EpsiCourses${DARK_GRAY} "
        cd ..
        rm -rf project
        echo "${BLUE}push.sh > $project local folder removed${DARK_GRAY} "
    else
        echo "${RED}push.sh > project $project hasn't been cloned${DARK_GRAY} "
    fi
done
echo "${BLUE}push.sh > End${NC}"
