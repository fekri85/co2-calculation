pipeline{
    agent any
    environment {
        dotnet ='C:\\Program Files (x86)\\dotnet\\'
        }
    stages{
    stage('Restore packages'){
        steps{
        echo "Getting Nuget packages ..."
	bat "dotnet restore %workspace%/co2-calculation.sln"
        }
    }
    stage('Build'){
    steps{
      echo "Building the project ..."
      bat "dotnet build %workspace%/co2-calculation.sln"
    }
   }
   stage('Test'){
   steps{
      echo "Running sample test ..."	   
      bat "dotnet test %workspace%/co2-calculation-test/bin/Debug/netcoreapp3.1/co2-calculation-test.dll"
    }
   }
  }
 }
