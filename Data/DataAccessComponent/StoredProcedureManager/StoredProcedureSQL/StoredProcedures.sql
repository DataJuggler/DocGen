Use [DocGen]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeClass_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new CodeClass
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeClass_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeClass_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeClass_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeClass_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeClass_Insert >>>'

    End

GO

Create PROCEDURE CodeClass_Insert

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @Name nvarchar(50),
    @Status int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeClass]
    ([CodeFileId],[Description],[Name],[Status])

    -- Begin Values List
    Values(@CodeFileId, @Description, @Name, @Status)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeClass_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing CodeClass
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeClass_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeClass_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeClass_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeClass_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeClass_Update >>>'

    End

GO

Create PROCEDURE CodeClass_Update

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @Id int,
    @Name nvarchar(50),
    @Status int

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
    [Name] = @Name,
    [Status] = @Status

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeClass_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing CodeClass
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeClass_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeClass_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeClass_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeClass_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeClass_Find >>>'

    End

GO

Create PROCEDURE CodeClass_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[Id],[Name],[Status]

    -- From tableName
    From [CodeClass]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeClass_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing CodeClass
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeClass_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeClass_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeClass_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeClass_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeClass_Delete >>>'

    End

GO

Create PROCEDURE CodeClass_Delete

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
Go
-- =========================================================
-- Procure Name: CodeClass_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all CodeClass objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeClass_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeClass_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeClass_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeClass_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeClass_FetchAll >>>'

    End

GO

Create PROCEDURE CodeClass_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[Id],[Name],[Status]

    -- From tableName
    From [CodeClass]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeConstructor_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new CodeConstructor
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeConstructor_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeConstructor_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeConstructor_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeConstructor_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeConstructor_Insert >>>'

    End

GO

Create PROCEDURE CodeConstructor_Insert

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Name nvarchar(50),
    @ReferencedByPath nvarchar(255),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeConstructor]
    ([CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Name],[ReferencedByPath],[ReturnType],[StartLineNumber],[Status])

    -- Begin Values List
    Values(@CodeClassId, @CodeFileId, @Description, @EndLineNumber, @Name, @ReferencedByPath, @ReturnType, @StartLineNumber, @Status)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeConstructor_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing CodeConstructor
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeConstructor_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeConstructor_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeConstructor_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeConstructor_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeConstructor_Update >>>'

    End

GO

Create PROCEDURE CodeConstructor_Update

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Id int,
    @Name nvarchar(50),
    @ReferencedByPath nvarchar(255),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int

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
    [ReferencedByPath] = @ReferencedByPath,
    [ReturnType] = @ReturnType,
    [StartLineNumber] = @StartLineNumber,
    [Status] = @Status

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeConstructor_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing CodeConstructor
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeConstructor_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeConstructor_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeConstructor_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeConstructor_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeConstructor_Find >>>'

    End

GO

Create PROCEDURE CodeConstructor_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReferencedByPath],[ReturnType],[StartLineNumber],[Status]

    -- From tableName
    From [CodeConstructor]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeConstructor_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing CodeConstructor
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeConstructor_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeConstructor_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeConstructor_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeConstructor_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeConstructor_Delete >>>'

    End

GO

Create PROCEDURE CodeConstructor_Delete

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
Go
-- =========================================================
-- Procure Name: CodeConstructor_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all CodeConstructor objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeConstructor_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeConstructor_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeConstructor_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeConstructor_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeConstructor_FetchAll >>>'

    End

GO

Create PROCEDURE CodeConstructor_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReferencedByPath],[ReturnType],[StartLineNumber],[Status]

    -- From tableName
    From [CodeConstructor]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeEvent_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new CodeEvent
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeEvent_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeEvent_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeEvent_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeEvent_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeEvent_Insert >>>'

    End

GO

