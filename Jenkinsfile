pipeline{
    agent any
    environment {
        dotnet ='C:\\Program Files (x86)\\dotnet\\'
        }

    stages{
    stage('Restore packages'){
        steps{
        echo "Getting Nuget packages ..."
        bat "dotnet restore D:/Jenkins_home/workspace/Co2-Calculation_master/co2-calculation/co2-calculation.csproj"
        }
    }
    stage('Build'){
    steps{
	echo "Building the project ..."
      bat "dotnet build D:/Jenkins_home/workspace/Co2-Calculation_master/co2-calculation/co2-calculation.csproj"
    }
   }
   stage('Test'){
   steps{
      bat "dotnet test D:/Jenkins_home/workspace/Co2-Calculation_master/co2-calculation.dll"
    }
   }
  }
 }
