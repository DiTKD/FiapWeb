IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Perguntas] (
    [id] int NOT NULL IDENTITY,
    [Descricao] nvarchar(max) NOT NULL,
    [Aluno] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Perguntas] PRIMARY KEY ([id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180929175201_firts', N'2.1.3-rtm-32065');

GO

