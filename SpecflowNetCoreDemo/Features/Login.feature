#language: pt-br
Funcionalidade: Login
	Login na aplicação Demo EA

@smoke
Cenario: Login na aplicação Demo EA
	Dado que o usario acessa a pagina "http://eaapp.somee.com/"
	E clica no elemento "Login" do tipo "ByLinkText"
	Quando entra com os seguintes campos
		| Valor    | Seletor  | Tipo |
		| admin    | UserName | ById |
		| password | Password | ById |
	E clica no elemento ".btn-default" do tipo "ByCssSelector"
	Entao valida se o elemento "Employee Details" do tipo "ByLinkText" esta visivel

@smoke
Cenario: Login na aplicação Demo EA com dado errado
	Dado que o usario acessa a pagina "http://eaapp.somee.com/"
	E clica no elemento "Login" do tipo "ByLinkText"
	Quando entra com os seguintes campos
		| Valor     | Seletor  | Tipo |
		| admin     | UserName | ById |
		| passwordm | Password | ById |
	E clica no elemento ".btn-default" do tipo "ByCssSelector"
	Entao valida a mensagem no elemento ".validation-summary-errors>ul>li" do tipo "ByCssSelector" com o texto "Invalid login attempt."