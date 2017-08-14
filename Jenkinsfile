#!/usr/bin/env groovy

pipeline {
    agent any
    stages {
        stage('Build') {
            node {
                checkout scm
                stash 'everything'
                dir('src/TheRebelsMusicWeb') {
                bat 'dotnet restore'
                bat "dotnet build --version-suffix ${env.BUILD_NUMBER}"
                }
            }
        }
    }
    post {
        always {
            echo 'This will always run'
        }
        success {
            echo 'This will run only if successful'
        }
        failure {
            echo 'This will run only if failed'
        }
        unstable {
            echo 'This will run only if the run was marked as unstable'
        }
        changed {
            echo 'This will run only if the state of the Pipeline has changed'
            echo 'For example, if the Pipeline was previously failing but is now successful'
        }
    }
}