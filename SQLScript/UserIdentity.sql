



USE [Identity]
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EC_RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_EC_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



--------------------------------------------
/****** Object:  Table [dbo].[EC_Roles]    Script Date: 2021-03-31 10:03:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EC_Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_EC_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



/****** Object:  Table [dbo].[EC_UserClaims]    Script Date: 2021-03-31 10:06:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EC_UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_EC_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [dbo].[IdentityClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_IdentityClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO




/****** Object:  Table [dbo].[EC_UserLogins]    Script Date: 2021-03-31 10:07:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EC_UserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_EC_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



/****** Object:  Table [dbo].[EC_UserRoles]    Script Date: 2021-03-31 10:07:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EC_UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_EC_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[EC_Users]    Script Date: 2021-03-31 10:08:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EC_Users](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[FirstName] [nvarchar](256) NULL,
	[LastName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_EC_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


/****** Object:  Table [dbo].[EC_UserTokens]    Script Date: 2021-03-31 10:08:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EC_UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_EC_UserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


ALTER TABLE [dbo].[EC_RoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_EC_RoleClaims_EC_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[EC_Roles] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[EC_RoleClaims] CHECK CONSTRAINT [FK_EC_RoleClaims_EC_Roles_RoleId]
GO


ALTER TABLE [dbo].[EC_UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_EC_UserClaims_EC_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[EC_Users] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[EC_UserClaims] CHECK CONSTRAINT [FK_EC_UserClaims_EC_Users_UserId]
GO
ALTER TABLE [dbo].[EC_UserLogins]  WITH CHECK ADD  CONSTRAINT [FK_EC_UserLogins_EC_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[EC_Users] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[EC_UserLogins] CHECK CONSTRAINT [FK_EC_UserLogins_EC_Users_UserId]
GO

ALTER TABLE [dbo].[EC_UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_EC_UserRoles_EC_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[EC_Roles] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[EC_UserRoles] CHECK CONSTRAINT [FK_EC_UserRoles_EC_Roles_RoleId]
GO
ALTER TABLE [dbo].[EC_UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_EC_UserRoles_EC_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[EC_Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EC_UserRoles] CHECK CONSTRAINT [FK_EC_UserRoles_EC_Users_UserId]
GO
ALTER TABLE [dbo].[EC_UserTokens]  WITH CHECK ADD  CONSTRAINT [FK_EC_UserTokens_EC_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[EC_Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EC_UserTokens] CHECK CONSTRAINT [FK_EC_UserTokens_EC_Users_UserId]
GO

