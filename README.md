Import file creator for thesis prototype
========================================

A simple console app for creating fake import CSV files for the thesis prototype. Each file represents one day of data for one ship.

Requires the same pre-requisites as the full thesis prototype.

Running
---------
<<<<<<< HEAD
1. Change ''amountOfDays'' integer in Program.cs to the amount of days you wish to be created, default is three years. 
2. > dotnet restore
3. > dotnet run
4. Output files can be found in /Output.
=======
1. `mkdir Output`
2. Change ''amountOfDays'' integer in Program.cs to the amount of days you wish to be created, default is three years. 
3. `dotnet restore`
4. `dotnet run`
5. Output files can be found in /Output.
>>>>>>> a126f98d2e9e2dc17dc6fab70a0f2330a31f592b

Importing files into running ThesisPrototype
--------------------------------------------
1. Move import_all.sh script into /Output directory, or wherever you have stored the import CSV's.
<<<<<<< HEAD
2. > ./import_all.sh
=======
2. `./import_all.sh`
>>>>>>> a126f98d2e9e2dc17dc6fab70a0f2330a31f592b
