IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221114063029_Initial')
BEGIN
    CREATE TABLE [HomebrewItems] (
        [ItemID] int NOT NULL IDENTITY,
        [ItemName] nvarchar(max) NULL,
        [ItemRarity] nvarchar(max) NULL,
        [ItemType] nvarchar(max) NULL,
        [ItemEffect] nvarchar(max) NULL,
        [Attunement] bit NOT NULL,
        [UserName] nvarchar(max) NULL,
        [DateAdded] datetime2 NOT NULL,
        CONSTRAINT [PK_HomebrewItems] PRIMARY KEY ([ItemID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221114063029_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221114063029_Initial', N'3.1.30');
END;

GO

