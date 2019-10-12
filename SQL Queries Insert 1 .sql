USE [PGStayBusiness]
GO

INSERT INTO [dbo].[tbl_pgsb_paying_guest_homestay]
           ([pg_id]
           ,[name]
           ,[owner_name]
           ,[incharge_id]
           ,[contact_phone_number]
           ,[email_id]
           ,[address_line_1]
           ,[address_line_2]
           ,[pin_code]
           ,[area_code]
           ,[city_code]
           ,[state_code]
           ,[country_code]
           ,[created_date]
           ,[created_by]
           ,[delete_ind]
           ,[active_ind])
     VALUES
           ('f65fea1a-5836-46a3-be47-17db43960ff9'
           ,'Suraksha PG'
           ,'Suraksha Hegde'
           ,'db61043e-99c2-49d6-b28e-e4317e1cb653'
           
           ,'8854581125'
           ,'thsuru@gmail.com'
           ,'5th street , Daya Complex'
           ,'Near Ecospace'
           ,1
           ,1
           ,1
           ,1
           ,1
           ,GETDATE()
           ,0
           ,0
           ,1)
GO


INSERT INTO [dbo].[tbl_pgsb_paying_guest_homestay]
           ([pg_id]
           ,[name]
           ,[owner_name]
           ,[incharge_id]
           ,[contact_phone_number]
           ,[email_id]
           ,[address_line_1]
           ,[address_line_2]
           ,[pin_code]
           ,[area_code]
           ,[city_code]
           ,[state_code]
           ,[country_code]
           ,[created_date]
           ,[created_by]
           ,[delete_ind]
           ,[active_ind])
     VALUES
           ('5b5312d1-a118-49f9-bcdd-65af23b00868'
           ,'Prabal PG'
           ,'Prabal Shetty'
           ,'db61043e-99c2-49d6-b28e-e4317e1cb653'
           
           ,'86445111121'
           ,'thprab@gmail.com'
           ,'5th street , Maya Complex'
           ,'Near Ecospace'
           ,1
           ,1
           ,1
           ,1
           ,1
           ,GETDATE()
           ,0
           ,0
           ,1)
GO

