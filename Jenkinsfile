@Library('github.com/releaseworks/jenkinslib') _

pipeline {
    agent any
   tools {
        // Define the .NET SDK tool
        dotnet 'dotnet-sdk-6.0.27'
    }

    stages {
       

        stage('Restore') {
            steps {
                dotnetRestore()
            }
        }
        
        stage('Build') {
            steps {
                dotnetBuild()
            }
        }
        
        stage('Test') {
            steps {
                dotnetTest()
            }
        }
        
        stage('Publish') {
            steps {
                dotnetPublish()
            }
        }
    }
}
