Requirements:
MS Visual 2019
.net core 3.1

this app is written by C# and a console app. 
For running, build the co2-calculation build the co2-calculation-Test

The default commands line parameters are in the debug of co2-calculation: 
in console :
co2-calculation --transportation-method small-petrol-car --distance 1200 --unit-of-distance m --output g

 for help :
co2-calculation -help

Test:
one Unit test has included in code, CalcTest with sample "small-petrol-car"  by distances 1500 km, and expected output should be 231000.

Jenkinsfile has these stages:
get the repo, NuGet packages, build and run the sample test. 