Create PROCEDURE CodeEvent_Insert

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Name nvarchar(50),
    @StartLineNumber int,
    @Status int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeEvent]
    ([CodeFileId],[Description],[EndLineNumber],[Name],[StartLineNumber],[Status])

    -- Begin Values List
    Values(@CodeFileId, @Description, @EndLineNumber, @Name, @StartLineNumber, @Status)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeEvent_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing CodeEvent
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeEvent_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeEvent_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeEvent_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeEvent_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeEvent_Update >>>'

    End

GO

Create PROCEDURE CodeEvent_Update

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Id int,
    @Name nvarchar(50),
    @StartLineNumber int,
    @Status int

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
    [Status] = @Status

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeEvent_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing CodeEvent
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeEvent_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeEvent_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeEvent_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeEvent_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeEvent_Find >>>'

    End

GO

Create PROCEDURE CodeEvent_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[EndLineNumber],[Id],[Name],[StartLineNumber],[Status]

    -- From tableName
    From [CodeEvent]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeEvent_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing CodeEvent
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeEvent_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeEvent_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeEvent_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeEvent_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeEvent_Delete >>>'

    End

GO

Create PROCEDURE CodeEvent_Delete

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
Go
-- =========================================================
-- Procure Name: CodeEvent_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all CodeEvent objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeEvent_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeEvent_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeEvent_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeEvent_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeEvent_FetchAll >>>'

    End

GO

Create PROCEDURE CodeEvent_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[EndLineNumber],[Id],[Name],[StartLineNumber],[Status]

    -- From tableName
    From [CodeEvent]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeFile_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new CodeFile
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeFile_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeFile_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeFile_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeFile_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeFile_Insert >>>'

    End

GO

Create PROCEDURE CodeFile_Insert

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @EventsCount int,
    @FullPath nvarchar(255),
    @MethodsCount int,
    @Name nvarchar(50),
    @ProjectId int,
    @PropertiesCount int,
    @Status int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeFile]
    ([Description],[EventsCount],[FullPath],[MethodsCount],[Name],[ProjectId],[PropertiesCount],[Status])

    -- Begin Values List
    Values(@Description, @EventsCount, @FullPath, @MethodsCount, @Name, @ProjectId, @PropertiesCount, @Status)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeFile_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing CodeFile
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeFile_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeFile_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeFile_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeFile_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeFile_Update >>>'

    End

GO

Create PROCEDURE CodeFile_Update

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @EventsCount int,
    @FullPath nvarchar(255),
    @Id int,
    @MethodsCount int,
    @Name nvarchar(50),
    @ProjectId int,
    @PropertiesCount int,
    @Status int

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
    [ProjectId] = @ProjectId,
    [PropertiesCount] = @PropertiesCount,
    [Status] = @Status

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeFile_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing CodeFile
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeFile_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeFile_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeFile_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeFile_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeFile_Find >>>'

    End

GO

Create PROCEDURE CodeFile_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[EventsCount],[FullPath],[Id],[MethodsCount],[Name],[ProjectId],[PropertiesCount],[Status]

    -- From tableName
    From [CodeFile]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeFile_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing CodeFile
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeFile_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeFile_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeFile_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeFile_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeFile_Delete >>>'

    End

GO

Create PROCEDURE CodeFile_Delete

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
Go
-- =========================================================
-- Procure Name: CodeFile_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all CodeFile objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeFile_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeFile_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeFile_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeFile_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeFile_FetchAll >>>'

    End

GO

Create PROCEDURE CodeFile_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[EventsCount],[FullPath],[Id],[MethodsCount],[Name],[ProjectId],[PropertiesCount],[Status]

    -- From tableName
    From [CodeFile]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeMethod_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new CodeMethod
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeMethod_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeMethod_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeMethod_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeMethod_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeMethod_Insert >>>'

    End

GO

Create PROCEDURE CodeMethod_Insert

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Name nvarchar(50),
    @ReferencedByPath nvarchar(255),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeMethod]
    ([CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Name],[ReferencedByPath],[ReturnType],[StartLineNumber],[Status])

    -- Begin Values List
    Values(@CodeClassId, @CodeFileId, @Description, @EndLineNumber, @Name, @ReferencedByPath, @ReturnType, @StartLineNumber, @Status)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeMethod_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing CodeMethod
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeMethod_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeMethod_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeMethod_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeMethod_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeMethod_Update >>>'

    End

