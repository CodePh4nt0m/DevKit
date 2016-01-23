
CREATE TABLE [DBServer] (
  [ServerID] int IDENTITY (1,1) NOT NULL
, [Servername] nvarchar(100) NULL
, [Username] nvarchar(100) NULL
, [Password] nvarchar(100) NULL
, [Database] nvarchar(150) NULL
, [IsMain] bit NULL
);
GO
ALTER TABLE [DBServer] ADD CONSTRAINT [PK_DBServer] PRIMARY KEY ([ServerID]);
GO

CREATE TABLE [StoredProcedure] (
  [Id] bigint IDENTITY (1,1) NOT NULL
, [SPName] nvarchar(500) NULL
, [CreatedDate] datetime NULL
, [SPDate] datetime NULL
);
GO
ALTER TABLE [StoredProcedure] ADD CONSTRAINT [PK_StoredProcedure] PRIMARY KEY ([Id]);
GO