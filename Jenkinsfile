pipeline{
    agent any
    environment {
        dotnet ='C:\\Program Files (x86)\\dotnet\\'
        }

    stages{
    stage('Restore packages'){
        steps{
        echo "Getting Nuget packages ..."
        bat "dotnet restore --configfile D:/Jenkins_home/workspace/Co2_master@script/Co2-calc/nuget.config"
        }
    }
    stage('Build'){
    steps{
	echo "Building the project ..."
      bat "dotnet build D:/Jenkins_home/workspace/Co2_master@script/CO2-calc.sln"
    }
   }
   stage('Test'){
   steps{
      bat "dotnet test D:/Jenkins_home/workspace/Co2_master@script/CO2-calc-Test/bin/Debug/CO2-calc-Test.dll"
    }
   }
  }
 }