@Library('github.com/releaseworks/jenkinslib') _
pipeline {
    agent any
     options {
        // Use .NET SDK Support plugin build wrapper
        dotnetSdkInstaller()
    }
    stages {
      
        
        stage('Restore') {
            steps {
               dotnetRestore()
            }
        }
        
        stage('Build') {
            steps {
              // Build the .NET project using dotnetBuild builder
                dotnetBuild()
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
