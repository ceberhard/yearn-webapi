
#$base = (Get-Item -Path ".\" -Verbose).FullName

#echo $base

#echo $PSScriptRoot

$dbpath = $PSScriptRoot + "\..\yearn.db"
$ddlpath = $PSScriptRoot + "\..\database\DDL.sql"
#$dmlpath = $PSScriptRoot + "\..\database\DML.sql"

$testdatapath = $PSScriptRoot + "\..\database\TestData.sql"

#echo $dbpath



sqlite3 -batch $dbpath $(cat $ddlpath);
#sqlite3 -batch $dbpath $(cat $dmlpath);
sqlite3 -batch $dbpath $(cat $testdatapath);

# sqlite3 $PSScriptRoot + "\..\yearn.db" $(cat $PSScriptRoot + "\database\DDL.sql");
