CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY IDENTITY(1,1), -- በራሱ የሚሰጥ መለያ ቁጥር
    RoomNumber VARCHAR(50) NOT NULL,      -- የክፍሉ ቁጥር (ለምሳሌ 101)
    RoomType VARCHAR(50),                 -- የክፍሉ አይነት (Single, Double, Suite)
    Capacity INT,                         -- የሚይዘው ሰው ብዛት
    PricePerNight DECIMAL(18, 2),         -- የአንድ ሌሊት ዋጋ
    Floor INT,                            -- የሚገኝበት ፎቅ
    RoomDescription NVARCHAR(255),        -- ስለ ክፍሉ ማብራሪያ
    Status VARCHAR(20) DEFAULT 'Available', -- ክፍት መሆኑን ወይም መያዙን መቆጣጠሪያ
    HasWifi BIT DEFAULT 1,                -- ዋይፋይ ካለው 1 (True) ከሌለው 0 (False)
    HasTV BIT DEFAULT 1                   -- ቲቪ ካለው 1 ከሌለው 0
);