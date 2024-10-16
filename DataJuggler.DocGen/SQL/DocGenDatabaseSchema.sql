Use [DocGen]

/****** Object:  Table [dbo].[CodeClass]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeClass](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodeFileId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Tags] [nvarchar](255) NULL,
	[IsPartial] [bit] NULL,
	[Status] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_CodeClass] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodeConstructor]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeConstructor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodeFileId] [int] NOT NULL,
	[CodeClassId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[StartLineNumber] [int] NOT NULL,
	[EndLineNumber] [int] NOT NULL,
	[ReturnType] [nvarchar](50) NULL,
	[Status] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_CodeConstructor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodeFile]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeFile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ParentId] [int] NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[FullPath] [nvarchar](255) NOT NULL,
	[PropertiesCount] [int] NOT NULL,
	[MethodsCount] [int] NOT NULL,
	[EventsCount] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_CodeFile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodeMethod]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeMethod](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodeFileId] [int] NOT NULL,
	[CodeClassId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[IsAsync] [bit] NULL,
	[StartLineNumber] [int] NOT NULL,
	[EndLineNumber] [int] NOT NULL,
	[ReturnType] [nvarchar](50) NULL,
	[ReferencedByPath] [nvarchar](255) NULL,
	[Status] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
	[IsEventHandler] [bit] NULL,
 CONSTRAINT [PK_CodeMethod] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodeParameter]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeParameter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentId] [int] NOT NULL,
	[ParentType] [int] NOT NULL,
	[ParameterType] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsOptional] [bit] NULL,
	[Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_Parameter] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodeProperty]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeProperty](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodeFileId] [int] NOT NULL,
	[CodeClassId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[StartLineNumber] [int] NOT NULL,
	[EndLineNumber] [int] NOT NULL,
	[ReturnType] [nvarchar](50) NULL,
	[Tags] [nvarchar](255) NULL,
	[Status] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_CodeProperty] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodeSample]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodeSample](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentId] [int] NOT NULL,
	[ParentType] [int] NOT NULL,
	[CodeType] [int] NOT NULL,
	[Text] [nvarchar](2000) NOT NULL,
	[Status] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_CodeSample] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReferencedBy]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReferencedBy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[CodeFileId] [int] NOT NULL,
	[SourceId] [int] NULL,
	[SourceType] [int] NULL,
	[TargetId] [int] NULL,
	[TargetType] [int] NULL,
	[LineNumber] [int] NOT NULL,
	[FilePath] [nvarchar](255) NULL,
	[Status] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_ReferencedBy] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VSProject]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VSProject](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SolutionId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[FullPath] [nvarchar](255) NOT NULL,
	[TargetFramework] [nvarchar](30) NOT NULL,
	[ProjectType] [nvarchar](30) NOT NULL,
	[IsPreview] [bit] NULL,
	[PreviewDescription] [nvarchar](255) NULL,
	[Status] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_VSProject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VSSolution]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VSSolution](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[FullPath] [nvarchar](255) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Status] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_VSSolution] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[CodeClass_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeClass_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CodeClass]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeClass_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeClass_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[Id],[IsPartial],[Name],[Status],[Tags],[Visible]

    -- From tableName
    From [CodeClass]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeClass_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeClass_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[Id],[IsPartial],[Name],[Status],[Tags],[Visible]

    -- From tableName
    From [CodeClass]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeClass_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeClass_Insert]

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @IsPartial bit,
    @Name nvarchar(50),
    @Status int,
    @Tags nvarchar(255),
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeClass]
    ([CodeFileId],[Description],[IsPartial],[Name],[Status],[Tags],[Visible])

    -- Begin Values List
    Values(@CodeFileId, @Description, @IsPartial, @Name, @Status, @Tags, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeClass_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeClass_Update]

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @Id int,
    @IsPartial bit,
    @Name nvarchar(50),
    @Status int,
    @Tags nvarchar(255),
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeClass]

    -- Update Each field
    Set [CodeFileId] = @CodeFileId,
    [Description] = @Description,
    [IsPartial] = @IsPartial,
    [Name] = @Name,
    [Status] = @Status,
    [Tags] = @Tags,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeConstructor_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeConstructor_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CodeConstructor]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeConstructor_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeConstructor_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReturnType],[StartLineNumber],[Status],[Visible]

    -- From tableName
    From [CodeConstructor]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeConstructor_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeConstructor_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReturnType],[StartLineNumber],[Status],[Visible]

    -- From tableName
    From [CodeConstructor]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeConstructor_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeConstructor_Insert]

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Name nvarchar(50),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeConstructor]
    ([CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Name],[ReturnType],[StartLineNumber],[Status],[Visible])

    -- Begin Values List
    Values(@CodeClassId, @CodeFileId, @Description, @EndLineNumber, @Name, @ReturnType, @StartLineNumber, @Status, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeConstructor_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeConstructor_Update]

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Id int,
    @Name nvarchar(50),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeConstructor]

    -- Update Each field
    Set [CodeClassId] = @CodeClassId,
    [CodeFileId] = @CodeFileId,
    [Description] = @Description,
    [EndLineNumber] = @EndLineNumber,
    [Name] = @Name,
    [ReturnType] = @ReturnType,
    [StartLineNumber] = @StartLineNumber,
    [Status] = @Status,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEvent_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEvent_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CodeEvent]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEvent_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEvent_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[EndLineNumber],[Id],[Name],[StartLineNumber],[Status],[Visible]

    -- From tableName
    From [CodeEvent]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEvent_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEvent_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[EndLineNumber],[Id],[Name],[StartLineNumber],[Status],[Visible]

    -- From tableName
    From [CodeEvent]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEvent_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEvent_Insert]

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Name nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeEvent]
    ([CodeFileId],[Description],[EndLineNumber],[Name],[StartLineNumber],[Status],[Visible])

    -- Begin Values List
    Values(@CodeFileId, @Description, @EndLineNumber, @Name, @StartLineNumber, @Status, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEvent_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEvent_Update]

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Id int,
    @Name nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeEvent]

    -- Update Each field
    Set [CodeFileId] = @CodeFileId,
    [Description] = @Description,
    [EndLineNumber] = @EndLineNumber,
    [Name] = @Name,
    [StartLineNumber] = @StartLineNumber,
    [Status] = @Status,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEventHandler_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEventHandler_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CodeEventHandler]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEventHandler_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEventHandler_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[StartLineNumber],[Status],[Visible]

    -- From tableName
    From [CodeEventHandler]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEventHandler_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEventHandler_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[StartLineNumber],[Status],[Visible]

    -- From tableName
    From [CodeEventHandler]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEventHandler_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEventHandler_Insert]

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Name nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeEventHandler]
    ([CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Name],[StartLineNumber],[Status],[Visible])

    -- Begin Values List
    Values(@CodeClassId, @CodeFileId, @Description, @EndLineNumber, @Name, @StartLineNumber, @Status, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeEventHandler_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeEventHandler_Update]

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Id int,
    @Name nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeEventHandler]

    -- Update Each field
    Set [CodeClassId] = @CodeClassId,
    [CodeFileId] = @CodeFileId,
    [Description] = @Description,
    [EndLineNumber] = @EndLineNumber,
    [Name] = @Name,
    [StartLineNumber] = @StartLineNumber,
    [Status] = @Status,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeFile_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeFile_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CodeFile]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeFile_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeFile_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[EventsCount],[FullPath],[Id],[MethodsCount],[Name],[ParentId],[ProjectId],[PropertiesCount],[Status],[Visible]

    -- From tableName
    From [CodeFile]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeFile_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeFile_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[EventsCount],[FullPath],[Id],[MethodsCount],[Name],[ParentId],[ProjectId],[PropertiesCount],[Status],[Visible]

    -- From tableName
    From [CodeFile]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeFile_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeFile_Insert]

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @EventsCount int,
    @FullPath nvarchar(255),
    @MethodsCount int,
    @Name nvarchar(50),
    @ParentId int,
    @ProjectId int,
    @PropertiesCount int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeFile]
    ([Description],[EventsCount],[FullPath],[MethodsCount],[Name],[ParentId],[ProjectId],[PropertiesCount],[Status],[Visible])

    -- Begin Values List
    Values(@Description, @EventsCount, @FullPath, @MethodsCount, @Name, @ParentId, @ProjectId, @PropertiesCount, @Status, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeFile_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeFile_Update]

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @EventsCount int,
    @FullPath nvarchar(255),
    @Id int,
    @MethodsCount int,
    @Name nvarchar(50),
    @ParentId int,
    @ProjectId int,
    @PropertiesCount int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeFile]

    -- Update Each field
    Set [Description] = @Description,
    [EventsCount] = @EventsCount,
    [FullPath] = @FullPath,
    [MethodsCount] = @MethodsCount,
    [Name] = @Name,
    [ParentId] = @ParentId,
    [ProjectId] = @ProjectId,
    [PropertiesCount] = @PropertiesCount,
    [Status] = @Status,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeMethod_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeMethod_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CodeMethod]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeMethod_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeMethod_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[IsAsync],[IsEventHandler],[Name],[ReferencedByPath],[ReturnType],[StartLineNumber],[Status],[Visible]

    -- From tableName
    From [CodeMethod]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeMethod_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeMethod_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[IsAsync],[IsEventHandler],[Name],[ReferencedByPath],[ReturnType],[StartLineNumber],[Status],[Visible]

    -- From tableName
    From [CodeMethod]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeMethod_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeMethod_Insert]

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @IsAsync bit,
    @IsEventHandler bit,
    @Name nvarchar(50),
    @ReferencedByPath nvarchar(255),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeMethod]
    ([CodeClassId],[CodeFileId],[Description],[EndLineNumber],[IsAsync],[IsEventHandler],[Name],[ReferencedByPath],[ReturnType],[StartLineNumber],[Status],[Visible])

    -- Begin Values List
    Values(@CodeClassId, @CodeFileId, @Description, @EndLineNumber, @IsAsync, @IsEventHandler, @Name, @ReferencedByPath, @ReturnType, @StartLineNumber, @Status, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeMethod_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeMethod_Update]

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Id int,
    @IsAsync bit,
    @IsEventHandler bit,
    @Name nvarchar(50),
    @ReferencedByPath nvarchar(255),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeMethod]

    -- Update Each field
    Set [CodeClassId] = @CodeClassId,
    [CodeFileId] = @CodeFileId,
    [Description] = @Description,
    [EndLineNumber] = @EndLineNumber,
    [IsAsync] = @IsAsync,
    [IsEventHandler] = @IsEventHandler,
    [Name] = @Name,
    [ReferencedByPath] = @ReferencedByPath,
    [ReturnType] = @ReturnType,
    [StartLineNumber] = @StartLineNumber,
    [Status] = @Status,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeParameter_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeParameter_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CodeParameter]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeParameter_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeParameter_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[Id],[IsOptional],[Name],[ParameterType],[ParentId],[ParentType]

    -- From tableName
    From [CodeParameter]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeParameter_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeParameter_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[Id],[IsOptional],[Name],[ParameterType],[ParentId],[ParentType]

    -- From tableName
    From [CodeParameter]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeParameter_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeParameter_Insert]

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @IsOptional bit,
    @Name nvarchar(50),
    @ParameterType nvarchar(50),
    @ParentId int,
    @ParentType int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeParameter]
    ([Description],[IsOptional],[Name],[ParameterType],[ParentId],[ParentType])

    -- Begin Values List
    Values(@Description, @IsOptional, @Name, @ParameterType, @ParentId, @ParentType)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeParameter_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeParameter_Update]

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @Id int,
    @IsOptional bit,
    @Name nvarchar(50),
    @ParameterType nvarchar(50),
    @ParentId int,
    @ParentType int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeParameter]

    -- Update Each field
    Set [Description] = @Description,
    [IsOptional] = @IsOptional,
    [Name] = @Name,
    [ParameterType] = @ParameterType,
    [ParentId] = @ParentId,
    [ParentType] = @ParentType

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeProperty_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeProperty_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CodeProperty]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeProperty_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeProperty_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReturnType],[StartLineNumber],[Status],[Tags],[Visible]

    -- From tableName
    From [CodeProperty]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeProperty_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeProperty_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReturnType],[StartLineNumber],[Status],[Tags],[Visible]

    -- From tableName
    From [CodeProperty]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeProperty_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeProperty_Insert]

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Name nvarchar(50),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Tags nvarchar(255),
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeProperty]
    ([CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Name],[ReturnType],[StartLineNumber],[Status],[Tags],[Visible])

    -- Begin Values List
    Values(@CodeClassId, @CodeFileId, @Description, @EndLineNumber, @Name, @ReturnType, @StartLineNumber, @Status, @Tags, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeProperty_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeProperty_Update]

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Id int,
    @Name nvarchar(50),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int,
    @Tags nvarchar(255),
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeProperty]

    -- Update Each field
    Set [CodeClassId] = @CodeClassId,
    [CodeFileId] = @CodeFileId,
    [Description] = @Description,
    [EndLineNumber] = @EndLineNumber,
    [Name] = @Name,
    [ReturnType] = @ReturnType,
    [StartLineNumber] = @StartLineNumber,
    [Status] = @Status,
    [Tags] = @Tags,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeSample_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeSample_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CodeSample]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeSample_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeSample_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeType],[Id],[ParentId],[ParentType],[Status],[Text],[Visible]

    -- From tableName
    From [CodeSample]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeSample_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeSample_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeType],[Id],[ParentId],[ParentType],[Status],[Text],[Visible]

    -- From tableName
    From [CodeSample]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeSample_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeSample_Insert]

    -- Add the parameters for the stored procedure here
    @CodeType int,
    @ParentId int,
    @ParentType int,
    @Status int,
    @Text nvarchar(2000),
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeSample]
    ([CodeType],[ParentId],[ParentType],[Status],[Text],[Visible])

    -- Begin Values List
    Values(@CodeType, @ParentId, @ParentType, @Status, @Text, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CodeSample_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CodeSample_Update]

    -- Add the parameters for the stored procedure here
    @CodeType int,
    @Id int,
    @ParentId int,
    @ParentType int,
    @Status int,
    @Text nvarchar(2000),
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeSample]

    -- Update Each field
    Set [CodeType] = @CodeType,
    [ParentId] = @ParentId,
    [ParentType] = @ParentType,
    [Status] = @Status,
    [Text] = @Text,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[ReferencedBy_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ReferencedBy_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [ReferencedBy]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[ReferencedBy_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ReferencedBy_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[FilePath],[Id],[LineNumber],[ProjectId],[SourceId],[SourceType],[Status],[TargetId],[TargetType],[Visible]

    -- From tableName
    From [ReferencedBy]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[ReferencedBy_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ReferencedBy_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[FilePath],[Id],[LineNumber],[ProjectId],[SourceId],[SourceType],[Status],[TargetId],[TargetType],[Visible]

    -- From tableName
    From [ReferencedBy]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[ReferencedBy_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ReferencedBy_Insert]

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @FilePath nvarchar(255),
    @LineNumber int,
    @ProjectId int,
    @SourceId int,
    @SourceType int,
    @Status int,
    @TargetId int,
    @TargetType int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [ReferencedBy]
    ([CodeFileId],[FilePath],[LineNumber],[ProjectId],[SourceId],[SourceType],[Status],[TargetId],[TargetType],[Visible])

    -- Begin Values List
    Values(@CodeFileId, @FilePath, @LineNumber, @ProjectId, @SourceId, @SourceType, @Status, @TargetId, @TargetType, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[ReferencedBy_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[ReferencedBy_Update]

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @FilePath nvarchar(255),
    @Id int,
    @LineNumber int,
    @ProjectId int,
    @SourceId int,
    @SourceType int,
    @Status int,
    @TargetId int,
    @TargetType int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [ReferencedBy]

    -- Update Each field
    Set [CodeFileId] = @CodeFileId,
    [FilePath] = @FilePath,
    [LineNumber] = @LineNumber,
    [ProjectId] = @ProjectId,
    [SourceId] = @SourceId,
    [SourceType] = @SourceType,
    [Status] = @Status,
    [TargetId] = @TargetId,
    [TargetType] = @TargetType,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[VSProject_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSProject_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [VSProject]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[VSProject_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSProject_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[FullPath],[Id],[IsPreview],[Name],[PreviewDescription],[ProjectType],[SolutionId],[Status],[TargetFramework],[Visible]

    -- From tableName
    From [VSProject]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[VSProject_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSProject_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[FullPath],[Id],[IsPreview],[Name],[PreviewDescription],[ProjectType],[SolutionId],[Status],[TargetFramework],[Visible]

    -- From tableName
    From [VSProject]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[VSProject_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSProject_Insert]

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @FullPath nvarchar(255),
    @IsPreview bit,
    @Name nvarchar(50),
    @PreviewDescription nvarchar(255),
    @ProjectType nvarchar(30),
    @SolutionId int,
    @Status int,
    @TargetFramework nvarchar(30),
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [VSProject]
    ([Description],[FullPath],[IsPreview],[Name],[PreviewDescription],[ProjectType],[SolutionId],[Status],[TargetFramework],[Visible])

    -- Begin Values List
    Values(@Description, @FullPath, @IsPreview, @Name, @PreviewDescription, @ProjectType, @SolutionId, @Status, @TargetFramework, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[VSProject_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSProject_Update]

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @FullPath nvarchar(255),
    @Id int,
    @IsPreview bit,
    @Name nvarchar(50),
    @PreviewDescription nvarchar(255),
    @ProjectType nvarchar(30),
    @SolutionId int,
    @Status int,
    @TargetFramework nvarchar(30),
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [VSProject]

    -- Update Each field
    Set [Description] = @Description,
    [FullPath] = @FullPath,
    [IsPreview] = @IsPreview,
    [Name] = @Name,
    [PreviewDescription] = @PreviewDescription,
    [ProjectType] = @ProjectType,
    [SolutionId] = @SolutionId,
    [Status] = @Status,
    [TargetFramework] = @TargetFramework,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[VSSolution_Delete]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSSolution_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [VSSolution]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[VSSolution_FetchAll]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSSolution_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CreatedDate],[Description],[FullPath],[Id],[Name],[Status],[Visible]

    -- From tableName
    From [VSSolution]

END

-- Thank you for using DataTier.Net.

GO
/****** Object:  StoredProcedure [dbo].[VSSolution_Find]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSSolution_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CreatedDate],[Description],[FullPath],[Id],[Name],[Status],[Visible]

    -- From tableName
    From [VSSolution]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[VSSolution_Insert]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSSolution_Insert]

    -- Add the parameters for the stored procedure here
    @CreatedDate datetime,
    @Description nvarchar(255),
    @FullPath nvarchar(255),
    @Name nvarchar(50),
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [VSSolution]
    ([CreatedDate],[Description],[FullPath],[Name],[Status],[Visible])

    -- Begin Values List
    Values(@CreatedDate, @Description, @FullPath, @Name, @Status, @Visible)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[VSSolution_Update]    Script Date: 10/16/2024 7:15:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[VSSolution_Update]

    -- Add the parameters for the stored procedure here
    @CreatedDate datetime,
    @Description nvarchar(255),
    @FullPath nvarchar(255),
    @Id int,
    @Name nvarchar(50),
    @Status int,
    @Visible bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [VSSolution]

    -- Update Each field
    Set [CreatedDate] = @CreatedDate,
    [Description] = @Description,
    [FullPath] = @FullPath,
    [Name] = @Name,
    [Status] = @Status,
    [Visible] = @Visible

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
