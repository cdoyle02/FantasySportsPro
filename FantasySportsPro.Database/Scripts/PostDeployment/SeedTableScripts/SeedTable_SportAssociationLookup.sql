DROP PROCEDURE IF EXISTS [dbo].[SeedTable_SportAssociationLookUp]

GO

CREATE PROCEDURE [dbo].[SeedTable_SportAssociationLookUp] AS
BEGIN

    PRINT 'Populating records in [dbo].[SportAssociationLookUp]';

    IF OBJECT_ID('tempdb.dbo.#dbo_SeedSportAssociationLookUp') IS NOT NULL DROP TABLE #dbo_SeedSportAssociationLookUp;

    SELECT 
        [Id], [Abbreviation], [Name] 
    INTO #dbo_SeedSportAssociationLookUp 
    FROM [dbo].[SportAssociationLookUp] 
    WHERE 0 = 1;

    INSERT INTO #dbo_SeedSportAssociationLookUp 
        ( [Id], [Abbreviation], [Name] )
    SELECT 
          [Id], [Abbreviation], [Name] 
    FROM 
    (  VALUES
            (1, 'NFL', 'National Football League')
          , (2, 'NBA', 'National Basketball Association')
          , (3, 'NHL', 'National Hockey League')
    ) AS v ( [Id], [Abbreviation], [Name] );

    WITH cte_data as 
        (SELECT 
            [Id], [Abbreviation], [Name] 
        FROM #dbo_SeedSportAssociationLookUp)
    MERGE [dbo].[SportAssociationLookUp] as t
        USING cte_data as s ON t.[Id] = s.[Id]
        WHEN NOT MATCHED BY TARGET THEN
            INSERT 
                ([Id], [Abbreviation], [Name])
            VALUES 
                (s.[Id], s.[Abbreviation], s.[Name])
        WHEN MATCHED 
            THEN UPDATE SET 
                [Name] = s.[Name], [Abbreviation] = s.[Abbreviation]
    ;

    DROP TABLE #dbo_SeedSportAssociationLookUp;

    PRINT 'Finished Populating records in [dbo].[SportAssociationLookUp]'
END
GO

EXEC [dbo].[SeedTable_SportAssociationLookUp];

DROP PROCEDURE IF EXISTS [dbo].[SeedTable_SportAssociationLookUp] 
GO