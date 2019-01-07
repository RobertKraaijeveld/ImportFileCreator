Import file creator for thesis prototype
========================================

A simple console app for creating fake import CSV files for the thesis prototype. Each file represents one day of data for one ship.

Requires the same pre-requisites as the full thesis prototype.

Running
---------
1. Change ''amountOfDays'' integer in Program.cs to the amount of days you wish to be created, default is three years. 
2. `dotnet restore`
3. `dotnet run`
4. Output files can be found in /Output.

Importing files into running ThesisPrototype
--------------------------------------------
1. Move import_all.sh script into /Output directory, or wherever you have stored the import CSV's.
2. `./import_all.sh`
