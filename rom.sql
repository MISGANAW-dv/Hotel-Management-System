-- 1. Bookings ቴብልን መጀመሪያ አጥፋ (ከ Rooms ጋር ስለሚያያዝ)
DROP TABLE IF EXISTS Bookings;
DROP TABLE IF EXISTS Rooms;

-- 2. Rooms ቴብል መፍጠር
CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomNumber NVARCHAR(50) UNIQUE NOT NULL,
    RoomType NVARCHAR(100), 
    PricePerNight DECIMAL(18, 2),
    Status NVARCHAR(50) DEFAULT 'Available' -- Available, Pending, Booked
);

-- 3. Bookings ቴብል መፍጠር
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50), 
    RoomID INT FOREIGN KEY REFERENCES Rooms(RoomID), 
    CheckInDate DATE DEFAULT GETDATE(),
    CheckOutDate DATE,
    TotalAmount DECIMAL(18, 2),
    PaymentStatus NVARCHAR(50) DEFAULT 'Pending'
);

-- 4. ጥቂት መረጃዎችን ጨምር
INSERT INTO Rooms (RoomNumber, RoomType, PricePerNight) VALUES ('101', 'Single', 1200), ('205', 'Double', 2500);