GO

Create PROCEDURE CodeMethod_Update

    -- Add the parameters for the stored procedure here
    @CodeClassId int,
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Id int,
    @Name nvarchar(50),
    @ReferencedByPath nvarchar(255),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int

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
    [Name] = @Name,
    [ReferencedByPath] = @ReferencedByPath,
    [ReturnType] = @ReturnType,
    [StartLineNumber] = @StartLineNumber,
    [Status] = @Status

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeMethod_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing CodeMethod
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeMethod_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeMethod_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeMethod_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeMethod_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeMethod_Find >>>'

    End

GO

Create PROCEDURE CodeMethod_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReferencedByPath],[ReturnType],[StartLineNumber],[Status]

    -- From tableName
    From [CodeMethod]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeMethod_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing CodeMethod
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeMethod_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeMethod_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeMethod_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeMethod_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeMethod_Delete >>>'

    End

GO

Create PROCEDURE CodeMethod_Delete

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
Go
-- =========================================================
-- Procure Name: CodeMethod_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all CodeMethod objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeMethod_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeMethod_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeMethod_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeMethod_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeMethod_FetchAll >>>'

    End

GO

Create PROCEDURE CodeMethod_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeClassId],[CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReferencedByPath],[ReturnType],[StartLineNumber],[Status]

    -- From tableName
    From [CodeMethod]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeParameter_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new CodeParameter
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeParameter_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeParameter_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeParameter_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeParameter_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeParameter_Insert >>>'

    End

GO

Create PROCEDURE CodeParameter_Insert

    -- Add the parameters for the stored procedure here
    @CodeEventId int,
    @CodeMethodId int,
    @Description nvarchar(255),
    @IsOptional bit,
    @Name nvarchar(50),
    @ParameterType nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeParameter]
    ([CodeEventId],[CodeMethodId],[Description],[IsOptional],[Name],[ParameterType])

    -- Begin Values List
    Values(@CodeEventId, @CodeMethodId, @Description, @IsOptional, @Name, @ParameterType)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeParameter_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing CodeParameter
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeParameter_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeParameter_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeParameter_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeParameter_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeParameter_Update >>>'

    End

GO

Create PROCEDURE CodeParameter_Update

    -- Add the parameters for the stored procedure here
    @CodeEventId int,
    @CodeMethodId int,
    @Description nvarchar(255),
    @Id int,
    @IsOptional bit,
    @Name nvarchar(50),
    @ParameterType nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeParameter]

    -- Update Each field
    Set [CodeEventId] = @CodeEventId,
    [CodeMethodId] = @CodeMethodId,
    [Description] = @Description,
    [IsOptional] = @IsOptional,
    [Name] = @Name,
    [ParameterType] = @ParameterType

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeParameter_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing CodeParameter
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeParameter_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeParameter_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeParameter_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeParameter_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeParameter_Find >>>'

    End

GO

Create PROCEDURE CodeParameter_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeEventId],[CodeMethodId],[Description],[Id],[IsOptional],[Name],[ParameterType]

    -- From tableName
    From [CodeParameter]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeParameter_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing CodeParameter
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeParameter_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeParameter_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeParameter_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeParameter_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeParameter_Delete >>>'

    End

GO

Create PROCEDURE CodeParameter_Delete

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
Go
-- =========================================================
-- Procure Name: CodeParameter_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all CodeParameter objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeParameter_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeParameter_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeParameter_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeParameter_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeParameter_FetchAll >>>'

    End

GO

Create PROCEDURE CodeParameter_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeEventId],[CodeMethodId],[Description],[Id],[IsOptional],[Name],[ParameterType]

    -- From tableName
    From [CodeParameter]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeProperty_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new CodeProperty
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeProperty_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeProperty_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeProperty_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeProperty_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeProperty_Insert >>>'

    End

