# Aplicativo-de-Cartao

O Aplicativo Permite você Adicionar, Alterar é Remover pessoas da DataBase, a ideia seria fazer como um leitor de onibus ou ate mesmo de banco.

Para que o Aplicativo Funcione Corretamente você precisa:

# MySql.Data.MySqlClient 
- que você pode encontrar em: https://dev.mysql.com/downloads/connector/net/
- ao instalar verifique se ele esta adicionado nas referencias do seu projeto, caso você não o encontre nas extensoes adicione ele manualmente: 'C:\Program Files (x86)\MySQL\MySQL Connector NET 8.3.0\MySql.Data.dll' 
 
# XAMPP (ou outro programa que faça a mesma função)
- Ligue o Apache é o MySQL 
- por padrão use localhost/phpmyadmin para acessar a DataBase

o aplicativo verifica automaticamente se você tem conexão com a Database, Caso você não tenha ele ira Avisar com um MessageBox de Erro.
a verificação é feita em uma Task separada, assim evitando travamentos no Programa Principal.

