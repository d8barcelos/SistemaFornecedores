
Sistema de Gerenciamento de Fornecedores
Este é um projeto de aplicação web desenvolvida em ASP.NET Core MVC que visa simplificar o gerenciamento de informações de fornecedores. A aplicação oferece recursos completos para listar, cadastrar, editar e excluir fornecedores, além de integrar-se a uma API de consulta de CEP para preenchimento automático de endereços.

Principais Recursos e Funcionalidades
Listagem de Fornecedores:

A página inicial apresenta uma lista completa de todos os fornecedores cadastrados, exibindo informações essenciais, como nome e especialidade.
Cadastro de Fornecedores:

Os usuários podem adicionar novos fornecedores preenchendo um formulário intuitivo que inclui campos como nome, CNPJ, especialidade e CEP.
A integração com uma API de consulta de CEP permite o preenchimento automático de informações de endereço ao inserir o CEP.
Edição de Fornecedores:

É possível editar informações de fornecedores existentes, como nome, CNPJ, especialidade e endereço.
O sistema verifica a validade dos dados inseridos e fornece feedback imediato ao usuário.
Exclusão de Fornecedores:

Os fornecedores podem ser removidos da lista com facilidade. O sistema garante a integridade dos dados e confirma a exclusão antes de prosseguir.
Validação de Dados:

O projeto incorpora validações de dados, como campos obrigatórios, formatação correta de CNPJ e CEP, e mensagens de erro personalizadas em caso de entrada inválida.
Feedback Visual:

O sistema utiliza TempData para fornecer mensagens de feedback ao usuário, informando sobre o sucesso ou falha das operações de cadastro, edição e exclusão.
Tecnologias Utilizadas
ASP.NET Core MVC: Estrutura robusta para o desenvolvimento web.
Entity Framework Core: Mapeamento de objetos C# para o banco de dados.
Integração com API de CEP: Consulta de informações de endereço.
jQuery: Facilita a interação com a API de CEP.
Bootstrap: Estilização e responsividade para uma experiência de usuário agradável

Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas, propor melhorias ou enviar solicitações de pull request.
