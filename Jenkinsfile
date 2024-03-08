@Library('github.com/releaseworks/jenkinslib') _
pipeline {
    agent any
    
    stages {
      
        
        stage('Restore') {
            steps {
                script {
                    bat   '"dotnetRestore'
                }
            }
        }
        
        stage('Build') {
            steps {
                script {
                    bat   '"dotnetBuild'
                }
            }
        }
        
        stage('Test') {
            steps {
                script {
                    bat   '"dotnetTest'
                }
            }
        }
        
        stage('Publish') {
            steps {
                script {
                    bat   '"dotnetPublish" publish -c Release -o ./publish'
                }
            }
        }
    }
}
