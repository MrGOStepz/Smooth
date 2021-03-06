USE [smooth]
GO
/****** Object:  Table [dbo].[clockstatus]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clockstatus](
	[ClockStatusId] [int] IDENTITY(1,1) NOT NULL,
	[ClockStatusName] [nchar](255) NOT NULL,
 CONSTRAINT [PK_clockstatus] PRIMARY KEY CLUSTERED 
(
	[ClockStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cookstatus]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cookstatus](
	[CookStatusId] [int] IDENTITY(1,1) NOT NULL,
	[CookStatusName] [nchar](255) NOT NULL,
 CONSTRAINT [PK_cookstatus] PRIMARY KEY CLUSTERED 
(
	[CookStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](255) NOT NULL,
	[LastName] [nchar](255) NULL,
	[Phone] [nchar](255) NULL,
	[Address] [text] NULL,
	[DateOfBirth] [date] NULL,
	[Card] [text] NULL,
	[Email] [nchar](255) NULL,
	[TotalOrder] [int] NULL,
	[LastActive] [datetime] NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[foodtype]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[foodtype](
	[FoodTypeId] [int] IDENTITY(1,1) NOT NULL,
	[FoodTypeName] [nchar](255) NOT NULL,
 CONSTRAINT [PK_foodtype] PRIMARY KEY CLUSTERED 
(
	[FoodTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingredient]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingredient](
	[IngredientId] [int] IDENTITY(1,1) NOT NULL,
	[IngredientName] [nchar](255) NOT NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_ingredient] PRIMARY KEY CLUSTERED 
(
	[IngredientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingredientproduct]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingredientproduct](
	[ProductId] [int] NOT NULL,
	[IngredientId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderAt] [datetime] NOT NULL,
	[OrderTypeId] [int] NOT NULL,
	[StaffId] [int] NOT NULL,
	[TableDetailId] [int] NOT NULL,
	[OrderStatusId] [int] NOT NULL,
	[PaymentTypeId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderdetail]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderdetail](
	[OrderDetailId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[PopupItemId] [int] NOT NULL,
	[ProductQty] [int] NOT NULL,
	[Amount] [float] NOT NULL,
	[Comment] [text] NULL,
	[StaffId] [int] NOT NULL,
	[CookStatusId] [int] NOT NULL,
 CONSTRAINT [PK_orderdetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderstatus]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderstatus](
	[OrderStatusId] [int] IDENTITY(1,1) NOT NULL,
	[OrderStatusName] [nchar](255) NOT NULL,
 CONSTRAINT [PK_orderstatus] PRIMARY KEY CLUSTERED 
(
	[OrderStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ordertype]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ordertype](
	[OrderTypeId] [int] IDENTITY(1,1) NOT NULL,
	[OrderTypeName] [nchar](255) NOT NULL,
 CONSTRAINT [PK_ordertype] PRIMARY KEY CLUSTERED 
(
	[OrderTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paymenttype]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paymenttype](
	[PaymentTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeName] [nchar](255) NOT NULL,
 CONSTRAINT [PK_paymenttype] PRIMARY KEY CLUSTERED 
(
	[PaymentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[popup]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[popup](
	[PopupId] [int] IDENTITY(1,1) NOT NULL,
	[PopupName] [nchar](255) NOT NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_popup] PRIMARY KEY CLUSTERED 
(
	[PopupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[popupitem]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[popupitem](
	[PopupItemId] [int] IDENTITY(1,1) NOT NULL,
	[PopupItemName] [nchar](255) NOT NULL,
	[PopupId] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[ImagePath] [text] NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_popupitem] PRIMARY KEY CLUSTERED 
(
	[PopupItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[printer]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[printer](
	[PrinterId] [int] IDENTITY(1,1) NOT NULL,
	[PrinterName] [nchar](255) NOT NULL,
 CONSTRAINT [PK_printer] PRIMARY KEY CLUSTERED 
(
	[PrinterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[printerlog]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[printerlog](
	[PrinterLogId] [int] NOT NULL,
	[PrinterId] [int] NOT NULL,
	[PrinterLogDetail] [text] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_printerlog] PRIMARY KEY CLUSTERED 
(
	[PrinterLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nchar](255) NOT NULL,
	[Description] [text] NULL,
	[PopupId] [int] NULL,
	[FoodTypeId] [int] NOT NULL,
	[GlutenFree] [int] NOT NULL,
	[Vegan] [int] NOT NULL,
	[Stock] [int] NULL,
	[Price] [float] NOT NULL,
	[IsAvaliable] [int] NOT NULL,
	[ImagePath] [text] NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receipt]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt](
	[ReceiptId] [int] IDENTITY(1,1) NOT NULL,
	[ReceiptDate] [datetime] NOT NULL,
	[ReceiptDetail] [text] NOT NULL,
 CONSTRAINT [PK_receipt] PRIMARY KEY CLUSTERED 
(
	[ReceiptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[setting]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[setting](
	[SettingKey] [nchar](255) NOT NULL,
	[SettingValue] [nchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staff]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staff](
	[StaffId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](255) NOT NULL,
	[LastName] [nchar](255) NULL,
	[Phone] [nchar](255) NULL,
	[Email] [nchar](255) NULL,
	[StaffPositionId] [int] NOT NULL,
	[ClockStatusId] [int] NOT NULL,
	[StaffPassword] [text] NOT NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_staff] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staffposition]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staffposition](
	[StaffPositionId] [int] IDENTITY(1,1) NOT NULL,
	[StaffPositionName] [nchar](255) NOT NULL,
 CONSTRAINT [PK_staffposition] PRIMARY KEY CLUSTERED 
(
	[StaffPositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stafftimesheet]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stafftimesheet](
	[StaffTimesheetId] [int] IDENTITY(1,1) NOT NULL,
	[StaffId] [int] NOT NULL,
	[ClockIn] [datetime] NOT NULL,
	[ClockOut] [datetime] NOT NULL,
 CONSTRAINT [PK_stafftimesheet] PRIMARY KEY CLUSTERED 
(
	[StaffTimesheetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tabledetail]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tabledetail](
	[TableDetailId] [int] IDENTITY(1,1) NOT NULL,
	[TableDetailName] [nchar](255) NOT NULL,
	[TableSectionId] [int] NOT NULL,
	[MarginTop] [float] NOT NULL,
	[MarginBottom] [float] NOT NULL,
	[MarginLeft] [float] NOT NULL,
	[MarginRight] [float] NOT NULL,
	[Height] [float] NOT NULL,
	[Width] [float] NOT NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_tabledetail] PRIMARY KEY CLUSTERED 
(
	[TableDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tablesection]    Script Date: 9/21/2020 2:11:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablesection](
	[TableSectionId] [int] IDENTITY(1,1) NOT NULL,
	[TableSectionName] [nchar](255) NOT NULL,
	[TabOrder] [int] NOT NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_tablesection] PRIMARY KEY CLUSTERED 
(
	[TableSectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clockstatus] ON 

INSERT [dbo].[clockstatus] ([ClockStatusId], [ClockStatusName]) VALUES (1, N'In                                                                                                                                                                                                                                                             ')
INSERT [dbo].[clockstatus] ([ClockStatusId], [ClockStatusName]) VALUES (2, N'Out                                                                                                                                                                                                                                                            ')
SET IDENTITY_INSERT [dbo].[clockstatus] OFF
GO
SET IDENTITY_INSERT [dbo].[cookstatus] ON 

INSERT [dbo].[cookstatus] ([CookStatusId], [CookStatusName]) VALUES (1, N'Cooking                                                                                                                                                                                                                                                        ')
INSERT [dbo].[cookstatus] ([CookStatusId], [CookStatusName]) VALUES (2, N'Done                                                                                                                                                                                                                                                           ')
INSERT [dbo].[cookstatus] ([CookStatusId], [CookStatusName]) VALUES (3, N'Break                                                                                                                                                                                                                                                          ')
SET IDENTITY_INSERT [dbo].[cookstatus] OFF
GO
SET IDENTITY_INSERT [dbo].[foodtype] ON 

INSERT [dbo].[foodtype] ([FoodTypeId], [FoodTypeName]) VALUES (1, N'Entree                                                                                                                                                                                                                                                         ')
INSERT [dbo].[foodtype] ([FoodTypeId], [FoodTypeName]) VALUES (2, N'Main                                                                                                                                                                                                                                                           ')
INSERT [dbo].[foodtype] ([FoodTypeId], [FoodTypeName]) VALUES (3, N'Dessert                                                                                                                                                                                                                                                        ')
INSERT [dbo].[foodtype] ([FoodTypeId], [FoodTypeName]) VALUES (4, N'Beverage                                                                                                                                                                                                                                                       ')
INSERT [dbo].[foodtype] ([FoodTypeId], [FoodTypeName]) VALUES (5, N'Other                                                                                                                                                                                                                                                          ')
SET IDENTITY_INSERT [dbo].[foodtype] OFF
GO
SET IDENTITY_INSERT [dbo].[ingredient] ON 

INSERT [dbo].[ingredient] ([IngredientId], [IngredientName], [IsActive]) VALUES (1, N'NONE                                                                                                                                                                                                                                                           ', 1)
SET IDENTITY_INSERT [dbo].[ingredient] OFF
GO
SET IDENTITY_INSERT [dbo].[paymenttype] ON 

INSERT [dbo].[paymenttype] ([PaymentTypeId], [PaymentTypeName]) VALUES (1, N'NONE                                                                                                                                                                                                                                                           ')
INSERT [dbo].[paymenttype] ([PaymentTypeId], [PaymentTypeName]) VALUES (2, N'Cash                                                                                                                                                                                                                                                           ')
INSERT [dbo].[paymenttype] ([PaymentTypeId], [PaymentTypeName]) VALUES (3, N'Visa                                                                                                                                                                                                                                                           ')
INSERT [dbo].[paymenttype] ([PaymentTypeId], [PaymentTypeName]) VALUES (4, N'Master                                                                                                                                                                                                                                                         ')
INSERT [dbo].[paymenttype] ([PaymentTypeId], [PaymentTypeName]) VALUES (5, N'Eftpos                                                                                                                                                                                                                                                         ')
INSERT [dbo].[paymenttype] ([PaymentTypeId], [PaymentTypeName]) VALUES (6, N'Amex                                                                                                                                                                                                                                                           ')
SET IDENTITY_INSERT [dbo].[paymenttype] OFF
GO
SET IDENTITY_INSERT [dbo].[popup] ON 

INSERT [dbo].[popup] ([PopupId], [PopupName], [IsActive]) VALUES (1, N'NONE                                                                                                                                                                                                                                                           ', 1)
SET IDENTITY_INSERT [dbo].[popup] OFF
GO
SET IDENTITY_INSERT [dbo].[staff] ON 

INSERT [dbo].[staff] ([StaffId], [FirstName], [LastName], [Phone], [Email], [StaffPositionId], [ClockStatusId], [StaffPassword], [IsActive]) VALUES (1, N'MrGOStepz                                                                                                                                                                                                                                                      ', NULL, NULL, NULL, 1, 1, N'1234', 1)
SET IDENTITY_INSERT [dbo].[staff] OFF
GO
SET IDENTITY_INSERT [dbo].[staffposition] ON 

INSERT [dbo].[staffposition] ([StaffPositionId], [StaffPositionName]) VALUES (1, N'Admin                                                                                                                                                                                                                                                          ')
INSERT [dbo].[staffposition] ([StaffPositionId], [StaffPositionName]) VALUES (2, N'Manager                                                                                                                                                                                                                                                        ')
INSERT [dbo].[staffposition] ([StaffPositionId], [StaffPositionName]) VALUES (3, N'Staff                                                                                                                                                                                                                                                          ')
INSERT [dbo].[staffposition] ([StaffPositionId], [StaffPositionName]) VALUES (4, N'Trainee                                                                                                                                                                                                                                                        ')
INSERT [dbo].[staffposition] ([StaffPositionId], [StaffPositionName]) VALUES (5, N'Guest                                                                                                                                                                                                                                                          ')
SET IDENTITY_INSERT [dbo].[staffposition] OFF
GO
SET IDENTITY_INSERT [dbo].[tablesection] ON 

INSERT [dbo].[tablesection] ([TableSectionId], [TableSectionName], [TabOrder], [IsActive]) VALUES (1, N'Front                                                                                                                                                                                                                                                          ', 1, 1)
INSERT [dbo].[tablesection] ([TableSectionId], [TableSectionName], [TabOrder], [IsActive]) VALUES (2, N'Main                                                                                                                                                                                                                                                           ', 2, 1)
INSERT [dbo].[tablesection] ([TableSectionId], [TableSectionName], [TabOrder], [IsActive]) VALUES (3, N'Back                                                                                                                                                                                                                                                           ', 3, 1)
SET IDENTITY_INSERT [dbo].[tablesection] OFF
GO
ALTER TABLE [dbo].[customer] ADD  CONSTRAINT [DF_customer_total_order]  DEFAULT ((1)) FOR [TotalOrder]
GO
ALTER TABLE [dbo].[ingredient] ADD  CONSTRAINT [DF_ingredient_active]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[popup] ADD  CONSTRAINT [DF_popup_avtive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[popupitem] ADD  CONSTRAINT [DF_popup_item_price]  DEFAULT ((0.0)) FOR [Price]
GO
ALTER TABLE [dbo].[popupitem] ADD  CONSTRAINT [DF_popup_item_active]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[product] ADD  CONSTRAINT [DF_product_food_type_id]  DEFAULT ((2)) FOR [FoodTypeId]
GO
ALTER TABLE [dbo].[product] ADD  CONSTRAINT [DF_product_GlutenFree]  DEFAULT ((0)) FOR [GlutenFree]
GO
ALTER TABLE [dbo].[product] ADD  CONSTRAINT [DF_product_Vegan]  DEFAULT ((0)) FOR [Vegan]
GO
ALTER TABLE [dbo].[product] ADD  CONSTRAINT [DF_product_price]  DEFAULT ((0.0)) FOR [Price]
GO
ALTER TABLE [dbo].[product] ADD  CONSTRAINT [DF_product_avaliable]  DEFAULT ((1)) FOR [IsAvaliable]
GO
ALTER TABLE [dbo].[product] ADD  CONSTRAINT [DF_product_active]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[staff] ADD  CONSTRAINT [DF_staff_level_id]  DEFAULT ((1)) FOR [StaffPositionId]
GO
ALTER TABLE [dbo].[staff] ADD  CONSTRAINT [DF_staff_clock_status_id]  DEFAULT ((1)) FOR [ClockStatusId]
GO
ALTER TABLE [dbo].[staff] ADD  CONSTRAINT [DF_staff_active]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[tabledetail] ADD  CONSTRAINT [DF_table_detail_table_section]  DEFAULT ((1)) FOR [TableSectionId]
GO
ALTER TABLE [dbo].[tabledetail] ADD  CONSTRAINT [DF_table_detail_margin_top]  DEFAULT ((0)) FOR [MarginTop]
GO
ALTER TABLE [dbo].[tabledetail] ADD  CONSTRAINT [DF_table_detail_margin_bottom]  DEFAULT ((0)) FOR [MarginBottom]
GO
ALTER TABLE [dbo].[tabledetail] ADD  CONSTRAINT [DF_table_detail_margin_left]  DEFAULT ((0)) FOR [MarginLeft]
GO
ALTER TABLE [dbo].[tabledetail] ADD  CONSTRAINT [DF_table_detail_margin_right]  DEFAULT ((0)) FOR [MarginRight]
GO
ALTER TABLE [dbo].[tabledetail] ADD  CONSTRAINT [DF_table_detail_height]  DEFAULT ((50)) FOR [Height]
GO
ALTER TABLE [dbo].[tabledetail] ADD  CONSTRAINT [DF_table_detail_width]  DEFAULT ((50)) FOR [Width]
GO
ALTER TABLE [dbo].[tabledetail] ADD  CONSTRAINT [DF_table_detail_active]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[tablesection] ADD  CONSTRAINT [DF_table_section_active]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_orderstatus] FOREIGN KEY([OrderStatusId])
REFERENCES [dbo].[orderstatus] ([OrderStatusId])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_orderstatus]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_ordertype] FOREIGN KEY([OrderTypeId])
REFERENCES [dbo].[ordertype] ([OrderTypeId])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_ordertype]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_paymenttype] FOREIGN KEY([PaymentTypeId])
REFERENCES [dbo].[paymenttype] ([PaymentTypeId])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_paymenttype]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_staff] FOREIGN KEY([StaffId])
REFERENCES [dbo].[staff] ([StaffId])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_staff]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_tabledetail] FOREIGN KEY([TableDetailId])
REFERENCES [dbo].[tabledetail] ([TableDetailId])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_tabledetail]
GO
ALTER TABLE [dbo].[orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_orderdetail_cookstatus] FOREIGN KEY([CookStatusId])
REFERENCES [dbo].[cookstatus] ([CookStatusId])
GO
ALTER TABLE [dbo].[orderdetail] CHECK CONSTRAINT [FK_orderdetail_cookstatus]
GO
ALTER TABLE [dbo].[orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_orderdetail_order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[order] ([OrderId])
GO
ALTER TABLE [dbo].[orderdetail] CHECK CONSTRAINT [FK_orderdetail_order]
GO
ALTER TABLE [dbo].[orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_orderdetail_popupitem] FOREIGN KEY([PopupItemId])
REFERENCES [dbo].[popupitem] ([PopupItemId])
GO
ALTER TABLE [dbo].[orderdetail] CHECK CONSTRAINT [FK_orderdetail_popupitem]
GO
ALTER TABLE [dbo].[orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_orderdetail_product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[product] ([ProductId])
GO
ALTER TABLE [dbo].[orderdetail] CHECK CONSTRAINT [FK_orderdetail_product]
GO
ALTER TABLE [dbo].[orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_orderdetail_staff] FOREIGN KEY([StaffId])
REFERENCES [dbo].[staff] ([StaffId])
GO
ALTER TABLE [dbo].[orderdetail] CHECK CONSTRAINT [FK_orderdetail_staff]
GO
ALTER TABLE [dbo].[popupitem]  WITH CHECK ADD  CONSTRAINT [FK_popupitem_popup] FOREIGN KEY([PopupId])
REFERENCES [dbo].[popup] ([PopupId])
GO
ALTER TABLE [dbo].[popupitem] CHECK CONSTRAINT [FK_popupitem_popup]
GO
ALTER TABLE [dbo].[printerlog]  WITH CHECK ADD  CONSTRAINT [FK_printerlog_printer] FOREIGN KEY([PrinterId])
REFERENCES [dbo].[printer] ([PrinterId])
GO
ALTER TABLE [dbo].[printerlog] CHECK CONSTRAINT [FK_printerlog_printer]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_foodtype] FOREIGN KEY([FoodTypeId])
REFERENCES [dbo].[foodtype] ([FoodTypeId])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_foodtype]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_popup] FOREIGN KEY([PopupId])
REFERENCES [dbo].[popup] ([PopupId])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_popup]
GO
ALTER TABLE [dbo].[staff]  WITH CHECK ADD  CONSTRAINT [FK_staff_clockstatus] FOREIGN KEY([ClockStatusId])
REFERENCES [dbo].[clockstatus] ([ClockStatusId])
GO
ALTER TABLE [dbo].[staff] CHECK CONSTRAINT [FK_staff_clockstatus]
GO
ALTER TABLE [dbo].[staff]  WITH CHECK ADD  CONSTRAINT [FK_staff_staffposition] FOREIGN KEY([StaffPositionId])
REFERENCES [dbo].[staffposition] ([StaffPositionId])
GO
ALTER TABLE [dbo].[staff] CHECK CONSTRAINT [FK_staff_staffposition]
GO
ALTER TABLE [dbo].[stafftimesheet]  WITH CHECK ADD  CONSTRAINT [FK_stafftimesheet_staff] FOREIGN KEY([StaffId])
REFERENCES [dbo].[staff] ([StaffId])
GO
ALTER TABLE [dbo].[stafftimesheet] CHECK CONSTRAINT [FK_stafftimesheet_staff]
GO
ALTER TABLE [dbo].[tabledetail]  WITH CHECK ADD  CONSTRAINT [FK_tabledetail_tablesection] FOREIGN KEY([TableSectionId])
REFERENCES [dbo].[tablesection] ([TableSectionId])
GO
ALTER TABLE [dbo].[tabledetail] CHECK CONSTRAINT [FK_tabledetail_tablesection]
GO
