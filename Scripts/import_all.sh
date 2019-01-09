#!/bin/bash

###################################################################
# Put this script in the dir that has the csv's you want to import!
###################################################################
SECONDS=0
url=http://localhost:53392

localFiles=""
for f in $(find -type f -name "*.csv" | sort -V | cut -c 3-) 
do
    localFiles="$localFiles $f"
done

for lf in $localFiles
do
    lf="$PWD/$lf"
    lf=$(echo "$lf" | cut -c 3-) # cutting away /c/, will be prefixed with C:/ by ASP.NET
    echo "Sending $lf"

    curl -X GET $url/Import/ImportLocalFile?filePath=$lf

    echo "Done with $lf"
done

ELAPSED="Elapsed time: $(($SECONDS / 3600))hrs $((($SECONDS / 60) % 60))min $(($SECONDS % 60))sec"
echo "All done!"
echo $ELAPSED