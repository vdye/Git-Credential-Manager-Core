*** Settings ***
Documentation	A test suite for verifying functionality of GCM Core with Git
Library			OperatingSystem
Library			Process
Test Teardown	Run Keyword And Ignore Error	Remove Directory	${workspace} 	recursive = true

*** Test Cases ***
Clone public GitHub repository
	${uuid} =					Evaluate		str(uuid.uuid4())[:8]	modules=uuid
	${workspace} =				Set Variable	${CURDIR}/../../../out/test/${uuid}
	Create Directory			${workspace}
	${result} =					Run Process		git	-C	${workspace}	clone	https://github.com/microsoft/Git-Credential-Manager-Core.git	test-repo
	Should Be Equal As Integers	${result.rc}	0
	${result} =					Run Process		git	-C	${workspace}/test-repo	status
	Should Be Equal As Integers	${result.rc}	0