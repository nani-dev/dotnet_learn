# .NET8


###  SQL code



    USE master  
    DROP DATABASE ExerciseDatabase 
    
    CREATE DATABASE
    
    GO
    
    USE ExerciseDatabase
    GO
    
    CREATE SCHEMA TutorialAppSchema
    GO
    
    CREATE TABLE TutorialAppSchema.Exercise (  
    ExercisePerson INT IDENTITY(1,1) PRIMARY KEY,  
    ExerciseName NVARCHAR(50),  
    Reps INT,  
    Advanced BIT,  
    Home BIT,  
    Rest DECIMAL(18,4)  
    );

    SELECT * FROM TutorialAppSchema.Exercise