GO

Create PROCEDURE CodeProperty_Insert

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Name nvarchar(50),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CodeProperty]
    ([CodeFileId],[Description],[EndLineNumber],[Name],[ReturnType],[StartLineNumber],[Status])

    -- Begin Values List
    Values(@CodeFileId, @Description, @EndLineNumber, @Name, @ReturnType, @StartLineNumber, @Status)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeProperty_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing CodeProperty
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeProperty_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeProperty_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeProperty_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeProperty_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeProperty_Update >>>'

    End

GO

Create PROCEDURE CodeProperty_Update

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @Description nvarchar(255),
    @EndLineNumber int,
    @Id int,
    @Name nvarchar(50),
    @ReturnType nvarchar(50),
    @StartLineNumber int,
    @Status int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CodeProperty]

    -- Update Each field
    Set [CodeFileId] = @CodeFileId,
    [Description] = @Description,
    [EndLineNumber] = @EndLineNumber,
    [Name] = @Name,
    [ReturnType] = @ReturnType,
    [StartLineNumber] = @StartLineNumber,
    [Status] = @Status

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeProperty_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing CodeProperty
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeProperty_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeProperty_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeProperty_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeProperty_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeProperty_Find >>>'

    End

GO

Create PROCEDURE CodeProperty_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReturnType],[StartLineNumber],[Status]

    -- From tableName
    From [CodeProperty]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CodeProperty_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing CodeProperty
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeProperty_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeProperty_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeProperty_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeProperty_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeProperty_Delete >>>'

    End

GO

Create PROCEDURE CodeProperty_Delete

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
Go
-- =========================================================
-- Procure Name: CodeProperty_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all CodeProperty objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CodeProperty_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CodeProperty_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CodeProperty_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CodeProperty_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CodeProperty_FetchAll >>>'

    End

GO

Create PROCEDURE CodeProperty_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[Description],[EndLineNumber],[Id],[Name],[ReturnType],[StartLineNumber],[Status]

    -- From tableName
    From [CodeProperty]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ReferencedBy_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new ReferencedBy
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencedBy_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencedBy_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencedBy_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencedBy_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencedBy_Insert >>>'

    End

GO

Create PROCEDURE ReferencedBy_Insert

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @FilePath nvarchar(255),
    @LineNumber int,
    @ProjectId int,
    @SourceId int,
    @SourceType int,
    @TargetId int,
    @TargetType int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [ReferencedBy]
    ([CodeFileId],[FilePath],[LineNumber],[ProjectId],[SourceId],[SourceType],[TargetId],[TargetType])

    -- Begin Values List
    Values(@CodeFileId, @FilePath, @LineNumber, @ProjectId, @SourceId, @SourceType, @TargetId, @TargetType)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ReferencedBy_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing ReferencedBy
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencedBy_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencedBy_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencedBy_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencedBy_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencedBy_Update >>>'

    End

GO

Create PROCEDURE ReferencedBy_Update

    -- Add the parameters for the stored procedure here
    @CodeFileId int,
    @FilePath nvarchar(255),
    @Id int,
    @LineNumber int,
    @ProjectId int,
    @SourceId int,
    @SourceType int,
    @TargetId int,
    @TargetType int

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
    [TargetId] = @TargetId,
    [TargetType] = @TargetType

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ReferencedBy_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing ReferencedBy
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencedBy_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencedBy_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencedBy_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencedBy_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencedBy_Find >>>'

    End

GO

Create PROCEDURE ReferencedBy_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[FilePath],[Id],[LineNumber],[ProjectId],[SourceId],[SourceType],[TargetId],[TargetType]

    -- From tableName
    From [ReferencedBy]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ReferencedBy_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing ReferencedBy
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencedBy_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencedBy_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencedBy_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencedBy_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencedBy_Delete >>>'

    End

GO

