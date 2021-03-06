USE [ZhpGame]
GO
/****** Object:  Table [dbo].[Zhp_WxUserInfo]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zhp_WxUserInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[openid] [nvarchar](100) NULL,
	[nickname] [nvarchar](50) NULL,
	[sex] [nvarchar](2) NULL,
	[language] [nvarchar](10) NULL,
	[city] [nvarchar](32) NULL,
	[province] [nvarchar](32) NULL,
	[country] [nvarchar](32) NULL,
	[headimgurl] [text] NULL,
 CONSTRAINT [PK_ZHP_WXUSERINFO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Zhp_WxUserInfo] ON
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (2, N'omJcruMrU2DqG5oIx6fTXbs07mGM', N'你眼睛很漂亮', N'1', N'zh_CN', N'西雅图', N'华盛顿', N'美国', N'http://wx.qlogo.cn/mmopen/HmVQlX9WkBuaN8ElhSCu63uX3AnSiadxGiaficymqdzwfJ7icbLlJr8wJfp1WaejjAjnUtJzfEDeZIcg9jZUNh392SauLib8hKiaiab/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (3, N'omJcruMFCO-X_MYDwVQWBQgWdq74', N'Jason', N'1', N'zh_CN', N'成都', N'四川', N'中国', N'http://wx.qlogo.cn/mmopen/dTHvRECJ7VlKtwSoW8gZW0PMO2mic0Hpqtopibs4vxWanzXXY4Vic8Wc9Ikoddqs77oLIzMjibrGH07ibZdloAT0f7ibiclNHgdibXdB/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (4, N'omJcruI1DF1lqTEwtmfiVT21BhO8', N'miss 涂', N'2', N'zh_CN', N'成都', N'四川', N'中国', N'http://wx.qlogo.cn/mmopen/HmVQlX9WkBukCjPZxPFoCEpTkiaTYYsVbWedH72icharzMNsRxkgpMpUkicwqZtW3NKY2s5Ngicc3icfov8SSGZEvA3VkH3Sq3CH4/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (5, N'omJcruMSo_al_vHgI7dQHdixsPEM', N'RandyField', N'1', N'zh_CN', N'成都', N'四川', N'中国', N'http://wx.qlogo.cn/mmopen/zXpIibbHTwML5lsTibibccKl9BYViapDib43LaD36ib4VfxoTdCzj03WT81H10G4ibwhTU0PeE17lEDlr1goGNnDUKVLzLcS1bVwTSk/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (6, N'omJcruAigKmCMH-L2ouNz6Cc5sns', N'德', N'1', N'zh_CN', N'', N'', N'卡塔尔', N'http://wx.qlogo.cn/mmopen/TXKOIp2ibnGdntHWYiah0ibyPHT0fehwQsD3MfiaY2ZyOicFicCLg2EStS2L0C3l5bmObiavUqo0lgZ5TzVhiap5IlvKrcdfOQejYINQ/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (7, N'omJcruCiri6gs0Nr_njKzN0hob5Q', N'南一', N'2', N'zh_CN', N'', N'', N'希腊', N'http://wx.qlogo.cn/mmopen/dTHvRECJ7VnGbtoXyAyYTTvwwV3yTuexAAbZxV5x6EeUo2OcD2BibWfibY2aTcjjzo5nEHg4sAt3esc5CdYVgGyLBZHYe2FxE3/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (8, N'omJcruF6xKEPln-Nqa-Hv5uenz5c', N'呵呵哈哈', N'1', N'zh_CN', N'成都', N'四川', N'中国', N'http://wx.qlogo.cn/mmopen/s3NSsjicZ4xHzJY0wXQ8tL0qbwichnZQK8bD00FP88Rw6Gm83KhZnzNgmibrOb5XFicibRybDicA0Z25neBEJibqNqOicAMp5pGslo8o/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (9, N'omJcruFWgeplWNp6K7r9BAnE_HkI', N'A-随遇而安づ', N'1', N'zh_CN', N'', N'', N'冰岛', N'http://wx.qlogo.cn/mmopen/Q3auHgzwzM555um9PnebqCDPnia61mUoyTFnWC4rw7aejicmdEPIxNACNvQicSjNGsibLjxglJyic03fEtEcHtib5gtw/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (10, N'omJcruI667USgXzTdeJNCTjkcyqk', N'茳蓠', N'2', N'zh_CN', N'德阳', N'四川', N'中国', N'http://wx.qlogo.cn/mmopen/x6d7lnicM0iaesRJoP5hFWdia7icZPjVDFfKNCaYA7GvmOj7eQ4zmOmiauBZge8SCOnFVT0KsCso5NlQFWP4SdSYxfA/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (11, N'omJcruG1jdvqNtz-qYIig9BUO-ug', N'无求°', N'2', N'zh_CN', N'', N'', N'安道尔', N'http://wx.qlogo.cn/mmopen/PiajxSqBRaEJ12k2OYickVAoYhGwzZGEaDGQkHtXpCPnPsXMB8vcicSFIcmHeQ1el2JgMGFkOnecAYFJOfA263CBA/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (12, N'omJcruLBrgV-DyL3OlpyMnxjBIT0', N'洋芋雨鱼鱼', N'2', N'zh_CN', N'成都', N'四川', N'中国', N'http://wx.qlogo.cn/mmopen/HmVQlX9WkBtPaCbv64Q5QboKELqj2VQiagR1d9XuuzBno8E3wIn3Z3xbHuiaXUBGOsOEiaer4YynxrjlqcLsw2VareoSAmKicRWY/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (13, N'omJcruHkZOFJWIdJAdgKQw39Pyaw', N'🍀Nier🍀', N'2', N'zh_CN', N'', N'四川', N'中国', N'http://wx.qlogo.cn/mmopen/Q3auHgzwzM5r2ogic7Jv7SKGEGNvu9T4DsgQaRsgvXX8fMgU0KEaQiasvibhGHg9tsR8lnEHqYv1CoEeBRXZpI2SuTSdz6fOeSKFaQUWQ7tQ28/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (14, N'omJcruIao_TVv5XjrVrMBQHETL4k', N'夏小火', N'2', N'zh_CN', N'成都', N'四川', N'中国', N'http://wx.qlogo.cn/mmopen/ajNVdqHZLLDzVx2pUHibVDznUv5v2SwSjeChtIkvUB0ccvXSOk1h3XlXDyBOToHo8SFmEeOL5ibjLadv0uehnYLw/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (15, N'omJcruDpH4RkEeKZ2fBry_VgkHk4', N'烛光氤氲', N'2', N'zh_CN', N'巴中', N'四川', N'中国', N'http://wx.qlogo.cn/mmopen/C2muJ7LfENTKO0BXicueEbCQ0vNkF7QRjCh7GIs1OYhpWRicomuoegDdTFVYn9YeGbINn9JPy2nQh8CbqLL5BGzAFFg5E8tuqj/0')
INSERT [dbo].[Zhp_WxUserInfo] ([ID], [openid], [nickname], [sex], [language], [city], [province], [country], [headimgurl]) VALUES (16, N'omJcruFLEE6E6dMrv27R4f5oNzdI', N'', N'2', N'zh_CN', N'乌鲁木齐', N'新疆', N'中国', N'http://wx.qlogo.cn/mmopen/ajNVdqHZLLBXYM1WevDLOnrJMg4ORIqZGpAFyZX6EGWAcMy6TQWBpGg8MwNkNv4OGDeHfA13jyspdcAmCbSDag/0')
SET IDENTITY_INSERT [dbo].[Zhp_WxUserInfo] OFF
/****** Object:  Table [dbo].[Zhp_OnlineGame]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zhp_OnlineGame](
	[Gameid] [int] IDENTITY(1,1) NOT NULL,
	[GameCode] [nvarchar](32) NULL,
	[GameStartTime] [datetime] NULL,
	[GameEndTime] [datetime] NULL,
	[Remark] [text] NULL,
 CONSTRAINT [PK_ZHP_ONLINEGAME] PRIMARY KEY CLUSTERED 
(
	[Gameid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Zhp_OnlineGame] ON
INSERT [dbo].[Zhp_OnlineGame] ([Gameid], [GameCode], [GameStartTime], [GameEndTime], [Remark]) VALUES (5, N'game004', CAST(0x0000A7BD00BB11D8 AS DateTime), CAST(0x0000AD7300BB5120 AS DateTime), NULL)
INSERT [dbo].[Zhp_OnlineGame] ([Gameid], [GameCode], [GameStartTime], [GameEndTime], [Remark]) VALUES (6, N'game0168', CAST(0x0000A7BD00E496C0 AS DateTime), CAST(0x0000AC0600E49A44 AS DateTime), NULL)
INSERT [dbo].[Zhp_OnlineGame] ([Gameid], [GameCode], [GameStartTime], [GameEndTime], [Remark]) VALUES (7, N'game015', CAST(0x0000A7DB00000000 AS DateTime), CAST(0x0000A7DC018B80D4 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Zhp_OnlineGame] OFF
/****** Object:  Table [dbo].[Zhp_GameRecord]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zhp_GameRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Gameid] [int] NULL,
	[PlayerScore] [nvarchar](32) NULL,
	[PlayerNickname] [nvarchar](124) NULL,
	[Headimgurl] [text] NULL,
	[PlayerOpenId] [nvarchar](124) NULL,
	[ComputerName] [nvarchar](32) NULL,
	[PlayerPhone] [nvarchar](15) NULL,
	[RecordType] [nvarchar](3) NULL,
	[QRCode] [nvarchar](50) NULL,
	[UploadTime] [datetime] NULL,
	[SaveTime] [datetime] NULL,
 CONSTRAINT [PK_ZHP_GAMERECORD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Zhp_GameRecord] ON
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (1, 7, N'30', N'德', N'http://wx.qlogo.cn/mmopen/TXKOIp2ibnGdntHWYiah0ibyPHT0fehwQsD3MfiaY2ZyOicFicCLg2EStS2L0C3l5bmObiavUqo0lgZ5TzVhiap5IlvKrcdfOQejYINQ/0', N'omJcruAigKmCMH-L2ouNz6Cc5sns', N'C010207B1031300', N'15882291503', N'002', N'369E57AD-4D4C-C035-EFCB-1C924490700D', CAST(0x0000A7DB00A81038 AS DateTime), CAST(0x0000A7DB00A87E90 AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (2, 7, N'49', N'RandyField', N'http://wx.qlogo.cn/mmopen/zXpIibbHTwML5lsTibibccKl9BYViapDib43LaD36ib4VfxoTdCzj03WT81H10G4ibwhTU0PeE17lEDlr1goGNnDUKVLzLcS1bVwTSk/0', N'omJcruMSo_al_vHgI7dQHdixsPEM', N'C010101AZ000000', N'13880825220', N'003', N'4CBA2E66-4A6C-EB79-68BC-91F8DA50FC57', CAST(0x0000A7DB00BDA6C8 AS DateTime), CAST(0x0000A7DB00BF157E AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (3, 7, N'23', N'南一', N'http://wx.qlogo.cn/mmopen/dTHvRECJ7VnGbtoXyAyYTTvwwV3yTuexAAbZxV5x6EeUo2OcD2BibWfibY2aTcjjzo5nEHg4sAt3esc5CdYVgGyLBZHYe2FxE3/0', N'omJcruCiri6gs0Nr_njKzN0hob5Q', N'C010216B1081300', N'18200396669', N'003', N'523785B9-0372-A498-844C-259BDDAF4989', CAST(0x0000A7DB00C14F1C AS DateTime), CAST(0x0000A7DB00C1A14A AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (4, 7, N'20', N'RandyField', N'http://wx.qlogo.cn/mmopen/zXpIibbHTwML5lsTibibccKl9BYViapDib43LaD36ib4VfxoTdCzj03WT81H10G4ibwhTU0PeE17lEDlr1goGNnDUKVLzLcS1bVwTSk/0', N'omJcruMSo_al_vHgI7dQHdixsPEM', N'C010101AZ000000', N'13880825220', N'001', N'4CBA2E66-4A6C-EB79-68BC-91F8DA50FC58', CAST(0x0000A7DB00BDA6C8 AS DateTime), CAST(0x0000A7DB00C42F5F AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (5, 7, N'20', N'RandyField', N'http://wx.qlogo.cn/mmopen/zXpIibbHTwML5lsTibibccKl9BYViapDib43LaD36ib4VfxoTdCzj03WT81H10G4ibwhTU0PeE17lEDlr1goGNnDUKVLzLcS1bVwTSk/0', N'omJcruMSo_al_vHgI7dQHdixsPEM', N'C010101AZ000000', N'13880825220', N'002', N'4CBA2E66-4A6C-EB79-68BC-91F8DA50FC59', CAST(0x0000A7DB00BDA6C8 AS DateTime), CAST(0x0000A7DB00C49195 AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (6, 7, N'37', N'呵呵哈哈', N'http://wx.qlogo.cn/mmopen/s3NSsjicZ4xHzJY0wXQ8tL0qbwichnZQK8bD00FP88Rw6Gm83KhZnzNgmibrOb5XFicibRybDicA0Z25neBEJibqNqOicAMp5pGslo8o/0', N'omJcruF6xKEPln-Nqa-Hv5uenz5c', N'C010412B1011300', N'13699466123', N'001', N'FE743BF9-37D5-10D5-6C88-79B33D9BAED6', CAST(0x0000A7DB010F8CCC AS DateTime), CAST(0x0000A7DB0110444D AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (7, 7, N'34', N'A-随遇而安づ', N'http://wx.qlogo.cn/mmopen/Q3auHgzwzM555um9PnebqCDPnia61mUoyTFnWC4rw7aejicmdEPIxNACNvQicSjNGsibLjxglJyic03fEtEcHtib5gtw/0', N'omJcruFWgeplWNp6K7r9BAnE_HkI', N'C010216B1081300', N'18349281768', N'002', N'4188965E-1810-A3E9-D0E8-55689F1455F6', CAST(0x0000A7DB010FAC70 AS DateTime), CAST(0x0000A7DB011072DB AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (8, 7, N'27', N'茳蓠', N'http://wx.qlogo.cn/mmopen/x6d7lnicM0iaesRJoP5hFWdia7icZPjVDFfKNCaYA7GvmOj7eQ4zmOmiauBZge8SCOnFVT0KsCso5NlQFWP4SdSYxfA/0', N'omJcruI667USgXzTdeJNCTjkcyqk', N'C010401B1011300', N'18381199353', N'001', N'222F102A-DFC0-DFE0-5CAC-93820A72489A', CAST(0x0000A7DB0149DE7C AS DateTime), CAST(0x0000A7DB014A4B5F AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (9, 7, N'42', N'无求°', N'http://wx.qlogo.cn/mmopen/PiajxSqBRaEJ12k2OYickVAoYhGwzZGEaDGQkHtXpCPnPsXMB8vcicSFIcmHeQ1el2JgMGFkOnecAYFJOfA263CBA/0', N'omJcruG1jdvqNtz-qYIig9BUO-ug', N'C010118B1061300', N'13996746370', N'001', N'1FFD119A-2574-20A3-2C7D-4636C6FF78D1', CAST(0x0000A7DB014D4FBC AS DateTime), CAST(0x0000A7DB014DAF7C AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (10, 7, N'24', N'洋芋雨鱼鱼', N'http://wx.qlogo.cn/mmopen/HmVQlX9WkBtPaCbv64Q5QboKELqj2VQiagR1d9XuuzBno8E3wIn3Z3xbHuiaXUBGOsOEiaer4YynxrjlqcLsw2VareoSAmKicRWY/0', N'omJcruLBrgV-DyL3OlpyMnxjBIT0', N'C010303B1011400', N'18200161659', N'003', N'768C2766-88AA-78F6-0FC3-E124567BB426', CAST(0x0000A7DB015C870C AS DateTime), CAST(0x0000A7DB015D0128 AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (11, 7, N'37', N'🍀Nier🍀', N'http://wx.qlogo.cn/mmopen/Q3auHgzwzM5r2ogic7Jv7SKGEGNvu9T4DsgQaRsgvXX8fMgU0KEaQiasvibhGHg9tsR8lnEHqYv1CoEeBRXZpI2SuTSdz6fOeSKFaQUWQ7tQ28/0', N'omJcruHkZOFJWIdJAdgKQw39Pyaw', N'C010303B1011400', N'18613235138', N'001', N'649A481C-0388-B7E4-E991-E0C85E6F3217', CAST(0x0000A7DC00DC40C4 AS DateTime), CAST(0x0000A7DC00DCF5F3 AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (12, 7, N'18', N'夏小火', N'http://wx.qlogo.cn/mmopen/ajNVdqHZLLDzVx2pUHibVDznUv5v2SwSjeChtIkvUB0ccvXSOk1h3XlXDyBOToHo8SFmEeOL5ibjLadv0uehnYLw/0', N'omJcruIao_TVv5XjrVrMBQHETL4k', N'C010314B1011400', N'18780195973', N'003', N'539BE1D6-2BBF-342E-2568-BC2C9CE47E0E', CAST(0x0000A7DC00FB4690 AS DateTime), CAST(0x0000A7DC00FBB933 AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (13, 7, N'34', N'烛光氤氲', N'http://wx.qlogo.cn/mmopen/C2muJ7LfENTKO0BXicueEbCQ0vNkF7QRjCh7GIs1OYhpWRicomuoegDdTFVYn9YeGbINn9JPy2nQh8CbqLL5BGzAFFg5E8tuqj/0', N'omJcruDpH4RkEeKZ2fBry_VgkHk4', N'C010232B1031300', NULL, N'002', N'A9F7E39D-4F1F-F040-3D4C-86221C91FC1D', CAST(0x0000A7DC00FF5730 AS DateTime), CAST(0x0000A7DC00FFE48B AS DateTime))
INSERT [dbo].[Zhp_GameRecord] ([ID], [Gameid], [PlayerScore], [PlayerNickname], [Headimgurl], [PlayerOpenId], [ComputerName], [PlayerPhone], [RecordType], [QRCode], [UploadTime], [SaveTime]) VALUES (14, 7, N'26', N'', N'http://wx.qlogo.cn/mmopen/ajNVdqHZLLBXYM1WevDLOnrJMg4ORIqZGpAFyZX6EGWAcMy6TQWBpGg8MwNkNv4OGDeHfA13jyspdcAmCbSDag/0', N'omJcruFLEE6E6dMrv27R4f5oNzdI', N'C010232B1031300', N'18278393130', N'003', N'4FB472CA-502A-C0E0-BB25-A536DDD88288', CAST(0x0000A7DC017551EC AS DateTime), CAST(0x0000A7DC0175E7C9 AS DateTime))
SET IDENTITY_INSERT [dbo].[Zhp_GameRecord] OFF
/****** Object:  Table [dbo].[Zhp_GameCount]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zhp_GameCount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Gameid] [int] NULL,
	[Count_Type_Code] [nvarchar](30) NULL,
	[Count] [int] NULL,
	[RESERVED_1] [nvarchar](30) NULL,
	[RESERVED_2] [nvarchar](30) NULL,
	[RESERVED_3] [nvarchar](30) NULL,
 CONSTRAINT [PK_Zhp_GameCount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Zhp_GameCount] ON
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (1, 7, N'001', 289, N'C010303B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (2, 7, N'001', 286, N'C010304B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (3, 7, N'001', 253, N'C010405B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (4, 7, N'001', 279, N'C010217B1041300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (5, 7, N'001', 308, N'C010312B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (6, 7, N'001', 287, N'C010208B1031200', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (7, 7, N'001', 271, N'C010314B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (8, 7, N'001', 267, N'C010407B1031400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (9, 7, N'001', 263, N'C010216B1081300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (10, 7, N'001', 263, N'C010316B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (11, 7, N'001', 257, N'C010207B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (12, 7, N'001', 301, N'C010311B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (13, 7, N'001', 302, N'C010307B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (14, 7, N'001', 282, N'C010412B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (15, 7, N'001', 280, NULL, NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (16, 7, N'001', 275, N'C010232B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (17, 7, N'001', 273, N'C010414B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (18, 7, N'001', 273, N'C010209B1051300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (19, 7, N'001', 268, N'C010218B1041200', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (20, 7, N'001', 304, N'C010401B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (21, 7, N'001', 245, N'C010106B2041300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (22, 7, N'001', 260, N'C010118B1061300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (23, 7, N'001', 302, N'C010210B1041300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (24, 7, N'002', 11, N'C010401B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (25, 7, N'002', 36, N'C010208B1031200', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (26, 7, N'002', 29, N'C010414B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (27, 7, N'002', 6, N'C010405B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (28, 7, N'003', 15, N'C010414B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (29, 7, N'002', 41, N'C010303B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (30, 7, N'002', 8, N'C010314B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (31, 7, N'003', 6, N'C010314B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (32, 7, N'002', 52, N'C010216B1081300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (33, 7, N'003', 31, N'C010216B1081300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (34, 7, N'002', 17, N'C010207B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (35, 7, N'003', 8, N'C010207B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (36, 7, N'004', 2, N'C010207B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (37, 7, N'005', 1, N'C010207B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (38, 7, N'002', 9, N'C010304B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (39, 7, N'003', 6, N'C010304B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (40, 7, N'004', 1, N'C010304B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (41, 7, N'003', 20, N'C010208B1031200', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (42, 7, N'002', 20, N'C010312B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (43, 7, N'003', 9, N'C010312B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (44, 7, N'002', 12, N'C010412B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (45, 7, N'003', 7, N'C010412B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (46, 7, N'004', 7, N'C010101AZ000000', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (47, 7, N'005', 3, N'C010101AZ000000', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (48, 7, N'004', 6, N'C010216B1081300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (49, 7, N'005', 2, N'C010216B1081300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (50, 7, N'002', 19, N'C010311B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (51, 7, N'003', 10, N'C010311B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (52, 7, N'002', 20, N'C010106B2041300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (53, 7, N'003', 9, N'C010106B2041300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (54, 7, N'003', 27, N'C010303B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (55, 7, N'002', 23, N'C010316B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (56, 7, N'003', 13, N'C010316B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (57, 7, N'002', 12, N'C010210B1041300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (58, 7, N'003', 8, N'C010210B1041300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (59, 7, N'002', 8, N'C010217B1041300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (60, 7, N'003', 4, N'C010405B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (61, 7, N'002', 21, N'C010232B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (62, 7, N'002', 9, NULL, NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (63, 7, N'003', 6, NULL, NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (64, 7, N'003', 12, N'C010232B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (65, 7, N'003', 8, N'C010401B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (66, 7, N'002', 15, N'C010407B1031400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (67, 7, N'003', 8, N'C010407B1031400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (68, 7, N'002', 9, N'C010307B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (69, 7, N'003', 5, N'C010307B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (70, 7, N'004', 1, N'C010412B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (71, 7, N'004', 1, N'C010412B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (72, 7, N'004', 1, N'C010412B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (73, 7, N'005', 1, N'C010412B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (74, 7, N'002', 4, N'C010218B1041200', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (75, 7, N'003', 4, N'C010218B1041200', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (76, 7, N'004', 1, N'C010414B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (77, 7, N'004', 4, N'C010232B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (78, 7, N'004', 1, N'C010232B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (79, 7, N'004', 2, N'C010401B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (80, 7, N'005', 1, N'C010401B1011300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (81, 7, N'002', 6, N'C010118B1061300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (82, 7, N'003', 2, N'C010118B1061300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (83, 7, N'004', 1, N'C010118B1061300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (84, 7, N'005', 1, N'C010118B1061300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (85, 7, N'004', 2, N'C010303B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (86, 7, N'005', 2, N'C010303B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (87, 7, N'004', 1, N'C010314B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (88, 7, N'005', 1, N'C010314B1011400', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (89, 7, N'002', 1, N'C010209B1051300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (90, 7, N'003', 4, N'C010217B1041300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (91, 7, N'005', 1, N'C010232B1031300', NULL, NULL)
INSERT [dbo].[Zhp_GameCount] ([ID], [Gameid], [Count_Type_Code], [Count], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (92, 7, N'001', 2, N'C010113B1011101', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Zhp_GameCount] OFF
/****** Object:  Table [dbo].[Zhp_GameConfig]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zhp_GameConfig](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GameName] [nvarchar](32) NULL,
	[GameCode] [nvarchar](32) NULL,
	[Description] [text] NULL,
	[Remark] [text] NULL,
	[State] [nvarchar](2) NOT NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_ZHP_GAMECONFIG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Zhp_GameConfig] ON
INSERT [dbo].[Zhp_GameConfig] ([ID], [GameName], [GameCode], [Description], [Remark], [State], [CreateTime]) VALUES (4, N'连连看', N'game003', NULL, NULL, N'1', CAST(0x0000A7BD01063E6B AS DateTime))
INSERT [dbo].[Zhp_GameConfig] ([ID], [GameName], [GameCode], [Description], [Remark], [State], [CreateTime]) VALUES (5, N'打飞机', N'game004', NULL, NULL, N'1', CAST(0x0000A7BD01064E9A AS DateTime))
INSERT [dbo].[Zhp_GameConfig] ([ID], [GameName], [GameCode], [Description], [Remark], [State], [CreateTime]) VALUES (6, N'消消乐', N'game005', NULL, NULL, N'1', CAST(0x0000A7BD0107188A AS DateTime))
INSERT [dbo].[Zhp_GameConfig] ([ID], [GameName], [GameCode], [Description], [Remark], [State], [CreateTime]) VALUES (7, N'找你妹', N'game006', NULL, NULL, N'1', CAST(0x0000A7BD01072D64 AS DateTime))
INSERT [dbo].[Zhp_GameConfig] ([ID], [GameName], [GameCode], [Description], [Remark], [State], [CreateTime]) VALUES (9, N'打地鼠', N'game010', NULL, NULL, N'1', CAST(0x0000A7BE00A7A55E AS DateTime))
INSERT [dbo].[Zhp_GameConfig] ([ID], [GameName], [GameCode], [Description], [Remark], [State], [CreateTime]) VALUES (10, N'超级玛丽', N'game011', NULL, NULL, N'1', CAST(0x0000A7BE00A7F47A AS DateTime))
INSERT [dbo].[Zhp_GameConfig] ([ID], [GameName], [GameCode], [Description], [Remark], [State], [CreateTime]) VALUES (15, N'王者农药', N'game017', NULL, NULL, N'1', CAST(0x0000A7BE00A99FE6 AS DateTime))
INSERT [dbo].[Zhp_GameConfig] ([ID], [GameName], [GameCode], [Description], [Remark], [State], [CreateTime]) VALUES (21, N'魂斗罗', N'game0168', NULL, NULL, N'1', CAST(0x0000A7BE00E4770F AS DateTime))
INSERT [dbo].[Zhp_GameConfig] ([ID], [GameName], [GameCode], [Description], [Remark], [State], [CreateTime]) VALUES (22, N'七夕情人节夺宝大作战', N'game015', NULL, NULL, N'1', CAST(0x0000A7CB00C0CE3F AS DateTime))
SET IDENTITY_INSERT [dbo].[Zhp_GameConfig] OFF
/****** Object:  Table [dbo].[Zhp_GameAwards]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zhp_GameAwards](
	[AwardId] [int] IDENTITY(1,1) NOT NULL,
	[AwardCode] [nvarchar](32) NULL,
	[AwardName] [nvarchar](32) NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_ZHP_GAMEAWARDS] PRIMARY KEY CLUSTERED 
(
	[AwardId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Zhp_GameAwards] ON
INSERT [dbo].[Zhp_GameAwards] ([AwardId], [AwardCode], [AwardName], [Description]) VALUES (1, N'award001', N'100元红包', NULL)
INSERT [dbo].[Zhp_GameAwards] ([AwardId], [AwardCode], [AwardName], [Description]) VALUES (3, N'award002', N'美年达饮料一瓶', NULL)
SET IDENTITY_INSERT [dbo].[Zhp_GameAwards] OFF
/****** Object:  Table [dbo].[Zhp_GameApi]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zhp_GameApi](
	[ApiId] [int] IDENTITY(1,1) NOT NULL,
	[ApiName] [nvarchar](16) NULL,
	[Protocol] [nvarchar](32) NULL,
	[ApiUrl] [text] NULL,
	[ApiMethod] [nvarchar](8) NULL,
	[RequestData] [text] NULL,
	[ResponseData] [text] NULL,
	[RequestContentType] [nvarchar](32) NULL,
	[ResponseContentType] [text] NULL,
	[Remark] [text] NULL,
 CONSTRAINT [PK_ZHP_GAMEAPI] PRIMARY KEY CLUSTERED 
(
	[ApiId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zhp_AwardsLimited]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zhp_AwardsLimited](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AwardCode] [nvarchar](32) NULL,
	[Gameid] [int] NULL,
	[GameSoreEdge] [nvarchar](32) NULL,
	[AwardImage] [text] NULL,
 CONSTRAINT [PK_ZHP_AWARDSLIMITED] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Zhp_AwardsLimited] ON
INSERT [dbo].[Zhp_AwardsLimited] ([Id], [AwardCode], [Gameid], [GameSoreEdge], [AwardImage]) VALUES (4, N'award001', 6, N'200', NULL)
SET IDENTITY_INSERT [dbo].[Zhp_AwardsLimited] OFF
/****** Object:  Table [dbo].[Zhp_AwardCreate]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zhp_AwardCreate](
	[ID] [int] NOT NULL,
	[Gameid] [int] NULL,
	[Gamename] [nvarchar](32) NULL,
	[AwardCode] [nvarchar](32) NULL,
	[Nickname] [nvarchar](50) NULL,
	[Openid] [nvarchar](100) NULL,
	[ReceiveTime] [datetime] NULL,
	[CreateTime] [datetime] NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_ZHP_AWARDCREATE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SYS_USERINFO]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_USERINFO](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NULL,
	[Password] [nvarchar](100) NULL,
	[RealName] [nvarchar](30) NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](30) NULL,
	[CreateTime] [datetime] NULL,
	[LastLoginTime] [datetime] NULL,
	[Department] [nvarchar](30) NULL,
	[Count] [int] NULL,
	[Isdelete] [int] NULL,
	[State] [int] NULL,
 CONSTRAINT [PK_SYS_USERINFO] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_USERINFO] ON
INSERT [dbo].[SYS_USERINFO] ([UserID], [UserName], [Password], [RealName], [Phone], [Email], [CreateTime], [LastLoginTime], [Department], [Count], [Isdelete], [State]) VALUES (1, N'admin', N'899b8ccefe9f0d9ab370c832f73f7386', N'超级管理员', N'13880825220', N'287572291@qq.com', CAST(0x0000A7BE00000000 AS DateTime), CAST(0x0000A7DD00949AB0 AS DateTime), NULL, 103, 0, 1)
INSERT [dbo].[SYS_USERINFO] ([UserID], [UserName], [Password], [RealName], [Phone], [Email], [CreateTime], [LastLoginTime], [Department], [Count], [Isdelete], [State]) VALUES (5, N'RandyField', N'd80e0a5cda9429451332d8f05fc40ebb', N'登哥', N'13880825220', N'1992zhangdeng@gmail.com', CAST(0x0000A7CA00ABC1AF AS DateTime), CAST(0x0000A7DD009472BA AS DateTime), N'RandyTech0101', 11, 0, 1)
INSERT [dbo].[SYS_USERINFO] ([UserID], [UserName], [Password], [RealName], [Phone], [Email], [CreateTime], [LastLoginTime], [Department], [Count], [Isdelete], [State]) VALUES (6, N'qq287572291', N'd80e0a5cda9429451332d8f05fc40ebb', N'张登', N'13880825220', N'86106255@qq.com', CAST(0x0000A7CA00EA2B03 AS DateTime), CAST(0x0000A7CA00EAA792 AS DateTime), N'RandyTech18', 1, 0, 1)
INSERT [dbo].[SYS_USERINFO] ([UserID], [UserName], [Password], [RealName], [Phone], [Email], [CreateTime], [LastLoginTime], [Department], [Count], [Isdelete], [State]) VALUES (7, N'zhangdeng', N'd80e0a5cda9429451332d8f05fc40ebb', N'张登', N'13880825220', N'287572291@qq.com', CAST(0x0000A7CA00EAF4A9 AS DateTime), CAST(0x0000A7CA00EB1CA6 AS DateTime), N'RandyTech0102', 1, 0, 1)
INSERT [dbo].[SYS_USERINFO] ([UserID], [UserName], [Password], [RealName], [Phone], [Email], [CreateTime], [LastLoginTime], [Department], [Count], [Isdelete], [State]) VALUES (8, N'123456', N'd80e0a5cda9429451332d8f05fc40ebb', N'123456', N'13880825220', N'287572291@qq.com', CAST(0x0000A7CA00F82B7A AS DateTime), CAST(0x0000A7D700A3E53E AS DateTime), N'RandyTech0101', 2, 0, 1)
SET IDENTITY_INSERT [dbo].[SYS_USERINFO] OFF
/****** Object:  Table [dbo].[SYS_USER_ROLE_RELATION]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_USER_ROLE_RELATION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[RoleID] [int] NULL,
 CONSTRAINT [PK_SYS_USER_ROLE_RELATION] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_USER_ROLE_RELATION] ON
INSERT [dbo].[SYS_USER_ROLE_RELATION] ([ID], [UserID], [RoleID]) VALUES (1, 1, 4)
INSERT [dbo].[SYS_USER_ROLE_RELATION] ([ID], [UserID], [RoleID]) VALUES (3, 5, 4)
INSERT [dbo].[SYS_USER_ROLE_RELATION] ([ID], [UserID], [RoleID]) VALUES (4, 6, 4)
INSERT [dbo].[SYS_USER_ROLE_RELATION] ([ID], [UserID], [RoleID]) VALUES (5, 7, 4)
INSERT [dbo].[SYS_USER_ROLE_RELATION] ([ID], [UserID], [RoleID]) VALUES (6, 8, 4)
SET IDENTITY_INSERT [dbo].[SYS_USER_ROLE_RELATION] OFF
/****** Object:  Table [dbo].[SYS_ROLE_PERMISSION_RELATION]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_ROLE_PERMISSION_RELATION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NULL,
	[PermissionID] [int] NULL,
 CONSTRAINT [PK_SYS_ROLE_PERMISSION_RELATION] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_ROLE_PERMISSION_RELATION] ON
INSERT [dbo].[SYS_ROLE_PERMISSION_RELATION] ([ID], [RoleId], [PermissionID]) VALUES (3, 4, 30)
SET IDENTITY_INSERT [dbo].[SYS_ROLE_PERMISSION_RELATION] OFF
/****** Object:  Table [dbo].[SYS_ROLE]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_ROLE](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](30) NULL,
	[CreateTime] [datetime] NULL,
	[Description] [nvarchar](300) NULL,
 CONSTRAINT [PK_SYS_ROLE] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_ROLE] ON
INSERT [dbo].[SYS_ROLE] ([RoleID], [RoleName], [CreateTime], [Description]) VALUES (4, N'管理员', CAST(0x0000A7CA00F7DFEB AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[SYS_ROLE] OFF
/****** Object:  Table [dbo].[SYS_PERMISSION_MENU_RELATION]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_PERMISSION_MENU_RELATION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionID] [int] NULL,
	[MenuID] [int] NULL,
	[Access] [nvarchar](16) NULL,
 CONSTRAINT [PK_SYS_PERMISSION_MENU_RELATION] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ON
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (357, 30, 1, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (358, 30, 3, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (359, 30, 2, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (360, 30, 12, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (361, 30, 13, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (362, 30, 14, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (363, 30, 19, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (364, 30, 20, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (365, 30, 21, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (366, 30, 8, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (367, 30, 9, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (368, 30, 4, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (369, 30, 5, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (370, 30, 6, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (371, 30, 7, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (372, 30, 10, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (373, 30, 18, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (374, 30, 11, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (375, 30, 15, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (376, 30, 16, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (377, 30, 22, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (378, 30, 23, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (379, 30, 24, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (380, 30, 25, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (381, 30, 26, N'1111')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (382, 31, 1, N'1000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (383, 31, 3, N'1000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (384, 31, 2, N'1000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (385, 31, 12, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (386, 31, 13, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (387, 31, 14, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (388, 31, 19, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (389, 31, 20, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (390, 31, 21, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (391, 31, 8, N'1000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (392, 31, 9, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (393, 31, 4, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (394, 31, 5, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (395, 31, 6, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (396, 31, 7, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (397, 31, 10, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (398, 31, 18, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (399, 31, 11, N'1000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (400, 31, 15, N'1000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (401, 31, 16, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (402, 31, 22, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (403, 31, 23, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (404, 31, 24, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (405, 31, 25, N'0000')
INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] ([ID], [PermissionID], [MenuID], [Access]) VALUES (406, 31, 26, N'0000')
SET IDENTITY_INSERT [dbo].[SYS_PERMISSION_MENU_RELATION] OFF
/****** Object:  Table [dbo].[SYS_PERMISSION]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_PERMISSION](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionName] [nvarchar](30) NULL,
	[CreateTime] [datetime] NULL,
	[Description] [nvarchar](300) NULL,
 CONSTRAINT [PK_SYS_PERMISSION] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_PERMISSION] ON
INSERT [dbo].[SYS_PERMISSION] ([PermissionID], [PermissionName], [CreateTime], [Description]) VALUES (30, N'超级管理员', CAST(0x0000A7CA00F7C954 AS DateTime), NULL)
INSERT [dbo].[SYS_PERMISSION] ([PermissionID], [PermissionName], [CreateTime], [Description]) VALUES (31, N'测试权限', CAST(0x0000A7CA0122F8E2 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[SYS_PERMISSION] OFF
/****** Object:  Table [dbo].[SYS_PARAM_CONFIG]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_PARAM_CONFIG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TYPE_CODE] [nvarchar](30) NULL,
	[TYPE_NAME] [nvarchar](30) NULL,
	[RESERVED_1] [nvarchar](30) NULL,
	[RESERVED_2] [nvarchar](30) NULL,
	[RESERVED_3] [nvarchar](30) NULL,
 CONSTRAINT [PK_SYS_PARAM_CONFIG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_PARAM_CONFIG] ON
INSERT [dbo].[SYS_PARAM_CONFIG] ([ID], [TYPE_CODE], [TYPE_NAME], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (1, N'001', N'游戏记录类型', NULL, NULL, NULL)
INSERT [dbo].[SYS_PARAM_CONFIG] ([ID], [TYPE_CODE], [TYPE_NAME], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (2, N'002', N'游戏计数类型', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[SYS_PARAM_CONFIG] OFF
/****** Object:  Table [dbo].[SYS_PARAM]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_PARAM](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TYPE_CODE] [nvarchar](30) NULL,
	[PRM_Val_NAME_CH] [nvarchar](30) NULL,
	[PRM_Val_NAME_EN] [nvarchar](30) NULL,
	[PRM_Val_CODE] [nvarchar](30) NULL,
	[RESERVED_1] [nvarchar](30) NULL,
	[RESERVED_2] [nvarchar](30) NULL,
	[RESERVED_3] [nvarchar](30) NULL,
 CONSTRAINT [PK_SYS_PARAM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_PARAM] ON
INSERT [dbo].[SYS_PARAM] ([ID], [TYPE_CODE], [PRM_Val_NAME_CH], [PRM_Val_NAME_EN], [PRM_Val_CODE], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (3, N'001', N'单身狗', N'单身狗（单身模式）', N'001', N'（单身模式）', NULL, NULL)
INSERT [dbo].[SYS_PARAM] ([ID], [TYPE_CODE], [PRM_Val_NAME_CH], [PRM_Val_NAME_EN], [PRM_Val_CODE], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (4, N'001', N'玫瑰花', N'玫瑰花（有女朋友的男生）', N'002', N'（有女朋友的男生）', NULL, NULL)
INSERT [dbo].[SYS_PARAM] ([ID], [TYPE_CODE], [PRM_Val_NAME_CH], [PRM_Val_NAME_EN], [PRM_Val_CODE], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (5, N'001', N'巧克力', N'巧克力（有男朋友的女生）', N'003', N'（有男朋友的女生）', NULL, NULL)
INSERT [dbo].[SYS_PARAM] ([ID], [TYPE_CODE], [PRM_Val_NAME_CH], [PRM_Val_NAME_EN], [PRM_Val_CODE], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (6, N'002', N'游戏轮播次数', N'游戏轮播次数', N'001', NULL, NULL, NULL)
INSERT [dbo].[SYS_PARAM] ([ID], [TYPE_CODE], [PRM_Val_NAME_CH], [PRM_Val_NAME_EN], [PRM_Val_CODE], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (7, N'002', N'游戏参与次数', N'游戏参与次数', N'002', NULL, NULL, NULL)
INSERT [dbo].[SYS_PARAM] ([ID], [TYPE_CODE], [PRM_Val_NAME_CH], [PRM_Val_NAME_EN], [PRM_Val_CODE], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (8, N'002', N'游戏完成次数', N'游戏完成次数', N'003', NULL, NULL, NULL)
INSERT [dbo].[SYS_PARAM] ([ID], [TYPE_CODE], [PRM_Val_NAME_CH], [PRM_Val_NAME_EN], [PRM_Val_CODE], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (9, N'002', N'游戏完成扫码次数', N'游戏完成扫码次数', N'004', NULL, NULL, NULL)
INSERT [dbo].[SYS_PARAM] ([ID], [TYPE_CODE], [PRM_Val_NAME_CH], [PRM_Val_NAME_EN], [PRM_Val_CODE], [RESERVED_1], [RESERVED_2], [RESERVED_3]) VALUES (10, N'002', N'游戏用户数据完整数', N'游戏用户数据完整数', N'005', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[SYS_PARAM] OFF
/****** Object:  Table [dbo].[SYS_MENU]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_MENU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](30) NULL,
	[MenuLevel] [int] NULL,
	[MenuIcon] [nvarchar](50) NULL,
	[MenuUrl] [nvarchar](124) NULL,
	[ParentMenu] [int] NULL,
	[Isdelete] [int] NULL,
	[Sort] [nvarchar](2) NULL,
	[BelongSys] [int] NULL,
	[Remark] [nvarchar](512) NULL,
	[UpdateTime] [nvarchar](30) NULL,
	[Alias] [nvarchar](16) NULL,
 CONSTRAINT [PK_SYS_MENU] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_MENU] ON
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (1, N'首页', 1, N'<i class="icon-dashboard"></i>', N'../Main/Index', 0, 0, N'1', 1, NULL, NULL, N'index')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (2, N'平台管理', 1, N'<i class="icon-desktop"></i>', N'#', 0, 0, N'3', 1, NULL, NULL, N'platform')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (3, N'系统参数管理', 1, N'<i class="icon-leaf"></i>', N'../SysParam/Index', 0, 0, N'2', 1, NULL, NULL, N'sysparam')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (4, N'财务部', 3, N'<i class="icon-pencil"></i>', N'../Finance/Index', 9, 0, N'1', 1, NULL, NULL, N'finacepart')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (5, N'客户部', 3, N'<i class="icon-list"></i>', N'../Custom/Index', 9, 0, N'3', 1, NULL, NULL, N'custompart')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (6, N'销售部', 3, N'<i class="icon-edit"></i>', N'../Sale/Index', 9, 0, N'2', 1, NULL, NULL, N'salepart')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (7, N'技术部', 3, N'<i class="icon-list-alt"></i>', N'../Tech/Index', 9, 0, N'4', 1, NULL, NULL, N'techpart')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (8, N'系统管理', 1, N'<i class="icon-picture"></i>', N'#', 0, 0, N'4', 1, NULL, NULL, N'sysadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (9, N'组织管理', 2, N'<i class="icon-leaf"></i>', N'#', 8, 0, N'1', 1, NULL, NULL, N'organadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (10, N'用户管理', 2, N'<i class="icon-desktop"></i>', N'../UserInfo/Index', 8, 0, N'2', 1, NULL, NULL, N'useradmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (11, N'部门管理', 1, N'<i class="icon-home"></i>', N'../Depart/Index', 0, 0, N'5', 1, NULL, NULL, N'departadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (12, N'权限管理', 2, N'<i class="icon-desktop"></i>', N'../Permission/Index', 2, 0, N'1', 1, NULL, NULL, N'permissionadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (13, N'菜单管理', 2, N'<i class="icon-desktop"></i>', N'../Menu/Index', 2, 0, N'3', 1, NULL, NULL, N'menuadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (14, N'接口管理', 2, N'<i class="icon-home"></i>', N'../Webapi/Index', 2, 0, N'4', 1, NULL, NULL, N'apiadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (15, N'业务管理', 1, N'<i class="icon-globe "></i>', N'#', 0, 0, N'6', 1, NULL, NULL, N'bussinessadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (16, N'智汇屏游戏', 2, N'<i class="icon-globe "></i>', N'#', 15, 0, N'1', 1, NULL, NULL, N'gameadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (18, N'操作日志', 2, N'<i class="icon-picture"></i>', N'../Log/Index', 8, 0, N'1', 1, NULL, NULL, N'logadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (19, N'角色管理', 2, N'<i class="icon-picture"></i>', N'../Role/Index', 2, 0, N'2', 1, NULL, NULL, N'roleadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (20, N'小工具', 2, N'<i class="icon-desktop"></i>', N'#', 2, 0, N'5', 1, NULL, NULL, N'tooladmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (21, N'重命名文件名', 3, N'<i class="icon-desktop"></i>', N'../Tool/FileRenameIndex', 20, 0, N'1', 1, NULL, NULL, N'renamefile')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (22, N'游戏库配置', 3, N'<i class="icon-cog"></i>', N'../GameConfig/Index', 16, 0, N'1', 1, NULL, NULL, N'gameconfig')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (23, N'游戏运行配置', 3, N'<i class="icon-desktop"></i>', N'../GameOnline/Index', 16, 0, N'2', 1, NULL, NULL, N'gamerun')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (24, N'游戏数据管理', 3, N'<i class="icon-coffee"></i>', N'../GameRecord/Index', 16, 0, N'3', 1, NULL, NULL, N'gamerecord')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (25, N'游戏奖品管理', 3, N'<i class="icon-laptop"></i>', N'../GameAward/Index', 16, 0, N'6', 1, NULL, NULL, N'awardadmin')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (26, N'游戏奖品发放配置', 3, N'<i class="icon-lightbulb"></i>', N'../AwardConfig/Index', 16, 0, N'7', 1, NULL, NULL, N'awardconfig')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (27, N'游戏数据排名', 3, N'<i class="icon-bar-chart "></i>', N'../RecordSort/Index', 16, 0, N'4', 1, NULL, NULL, N'recordsort')
INSERT [dbo].[SYS_MENU] ([ID], [MenuName], [MenuLevel], [MenuIcon], [MenuUrl], [ParentMenu], [Isdelete], [Sort], [BelongSys], [Remark], [UpdateTime], [Alias]) VALUES (28, N'游戏统计', 3, N'<i class="icon-headphones"></i>', N'../GameStat/Index', 16, 0, N'5', 1, NULL, NULL, N'gamestat')
SET IDENTITY_INSERT [dbo].[SYS_MENU] OFF
/****** Object:  Table [dbo].[SYS_DEPARTMENT]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_DEPARTMENT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DepartName] [nvarchar](30) NULL,
	[DepartCode] [nvarchar](20) NULL,
	[ChargeMan] [nvarchar](50) NULL,
	[ChargeManPhone] [nvarchar](20) NULL,
	[ParentDepart] [nvarchar](20) NULL,
	[Isdelete] [int] NULL,
	[Remark] [nvarchar](512) NULL,
	[Alias] [nvarchar](16) NULL,
	[UpdateTime] [nvarchar](30) NULL,
 CONSTRAINT [PK_SYS_DEPARTMENT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_DEPARTMENT] ON
INSERT [dbo].[SYS_DEPARTMENT] ([ID], [DepartName], [DepartCode], [ChargeMan], [ChargeManPhone], [ParentDepart], [Isdelete], [Remark], [Alias], [UpdateTime]) VALUES (2, N'软件部', N'RandyTech0101', N'Randy', N'13880825221', N'RandyTech01', 0, NULL, NULL, NULL)
INSERT [dbo].[SYS_DEPARTMENT] ([ID], [DepartName], [DepartCode], [ChargeMan], [ChargeManPhone], [ParentDepart], [Isdelete], [Remark], [Alias], [UpdateTime]) VALUES (3, N'硬件部', N'RandyTech0102', N'Randy', N'13880825222', N'RandyTech01', 0, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[SYS_DEPARTMENT] OFF
/****** Object:  Table [dbo].[SYS_CONFIG]    Script Date: 09/11/2017 10:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SYS_CONFIG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SystemName] [nvarchar](124) NULL,
	[SystemVersion] [nvarchar](124) NULL,
	[SystemIcon] [nvarchar](124) NULL,
	[UpdateTime] [nvarchar](30) NULL,
	[State] [int] NULL,
 CONSTRAINT [PK_SYS_CONFIG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SYS_CONFIG] ON
INSERT [dbo].[SYS_CONFIG] ([ID], [SystemName], [SystemVersion], [SystemIcon], [UpdateTime], [State]) VALUES (1, N'智汇屏游戏后台管理系统', N'v1.0', N' <i class="icon-leaf"></i>', NULL, 1)
SET IDENTITY_INSERT [dbo].[SYS_CONFIG] OFF
/****** Object:  StoredProcedure [dbo].[P_PagerQuery]    Script Date: 09/11/2017 10:42:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery19.sql|7|0|C:\Users\Randy\AppData\Local\Temp\~vs43F7.sql

CREATE PROCEDURE [dbo].[P_PagerQuery] (
    @recordTotal INT OUTPUT,          --输出记录总数
	@pageTotal INT OUTPUT,            --输出分页总页数
    @tblName VARCHAR(800),			  --表名
    @fldName VARCHAR(800) = '*',      --查询字段
	@pageSize INT = 20,               --每页记录数
	@pageIndex INT =1,                --当前页
    @keyName VARCHAR(200) = 'Id',     --索引字段  
    @orderString VARCHAR(200),        --排序条件
    @whereString VARCHAR(800) = '1=1' --WHERE条件
)
AS
BEGIN
     DECLARE @beginRow INT					--开始行
     DECLARE @endRow INT					--结束行
     DECLARE @tempLimit VARCHAR(200)		--between 开始行 与结束行之间
     DECLARE @tempCount NVARCHAR(1000)		--输出总记录数sql
      DECLARE @tempMain NVARCHAR(1000)	--返回分页结果集
	 DECLARE @tempPageCount NVARCHAR(1000)	--输出总页数sql
     --declare @timediff datetime 
     
     set nocount on
     --select @timediff=getdate() --记录时间

     SET @beginRow = (@pageIndex - 1) * @pageSize    + 1 
     SET @endRow = @pageIndex * @pageSize		
     SET @tempLimit = 'rows BETWEEN ' + CAST(@beginRow AS VARCHAR) +' AND '+CAST(@endRow AS VARCHAR)
     
     --输出参数为总记录数
     SET @tempCount = 'SELECT @recordTotal = COUNT(*) FROM (SELECT '+@keyName+' FROM '+@tblName+' WHERE '+@whereString+') AS my_temp'
     EXECUTE sp_executesql @tempCount,N'@recordTotal INT OUTPUT',@recordTotal OUTPUT

	 --输出参数为总页数
	  SET @tempPageCount = 'select @pageTotal=(select Ceiling(cast(cast('+cast(@recordTotal as varchar(4))+' as float)/'+cast(@pageSize as varchar(4))+' as decimal(10,2))))'
     EXECUTE sp_executesql @tempPageCount,N'@pageTotal INT OUTPUT',@pageTotal OUTPUT
       
       
     --主查询返回结果集
     SET @tempMain = 'select * from (SELECT ROW_NUMBER() OVER (order by '+@orderString+') AS rows ,'+@fldName+' FROM '+@tblName+' WHERE '+@whereString+')as temptb Where '+  @tempLimit
     
     EXECUTE sp_executesql @tempMain

     --PRINT @tempMain
    -- EXECUTE (@tempMain)
     --select datediff(ms,@timediff,getdate()) as 耗时 
     
     set nocount off
END
GO
/****** Object:  Default [DF__SYS_DEPAR__Isdel__014935CB]    Script Date: 09/11/2017 10:42:01 ******/
ALTER TABLE [dbo].[SYS_DEPARTMENT] ADD  DEFAULT ((0)) FOR [Isdelete]
GO
/****** Object:  Default [DF__SYS_MENU__Isdele__0425A276]    Script Date: 09/11/2017 10:42:01 ******/
ALTER TABLE [dbo].[SYS_MENU] ADD  DEFAULT ((0)) FOR [Isdelete]
GO
/****** Object:  Default [DF__SYS_USERI__Count__182C9B23]    Script Date: 09/11/2017 10:42:01 ******/
ALTER TABLE [dbo].[SYS_USERINFO] ADD  CONSTRAINT [DF__SYS_USERI__Count__182C9B23]  DEFAULT ((0)) FOR [Count]
GO
/****** Object:  Default [DF__SYS_USERI__Isdel__1920BF5C]    Script Date: 09/11/2017 10:42:01 ******/
ALTER TABLE [dbo].[SYS_USERINFO] ADD  CONSTRAINT [DF__SYS_USERI__Isdel__1920BF5C]  DEFAULT ((0)) FOR [Isdelete]
GO
/****** Object:  Default [DF__SYS_USERI__State__1A14E395]    Script Date: 09/11/2017 10:42:01 ******/
ALTER TABLE [dbo].[SYS_USERINFO] ADD  CONSTRAINT [DF__SYS_USERI__State__1A14E395]  DEFAULT ((1)) FOR [State]
GO
/****** Object:  Default [DF_Zhp_GameConfig_State]    Script Date: 09/11/2017 10:42:01 ******/
ALTER TABLE [dbo].[Zhp_GameConfig] ADD  CONSTRAINT [DF_Zhp_GameConfig_State]  DEFAULT ((1)) FOR [State]
GO
