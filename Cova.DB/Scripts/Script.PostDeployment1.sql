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
--Pwd test123
('TestUser', 'CC-03-E7-47-A6-AF-BB-CB-F8-BE-76-68-AC-FE-BE-E5', GETDATE());

GO
