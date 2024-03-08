@Library('github.com/releaseworks/jenkinslib') _
pipeline {
    agent any
    
    stages {
      
        
        stage('Restore') {
            steps {
                script {
                    sh   'dotnetRestore'
                }
            }
        }
        
        stage('Build') {
            steps {
                script {
                    sh   'dotnetBuild'
                }
            }
        }
        
        stage('Test') {
            steps {
                script {
                    sh   'dotnetTest'
                }
            }
        }
        
        stage('Publish') {
            steps {
                script {
                    sh   'dotnetPublish publish -c Release -o ./publish'
                }
            }
        }
    }
}
