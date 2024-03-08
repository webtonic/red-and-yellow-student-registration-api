@Library('github.com/releaseworks/jenkinslib') _
pipeline {
    agent any
  
    stages {
      
        
        stage('Restore') {
            steps {
                script {
                        sh 'dotnet restore'
                    }
            }
        }
        
        stage('Build') {
            steps {
                script {
                    sh 'dotnet build'
                }
            }
        }
        
        stage('Test') {
            
                steps {
                // Run tests using dotnetTest builder
                dotnetTest()
            }
            
        }
        
        stage('Publish') {
            steps {
                // Publish the .NET project using dotnetPublish builder
                dotnetPublish()
            }
        }
    }
}
