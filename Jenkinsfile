pipeline {
    agent any
    
    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/webtonic/red-and-yellow-student-registration-api.git'
            }
        }
        
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
