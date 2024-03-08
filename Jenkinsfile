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
