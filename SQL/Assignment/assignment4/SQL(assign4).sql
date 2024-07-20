--1
-- Define a stored procedure to calculate factorial
CREATE PROCEDURE CalculateFactorial
    @n INT
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
GO

-- Example usage: Calculate factorial of a number (e.g., 5)
EXEC CalculateFactorial @n = 5;



--2
DELIMITER //

CREATE PROCEDURE GenerateMultiplicationTable(
    IN multiplier INT,
    IN max_number INT
)
BEGIN
    DECLARE counter INT DEFAULT 1;
    
    -- Ensure input validity
    IF multiplier <= 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Multiplier should be greater than zero';
    END IF;
    
    IF max_number <= 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Max number should be greater than zero';
    END IF;

    -- Create a temporary table to store the results
    DROP TEMPORARY TABLE IF EXISTS multiplication_table;
    CREATE TEMPORARY TABLE multiplication_table (
        multiplicand INT,
        product INT
    );

    -- Loop to generate multiplication table
    WHILE counter <= max_number DO
        INSERT INTO multiplication_table (multiplicand, product)
        VALUES (counter, counter * multiplier);
        
        SET counter = counter + 1;
    END WHILE;

    -- Select the multiplication table from the temporary table
    SELECT * FROM multiplication_table;

    -- Drop the temporary table after use
    DROP TEMPORARY TABLE multiplication_table;
    
END //

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
DELIMITER //

CREATE TRIGGER RestrictOnHolidays
BEFORE INSERT ON EMP
FOR EACH ROW
BEGIN
    DECLARE holiday_exists INT;
    
    -- Check if the current date is a holiday
    SELECT COUNT(*) INTO holiday_exists
    FROM Holidays
    WHERE holiday_date = CURDATE();
    
    -- If it's a holiday, prevent the operation and display error message
    IF holiday_exists > 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = CONCAT('Due to ', (SELECT holiday_name FROM Holidays WHERE holiday_date = CURDATE()), ' you cannot manipulate data');
    END IF;
END //

DELIMITER ;

