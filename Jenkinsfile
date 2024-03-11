@Library('github.com/releaseworks/jenkinslib') _

pipeline {
    agent any
  
    stages {
        stage('Setup') {
            steps {
                // Define the .NET SDK tool
                tool name: 'dotnet-sdk-6.0.27', type: 'netSDK'
            }
        }

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
