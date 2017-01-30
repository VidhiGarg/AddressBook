SET IDENTITY_INSERT [dbo].[ContactAddresses] ON
INSERT INTO [dbo].[ContactAddresses] ([Id], [ContactId], [AddressId], [AddressType]) VALUES (1, 1, 1, 1)
INSERT INTO [dbo].[ContactAddresses] ([Id], [ContactId], [AddressId], [AddressType]) VALUES (2, 2, 2, 1)
INSERT INTO [dbo].[ContactAddresses] ([Id], [ContactId], [AddressId], [AddressType]) VALUES (3, 1, 3, 2)
SET IDENTITY_INSERT [dbo].[ContactAddresses] OFF
