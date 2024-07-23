--1
-- Define a stored procedure to calculate factorial
CREATE or ALTER PROCEDURE CalculateFactorial( @n INT)
AS
BEGIN
    -- Check if the input number is non-negative
    IF @n < 0
    BEGIN
        PRINT 'Factorial is not defined for negative numbers.';
        RETURN;
    END

    -- Temporary table to store factorial calculations
    DECLARE @factorials TABLE (
        number INT,
        factorial BIGINT
    );

    -- Base case: factorial of 0 is 1
    INSERT INTO @factorials (number, factorial)
    VALUES (0, 1);

    -- Recursive CTE to calculate factorial
    WITH RecursiveFactorial AS (
        SELECT 1 AS number, CAST(1 AS BIGINT) AS factorial
        UNION ALL
        SELECT number + 1, CAST(factorial * (number + 1) AS BIGINT)
        FROM RecursiveFactorial
        WHERE number < @n
    )
    INSERT INTO @factorials (number, factorial)
    SELECT number, factorial
    FROM RecursiveFactorial
    OPTION (MAXRECURSION 0); -- Allow maximum recursion depth

    -- Select the factorial value for the given number
    SELECT factorial
    FROM @factorials
    WHERE number = @n;
END;


-- Example usage: Calculate factorial of a number (e.g., 5)
EXEC CalculateFactorial @n = 5;



--2

CREATE PROCEDURE GenerateMultiplicationTable
    @Multiplier INT,
    @UpTo INT
AS
BEGIN
    DECLARE @Counter INT = 1;
    
    PRINT 'Multiplication Table for ' + CAST(@Multiplier AS NVARCHAR(10)) + ' up to ' + CAST(@UpTo AS NVARCHAR(10));
    PRINT '----------------------------------------';

    WHILE @Counter <= @UpTo
    BEGIN
        DECLARE @Result INT = @Multiplier * @Counter;
        PRINT CAST(@Multiplier AS NVARCHAR(10)) + ' * ' + CAST(@Counter AS NVARCHAR(10)) + ' = ' + CAST(@Result AS NVARCHAR(10));
        SET @Counter = @Counter + 1;
    END
END
EXEC GenerateMultiplicationTable @Multiplier = 5, @UpTo = 10;


--3
create table holidays
(
holiday_date date,
holiday_name varchar(30)
)
Insert into holidays values
('2024-01-01','New years day'),
('2024-02-14','Valentines Day'),
('2024-03-10','Mothers Day'),
('2024-04-01','April fools day'),
('2024-05-01','May day'),
('2024-08-15','Independence day'),
('2024-10-24','Diwali holiday')
drop table if exists holidays
select * from holidays
-- Step 1: Define the trigger
CREATE TRIGGER TRG_RestrictDataManipulation
ON holidays
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    -- Step 2: Check if today is a holiday
    DECLARE @Today DATE = GETDATE();
    DECLARE @HolidayMessage NVARCHAR(200);

    -- Check if today is Independence Day (August 15th) or Diwali (October 27th)
    IF @Today = '2024-08-15'  -- Independence Day
    BEGIN
        SET @HolidayMessage = 'Due to Independence Day, you cannot manipulate data.';
        RAISERROR(@HolidayMessage, 16, 1);
        ROLLBACK;  -- Rollback the transaction
    END
    ELSE IF @Today = '2024-10-27'  -- Diwali
    BEGIN
        SET @HolidayMessage = 'Due to Diwali, you cannot manipulate data.';
        RAISERROR(@HolidayMessage, 16, 1);
        ROLLBACK;  -- Rollback the transaction
    END
END;



