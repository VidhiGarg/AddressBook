SET IDENTITY_INSERT [dbo].[Addresses] ON
INSERT INTO [dbo].[Addresses] ([Id], [Line1], [Line2], [Line3], [City], [County], [PostCode]) VALUES (1, N'18/2 Wall Street', NULL, NULL, N'Greenwich', NULL, N'GRE182')
INSERT INTO [dbo].[Addresses] ([Id], [Line1], [Line2], [Line3], [City], [County], [PostCode]) VALUES (2, N'123 Oxford Strret', NULL, NULL, N'Edinburgh', NULL, N'EH123')
INSERT INTO [dbo].[Addresses] ([Id], [Line1], [Line2], [Line3], [City], [County], [PostCode]) VALUES (3, N'234 Rose Street', NULL, NULL, N'Newcastle', NULL, N'NC234')
SET IDENTITY_INSERT [dbo].[Addresses] OFF
