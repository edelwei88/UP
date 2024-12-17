CREATE TABLE Requests(
requestID INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
startDate DATE NOT NULL,
problemDescription NVARCHAR(MAX) NOT NULL,
completionDate DATE NULL,
requestStatusID INT NOT NULL REFERENCES RequestStatuses(requestStatusID),
techModelID INT NOT NULL REFERENCES TechModels(techModelID),
masterID INT NULL REFERENCES Users(userID),
clientID INT NOT NULL REFERENCES Users(userID)
)
