SET IDENTITY_INSERT [dbo].[Car] ON
INSERT INTO [dbo].[Car] ([Id], [Car_Name], [Car_Make], [Car_Price]) VALUES (1, N'Audi', N'2000', N'1266789')
INSERT INTO [dbo].[Car] ([Id], [Car_Name], [Car_Make], [Car_Price]) VALUES (2, N'Range', N'2009', N'25667879')
INSERT INTO [dbo].[Car] ([Id], [Car_Name], [Car_Make], [Car_Price]) VALUES (3, N'Jeep', N'2019', N'20000008')
SET IDENTITY_INSERT [dbo].[Car] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON
INSERT INTO [dbo].[Staff] ([Id], [Staff_Name], [Staff_Address], [Staff_Contact]) VALUES (1, N'Jey', N'Hamilton', N'022566787')
INSERT INTO [dbo].[Staff] ([Id], [Staff_Name], [Staff_Address], [Staff_Contact]) VALUES (2, N'Mil', N'Auckland', N'022678899')
INSERT INTO [dbo].[Staff] ([Id], [Staff_Name], [Staff_Address], [Staff_Contact]) VALUES (3, N'Sit', N'Auckland', N'0225667898')
SET IDENTITY_INSERT [dbo].[Staff] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([Id], [Customer_Name], [Customer_Address], [Customer_Contact], [StaffID]) VALUES (1, N'Ink', N'Auckland', N'0226778909', 1)
INSERT INTO [dbo].[Customer] ([Id], [Customer_Name], [Customer_Address], [Customer_Contact], [StaffID]) VALUES (2, N'Den', N'Auckland', N'022778990', 2)
INSERT INTO [dbo].[Customer] ([Id], [Customer_Name], [Customer_Address], [Customer_Contact], [StaffID]) VALUES (3, N'Jit', N'Auckland', N'0226778909', 3)
SET IDENTITY_INSERT [dbo].[Customer] OFF
