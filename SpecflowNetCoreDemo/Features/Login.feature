#language: pt-br
Funcionalidade: Login
	Login na aplicação Demo EA

@smoke
Cenario: Login na aplicação Demo EA
	Dado Eu subo a aplicacao
	E Eu Clico no link login
	E Eu entro com os seguintes detalhes
		| UserName | Password |
		| admin    | password |
	E Eu clico no botao de login
	Entao Eu deveria ver o link Employee details

@smoke
Cenario: Login na aplicação Demo EA com dado errado
	Dado Eu subo a aplicacao
	E Eu Clico no link login
	E Eu entro com os seguintes detalhes
		| UserName | Password |
		| admin    | passwordm |
	E Eu clico no botao de login
	Entao Eu deveria a messagem de erro