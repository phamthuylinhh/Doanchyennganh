USE [Doan]
GO
/****** Object:  Table [dbo].[AdminMenu]    Script Date: 3/30/2024 8:38:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminMenu](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[level] [int] NULL,
	[parentLevel] [int] NULL,
	[order] [int] NULL,
	[isActive] [bit] NULL,
	[target] [nvarchar](max) NULL,
	[areaName] [nvarchar](max) NULL,
	[controllerName] [nvarchar](max) NULL,
	[actionName] [nvarchar](max) NULL,
	[icon] [nvarchar](max) NULL,
	[idName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AdminMenu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdminUser]    Script Date: 3/30/2024 8:38:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminUser](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[Password] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_AdminUser] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 3/30/2024 8:38:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banner](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Images] [nvarchar](255) NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Benefit]    Script Date: 3/30/2024 8:38:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Benefit](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Contents] [nvarchar](255) NULL,
	[Icon] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Benefit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dealoftheweek]    Script Date: 3/30/2024 8:38:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dealoftheweek](
	[Id] [int] NOT NULL,
	[Images] [nvarchar](255) NULL,
 CONSTRAINT [PK_Dealoftheweek] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Footer]    Script Date: 3/30/2024 8:38:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Footer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Contents] [nvarchar](255) NULL,
	[Link] [nvarchar](255) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 3/30/2024 8:38:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[ControllerName] [nvarchar](50) NULL,
	[ActionName] [nvarchar](50) NULL,
	[Levels] [int] NULL,
	[ParentID] [int] NULL,
	[Link] [nvarchar](50) NULL,
	[MenuOrder] [int] NULL,
	[Position] [int] NULL,
	[Icon] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewArrivals]    Script Date: 3/30/2024 8:38:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewArrivals](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Contents] [nvarchar](255) NULL,
	[ParentID] [int] NULL,
	[Image] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slide]    Script Date: 3/30/2024 8:38:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slide](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Contents] [nvarchar](255) NULL,
	[Images] [nvarchar](255) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Slide] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminMenu] ON 

INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (1, N'Bảng điều khiển', 1, 0, 1, 1, NULL, N'admin', N'home', N'index', N'bx bx-home-circle', NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (2, N'Thông tin cá nhân', 0, 0, 1, 0, NULL, N'admin', N'home', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (3, N'Hướng dẫn sử dụng', 0, 0, 2, 0, NULL, N'admin', N'home', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (4, N'Liên lạc', 0, 0, 3, 0, NULL, N'admin', N'home', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (5, N'Đăng xuất', 0, 0, 4, 0, NULL, N'admin', N'home', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (6, N'Quản lý sản phẩm', 1, 0, 1, 1, N'components-nav', N'admin', N'product', N'index ', N'bx bx-collection', N'components-nav')
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (7, N'Cập nhật sản phẩm', 2, 6, 1, 0, NULL, N'admin', N'home', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (8, N'Thêm mới sản phẩm', 2, 6, 2, 1, NULL, N'admin', N'product', N'create', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (9, N'Xem toàn bộ sản phẩm', 2, 6, 3, 1, NULL, N'admin', N'product', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (10, N'Quản lý menu', 1, 0, 1, 1, N'forms-nav', N'admin', N'menu', N'index', N'bx bx-layout', N'forms-nav')
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (11, N'Thêm mới menu', 2, 10, 1, 1, NULL, N'admin ', N'menu', N'create', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (12, N'Chỉnh sửa menu', 2, 10, 2, 1, NULL, N'admin', N'menu', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (13, N'Quản lý slide', 1, 0, 1, 1, N'charts-nav', N'admin', N'Slide', N'index', N'bx bx-slider', N'charts-nav')
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (14, N'Thêm mới slide', 2, 13, 1, 1, NULL, N'admin', N'Slide', N'create', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (15, N'Chỉnh sửa slide', 2, 13, 2, 1, NULL, N'admin', N'Slide', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (16, N'Quản lý footer', 1, 0, 1, 1, N'footer-nav', N'admin', N'footer', N'index', N'bx bx-detail', N'footer-nav')
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (17, N'Thêm mới footer', 2, 16, 1, 1, NULL, N'admin', N'footer', N'create', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (18, N'Chỉnh sửa footer', 2, 16, 2, 1, NULL, N'admin', N'footer', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (19, N'Quản lý người dùng', 1, 0, 1, 1, NULL, N'admin', N'user', N'index', N'bx bxs-user-detail', NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (20, N'Thông tin người dùng', 2, 19, 2, 1, NULL, N'admin', N'user', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (21, N'Quản lý đặt hàng', 1, 0, 1, 1, NULL, N'admin', N'order', N'index', N'bi bi-bag-plus', NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (22, N'Yêu cầu huỷ đơn', 2, 21, 1, 1, NULL, N'admin', N'order', N'cancel', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (23, N'Toàn bộ đơn hàng', 2, 21, 3, 1, NULL, N'admin', N'order', N'index', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (24, N'Đang xác thực', 2, 21, 2, 1, NULL, N'admin', N'order', N'auth', NULL, NULL)
INSERT [dbo].[AdminMenu] ([id], [name], [level], [parentLevel], [order], [isActive], [target], [areaName], [controllerName], [actionName], [icon], [idName]) VALUES (25, N'Thêm tài khoản', 2, 19, 1, 1, NULL, N'admin', N'user', N'create', NULL, NULL)
SET IDENTITY_INSERT [dbo].[AdminMenu] OFF
GO
SET IDENTITY_INSERT [dbo].[AdminUser] ON 

INSERT [dbo].[AdminUser] ([UserID], [UserName], [Email], [Password], [IsActive]) VALUES (1, N'linh', N'phamthuylinh09112k3@gmail.com', N'111111111', 1)
INSERT [dbo].[AdminUser] ([UserID], [UserName], [Email], [Password], [IsActive]) VALUES (2, N'Ngan', N'dvsfd@gmail.com', N'1955df827ac298d7305b9d0ba4a4c783', 1)
SET IDENTITY_INSERT [dbo].[AdminUser] OFF
GO
INSERT [dbo].[Banner] ([Id], [Title], [Images]) VALUES (1, N'TRANG PHỤC', N'/images/trangphuc.jpg')
INSERT [dbo].[Banner] ([Id], [Title], [Images]) VALUES (2, N'PHỤ KIỆN', N'/images/phukien.jpg')
INSERT [dbo].[Banner] ([Id], [Title], [Images]) VALUES (3, N'LÀM ĐẸP', N'/images/lamdep.jpg')
GO
INSERT [dbo].[Benefit] ([Id], [Title], [Contents], [Icon]) VALUES (1, N'MIỄN PHÍ GIAO HÀNG', N'NHANH, GON, LẸ', N'fa fa-truck')
INSERT [dbo].[Benefit] ([Id], [Title], [Contents], [Icon]) VALUES (2, N'GIAO HÀNG TRỰC TUYẾN', N'ĐẢM BẢO CHẤT LƯỢNG', N'fa fa-money')
INSERT [dbo].[Benefit] ([Id], [Title], [Contents], [Icon]) VALUES (3, N'HOÀN TRẢ NAHH CHÓNG', N'ĐƯỢC HOÀN TRẢ 3-5 NGÀY', N'fa fa-undo')
INSERT [dbo].[Benefit] ([Id], [Title], [Contents], [Icon]) VALUES (4, N'THỜI GIAN HỢP LÍ', N'ĐẾN NƠI NHANH NHẤT', N'fa fa-clock-o')
GO
INSERT [dbo].[Dealoftheweek] ([Id], [Images]) VALUES (1, N'/images/single_1.jpg')
GO
SET IDENTITY_INSERT [dbo].[Footer] ON 

INSERT [dbo].[Footer] ([ID], [Title], [Contents], [Link]) VALUES (1, N'Blog', NULL, NULL)
INSERT [dbo].[Footer] ([ID], [Title], [Contents], [Link]) VALUES (2, N'FAQs', NULL, NULL)
INSERT [dbo].[Footer] ([ID], [Title], [Contents], [Link]) VALUES (3, N'Contacts Us', NULL, NULL)
INSERT [dbo].[Footer] ([ID], [Title], [Contents], [Link]) VALUES (4, NULL, N'Cảm ơn các bạn đã theo dõi chúng tôi. hẹn gặp lại', NULL)
SET IDENTITY_INSERT [dbo].[Footer] OFF
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([MenuID], [MenuName], [IsActive], [ControllerName], [ActionName], [Levels], [ParentID], [Link], [MenuOrder], [Position], [Icon]) VALUES (7, N'Trang chủ', 1, NULL, NULL, 1, 0, N'home', 1, 1, NULL)
INSERT [dbo].[Menu] ([MenuID], [MenuName], [IsActive], [ControllerName], [ActionName], [Levels], [ParentID], [Link], [MenuOrder], [Position], [Icon]) VALUES (2, N'Sản phẩm', 1, NULL, NULL, 1, 0, N'product', 2, 1, NULL)
INSERT [dbo].[Menu] ([MenuID], [MenuName], [IsActive], [ControllerName], [ActionName], [Levels], [ParentID], [Link], [MenuOrder], [Position], [Icon]) VALUES (3, N'Liên hệ', 1, NULL, NULL, 1, 0, N'contact', 3, 1, NULL)
INSERT [dbo].[Menu] ([MenuID], [MenuName], [IsActive], [ControllerName], [ActionName], [Levels], [ParentID], [Link], [MenuOrder], [Position], [Icon]) VALUES (4, N'Thông tin', 1, NULL, NULL, 1, 0, N'information', 4, 1, NULL)
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (1, N'Quanao', NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (2, N'Quanao', NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (3, N'Quanao', NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (4, NULL, NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (5, NULL, NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (6, NULL, NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (7, NULL, NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (8, NULL, NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (9, NULL, NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (10, NULL, NULL, 1, N'/images/trangphuc1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (11, NULL, NULL, 11, N'/images/phukien1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (12, NULL, NULL, 11, N'/images/phukien1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (13, NULL, NULL, 11, N'/images/phukien1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (14, NULL, NULL, 11, N'/images/phukien1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (15, NULL, NULL, 11, N'/images/phukien1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (16, NULL, NULL, 11, N'/images/phukien1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (17, NULL, NULL, 11, N'/images/phukien1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (18, NULL, NULL, 11, N'/images/phukien1.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (19, NULL, NULL, 12, N'/images/lamdep.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (20, NULL, NULL, 12, N'/images/lamdep.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (22, NULL, NULL, 12, N'/images/lamdep.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (23, NULL, NULL, 12, N'/images/lamdep.jpg')
INSERT [dbo].[NewArrivals] ([Id], [Title], [Contents], [ParentID], [Image]) VALUES (24, NULL, NULL, 12, N'/images/lamdep.jpg')
GO
SET IDENTITY_INSERT [dbo].[Slide] ON 

INSERT [dbo].[Slide] ([Id], [Title], [Contents], [Images], [IsActive]) VALUES (1, N'SPRING / SUMMER COLLECTION 2024', N'Get up to 30% Off New Arrivals', N'/images/slider_1.jpg', 1)
SET IDENTITY_INSERT [dbo].[Slide] OFF
GO
