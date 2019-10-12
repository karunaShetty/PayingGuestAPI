USE [PGStayBusiness]
GO


select * from tbl_pgsb_code_values
select * from tbl_pgsb_users
select * from tbl_pgdb_users_info
select * from tbl_pgsb_paying_guest_homestay


INSERT INTO [dbo].[tbl_pgsb_code_values]
           ([code]
           ,[code_value_type]
           ,[code_value]
           ,[code_value_desc]
           ,[created_date]
           ,[created_by]
           ,[delete_ind]
           ,[active_ind]
           ,[code_value_id])
     VALUES
           (1
           ,'Country'
           ,'India'
           ,'India'
           ,GETDATE()
           ,0
           ,0
           ,1
           ,2)
GO



INSERT INTO [dbo].[tbl_pgsb_code_values]
           ([code]
           ,[code_value_type]
           ,[code_value]
           ,[code_value_desc]
           ,[created_date]
           ,[created_by]
           ,[delete_ind]
           ,[active_ind]
           ,[code_value_id]
		   ,parent_code_value_id)
     VALUES
           (1
           ,'State'
           ,'Karnataka'
           ,'Karnataka'
           ,GETDATE()
           ,0
           ,0
           ,1
           ,3
		   ,2)
GO


INSERT INTO [dbo].[tbl_pgsb_code_values]
           ([code]
           ,[code_value_type]
           ,[code_value]
           ,[code_value_desc]
           ,[created_date]
           ,[created_by]
           ,[delete_ind]
           ,[active_ind]
           ,[code_value_id]
		   ,parent_code_value_id)
     VALUES
           (1
           ,'City'
           ,'Bengaluru'
           ,'Bengaluru City'
           ,GETDATE()
           ,0
           ,0
           ,1
           ,4
		   ,3)
GO


INSERT INTO [dbo].[tbl_pgsb_code_values]
           ([code]
           ,[code_value_type]
           ,[code_value]
           ,[code_value_desc]
           ,[created_date]
           ,[created_by]
           ,[delete_ind]
           ,[active_ind]
           ,[code_value_id]
		   ,parent_code_value_id)
     VALUES
           (1
           ,'Area'
           ,'Bellandur'
           ,'Bellandur '
           ,GETDATE()
           ,0
           ,0
           ,1
           ,5
		   ,4)
GO



INSERT INTO [dbo].[tbl_pgsb_code_values]
           ([code]
           ,[code_value_type]
           ,[code_value]
           ,[code_value_desc]
           ,[created_date]
           ,[created_by]
           ,[delete_ind]
           ,[active_ind]
           ,[code_value_id]
		   ,parent_code_value_id)
     VALUES
           (1
           ,'Pincode'
           ,'560103'
           ,'Bellandur 560103 '
           ,GETDATE()
           ,0
           ,0
           ,1
           ,6
		   ,5)
GO


INSERT INTO [dbo].[tbl_pgsb_code_values]
           ([code]
           ,[code_value_type]
           ,[code_value]
           ,[code_value_desc]
           ,[created_date]
           ,[created_by]
           ,[delete_ind]
           ,[active_ind]
           ,[code_value_id])
     VALUES
           (1
           ,'User'
           ,'Admin'
           ,'Administrator'
           ,GETDATE()
           ,0
           ,0
           ,1
           ,1)
GO


INSERT INTO [dbo].[tbl_pgsb_users]
           ([user_id]
           ,[user_login_key]
           ,[user_type_code]
           ,[created_date]
           ,[delete_ind]
           ,[active_ind]
           ,[modfied_ind]
           ,[created_by])
       
     VALUES
           ('db61043e-99c2-49d6-b28e-e4317e1cb653'
           ,'0c768bbb-2b46-40d2-bbe1-75ba718339bf'
           ,1
           ,GETDATE()
           ,0
           ,1
           ,0
           ,0)
           
GO



INSERT INTO [dbo].[tbl_pgdb_users_info]
           ([user_id]
           ,[first_name]
           ,[last_name]
           ,[middle_name]
           ,[full_name]
           ,[address_line_1]
           ,[address_line_2]
           ,[pin_code]
           ,[phone_number]
           ,[emailId]
           ,[created_date]
           ,[created_by]
           ,[delete_ind]
           ,[active_ind]
           ,[area_code]
           ,[city_code]
           ,[state_code]
           ,[country_code])
     VALUES
           ('db61043e-99c2-49d6-b28e-e4317e1cb653'
           ,'Prabal'
           ,'Shetty'
           ,'K'
           ,'Prabal Shetty'
           ,'Block 14'
           ,'ECOSPACE'
           ,1
           ,'8856856989'
           ,'prabale@hene.com'
           ,GETDATE()
           ,0
           ,0
           ,1
           ,1
           ,1
           ,1
           ,1)
GO


