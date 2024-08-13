//This is for creating a new table in your new or existing database.

CREATE TABLE CalculationHistory (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Calculation TEXT,
    Timestamp DATETIME
);




//When 50 entry done that automatically DELETE the history.
DELETE FROM CalculationHistory
WHERE Id NOT IN (
    SELECT Id FROM (
        SELECT Id FROM CalculationHistory
        ORDER BY Timestamp DESC
        LIMIT 50
    ) AS SubQuery
);
