CO2 Emission Calculator
Source of data : BEIS/Defra Greenhouse Gas Conversion Factors 2019

CO2 DATA :
Transportation methods in CO2e per passenger per km:

Small cars:
small-diesel-car : 142g
small-petrol-car : 154g
small-plugin-hybrid-car : 73g
small-electric-car : 50g
Medium cars:
medium-diesel-car : 171g
medium-petrol-car : 192g
medium-plugin-hybrid-car : 110g
medium-electric-car : 58g
Large cars:
large-diesel-car : 209g
large-petrol-car : 282g
large-plugin-hybrid-car : 126g
large-electric-car : 73g
other:
bus : 27g
train : 6g
Requirements:
MS Visual studio 2019
.net core 3.1

or running on Jenkins pipeline
This app is written by C# and a console app.
For running, build the co2-calculation build the co2-calculation-Test

The default commands line parameters are in the debug of co2-calculation:
in console :
co2-calculation —transportation-method small-petrol-car —distance 1200 —unit-of-distance m —output g

for help :
co2-calculation -help

Test:
one Unit test has included in code, CalcTest with sample “small-petrol-car” by distances 1500 km, and expected output should be 231000.

Jenkinsfile has these stages:
get the repo, NuGet packages, build and run the sample test.