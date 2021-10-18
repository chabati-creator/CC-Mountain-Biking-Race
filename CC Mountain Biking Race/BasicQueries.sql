
-- Select all from RiderDetails table
SELECT * FROM RiderDetails

-- Select all from RiderTimes table
SELECT * FROM RiderTimes

-- Find the start time of the rider with an Id = n
SELECT a.StartTime FROM RiderTimes a
INNER JOIN DetailsTimes b ON a.Id = b.TimesId
WHERE b.RiderId = 5;
SELECT a.EndTime FROM RiderTimes a
INNER JOIN DetailsTimes b ON a.Id = b.TimesId
WHERE b.RiderId = 5;

-- Updating a rider's name
UPDATE RiderDetails
SET Name = 'CC'
WHERE Id = 5;

-- Inserting data into RiderDetails table
INSERT INTO RiderDetails
VALUES ('C', 'BB', 15, 'HBC',0,1,-1,3);

-- Inserting data into RiderTimes table
INSERT INTO RiderTimes
VALUES (39600,52000);

-- Deleting data from RiderDetails table
DELETE FROM RiderDetails
WHERE Id = 6;