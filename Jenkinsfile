@Library('github.com/releaseworks/jenkinslib') _
pipeline {
    agent any
    
    stages {
      
        
        stage('Restore') {
            steps {
                script {
                    sh  '"dotnet" restore'
                }
            }
        }
        
        stage('Build') {
            steps {
                script {
                    sh  '"dotnet" build'
                }
            }
        }
        
        stage('Test') {
            steps {
                script {
                    sh  '"dotnet" test'
                }
            }
        }
        
        stage('Publish') {
            steps {
                script {
                    sh  '"dotnet" publish -c Release -o ./publish'
                }
            }
        }
    }
}
