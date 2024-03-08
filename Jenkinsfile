@Library('github.com/releaseworks/jenkinslib') _
pipeline {
    agent any
     options {
        // Use .NET SDK Support plugin build wrapper
        dotnetSdkInstaller(version:'1.4.0')
    }
    stages {
      
        
        stage('Restore') {
            steps {
               dotnetRestore()
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
