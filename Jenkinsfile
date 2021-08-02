pipeline {
  agent any
  stages {
    stage("build the app") {
      steps {
        echo 'This is a build stage'
      }
    }

    stage("test the app") {
      when {
        expression {
          BRANCH_NAME == 'master'
        }
      }
          steps {
            
            echo "${GIT_CHECKOUT_DIR}"
      }
    }

    stage("deploy the app") {
      steps {
        echo 'This is a deploy stage'
      }
    }

  }
}
