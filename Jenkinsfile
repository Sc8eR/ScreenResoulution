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
			if (fileExists('ScreenResolution.sln')){
				  echo 'Test stage OK'
				}
        else {
          echo 'Test stage FAILED'
        }
      }
    }

    stage('deploy the app') {
      steps {
        echo 'This is a deploy stage'
      }
    }

  }
}