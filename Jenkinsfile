@Library('github.com/releaseworks/jenkinslib') _
pipeline {
    agent any
  
    stages {
      
         tools {
        // Define the .NET SDK tool
         netSDK
        dotnet 'dotnet-sdk-6.0.27' // This is just an example version, replace it with the version you need
    }
        stage('Restore') {
            steps {
                dotnetRestore
            }
        }
        
        stage('Build') {
            steps {
                    dotnetBuild             
            }
        }
        
        stage('Test') {
            
                steps {
                   dotnetTest
            }
            
        }
        
        stage('Publish') {
            steps {
               dotnetPublish
            }
        }
    }
}
