@Library('github.com/releaseworks/jenkinslib') _
pipeline {
    agent any
  
    stages {
      
        
        stage('Restore') {
            steps {
                dotnetRestore()
            }
        }
        
        stage('Build') {
            steps {
                script {
                    sh 'dotnetBuild'
                }
            }
        }
        
        stage('Test') {
            
                steps {
           
                sh 'dotnetTest'
            }
            
        }
        
        stage('Publish') {
            steps {
                // Publish the .NET project using dotnetPublish builder
               sh 'dotnetPublish'
            }
        }
    }
}
