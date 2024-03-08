@Library('github.com/releaseworks/jenkinslib') _
pipeline {
    agent any
    
    stages {
      
        
        stage('Restore') {
            steps {
                script {
                    bat '"dotnet" restore'
                }
            }
        }
        
        stage('Build') {
            steps {
                script {
                    bat '"dotnet" build'
                }
            }
        }
        
        stage('Test') {
            steps {
                script {
                    bat '"dotnet" test'
                }
            }
        }
        
        stage('Publish') {
            steps {
                script {
                    bat '"dotnet" publish -c Release -o ./publish'
                }
            }
        }
    }
}
