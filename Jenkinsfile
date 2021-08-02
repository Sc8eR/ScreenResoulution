pipeline {
  agent any
  stages {
    stage('build the app') {
      steps {
        echo 'This is a build stage'
      }
    }

    stage('test the app') {
      steps {
        fileExists 'App123.xml'
        echo 'This is a test stage'
      }
    }

    stage('deploy the app') {
      steps {
        echo 'This is a deploy stage'
      }
    }

  }
}