CREATE TABLE [dbo].[Rentals] (
    [CarId]      INT      NOT NULL,
    [CustomerId] INT      NOT NULL,
    [RentDate]   DATETIME NOT NULL,
    [ReturnDate] DATETIME NULL,
    [RentId]     INT      IDENTITY (1, 1) NOT NULL,
    FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([Id]),
    FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]), 
    CONSTRAINT [PK_Rentals] PRIMARY KEY ([RentId])
);