Create PROCEDURE ReferencedBy_Delete

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
Go
-- =========================================================
-- Procure Name: ReferencedBy_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all ReferencedBy objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencedBy_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencedBy_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencedBy_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencedBy_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencedBy_FetchAll >>>'

    End

GO

Create PROCEDURE ReferencedBy_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeFileId],[FilePath],[Id],[LineNumber],[ProjectId],[SourceId],[SourceType],[TargetId],[TargetType]

    -- From tableName
    From [ReferencedBy]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: VSProject_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new VSProject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSProject_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSProject_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSProject_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSProject_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSProject_Insert >>>'

    End

GO

Create PROCEDURE VSProject_Insert

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @FullPath nvarchar(255),
    @Name nvarchar(50),
    @SolutionId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [VSProject]
    ([Description],[FullPath],[Name],[SolutionId])

    -- Begin Values List
    Values(@Description, @FullPath, @Name, @SolutionId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: VSProject_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing VSProject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSProject_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSProject_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSProject_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSProject_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSProject_Update >>>'

    End

GO

Create PROCEDURE VSProject_Update

    -- Add the parameters for the stored procedure here
    @Description nvarchar(255),
    @FullPath nvarchar(255),
    @Id int,
    @Name nvarchar(50),
    @SolutionId int

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
    [Name] = @Name,
    [SolutionId] = @SolutionId

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: VSProject_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing VSProject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSProject_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSProject_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSProject_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSProject_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSProject_Find >>>'

    End

GO

Create PROCEDURE VSProject_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[FullPath],[Id],[Name],[SolutionId]

    -- From tableName
    From [VSProject]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: VSProject_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing VSProject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSProject_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSProject_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSProject_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSProject_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSProject_Delete >>>'

    End

GO

Create PROCEDURE VSProject_Delete

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
Go
-- =========================================================
-- Procure Name: VSProject_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all VSProject objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSProject_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSProject_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSProject_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSProject_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSProject_FetchAll >>>'

    End

GO

Create PROCEDURE VSProject_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Description],[FullPath],[Id],[Name],[SolutionId]

    -- From tableName
    From [VSProject]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: VSSolution_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Insert a new VSSolution
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSSolution_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSSolution_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSSolution_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSSolution_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSSolution_Insert >>>'

    End

GO

Create PROCEDURE VSSolution_Insert

    -- Add the parameters for the stored procedure here
    @CreatedDate datetime,
    @Description nvarchar(255),
    @FullPath nvarchar(255),
    @Name nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [VSSolution]
    ([CreatedDate],[Description],[FullPath],[Name])

    -- Begin Values List
    Values(@CreatedDate, @Description, @FullPath, @Name)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: VSSolution_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Update an existing VSSolution
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSSolution_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSSolution_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSSolution_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSSolution_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSSolution_Update >>>'

    End

GO

Create PROCEDURE VSSolution_Update

    -- Add the parameters for the stored procedure here
    @CreatedDate datetime,
    @Description nvarchar(255),
    @FullPath nvarchar(255),
    @Id int,
    @Name nvarchar(50)

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
    [Name] = @Name

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: VSSolution_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Find an existing VSSolution
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSSolution_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSSolution_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSSolution_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSSolution_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSSolution_Find >>>'

    End

GO

Create PROCEDURE VSSolution_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CreatedDate],[Description],[FullPath],[Id],[Name]

    -- From tableName
    From [VSSolution]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: VSSolution_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Delete an existing VSSolution
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSSolution_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSSolution_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSSolution_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSSolution_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSSolution_Delete >>>'

    End

GO

Create PROCEDURE VSSolution_Delete

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
Go
-- =========================================================
-- Procure Name: VSSolution_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   10/11/2024
-- Description:    Returns all VSSolution objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('VSSolution_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure VSSolution_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.VSSolution_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure VSSolution_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure VSSolution_FetchAll >>>'

    End

GO

Create PROCEDURE VSSolution_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CreatedDate],[Description],[FullPath],[Id],[Name]

    -- From tableName
    From [VSSolution]

END

-- Thank you for using DataTier.Net.

