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
        echo 'This is a test stage'
        fileExists 'App123.xml'
      }
    }

    stage('deploy the app') {
      steps {
        echo 'This is a deploy stage'
      }
    }

  }
}