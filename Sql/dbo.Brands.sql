CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT           NOT NULL identity(1,1),
    [BrandName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([BrandId] ASC)
);

