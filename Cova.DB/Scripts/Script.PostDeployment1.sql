/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO Usuario(Usuario, Password, UltimoLogin)
VALUES
('TestUser', '61-3E-5A-EB-44-D9-F5-C9-24-35-B6-1C-DB-28-43-F6', GETDATE());

GO
