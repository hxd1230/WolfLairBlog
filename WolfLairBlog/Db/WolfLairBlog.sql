/*======用户表======*/
CREATE TABLE [User]
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	UserName VARCHAR(16) NOT NULL,
	UserPwd VARCHAR(32) NOT NULL,
	RegisterTime DATETIME DEFAULT(GETDATE()),
	Email VARCHAR(20) NOT NULL
)

CREATE TABLE [UserInfo]
(
	UserId INT NOT NULL foreign key(UserId) references [User](Id), 
	Sex	VARCHAR(2) NULL CHECK(Sex='男' or Sex='女'),
	Pic IMAGE NULL 
)
--ALTER TABLE HXD_User
--ALTER COLUMN Email VARCHAR(20) NOT NULL
/*======日志表======*/
CREATE TABLE [Log]
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	UserId INT NOT NULL foreign key(UserId) references [User](Id),
	LoginOrOutTime DATETIME DEFAULT(GETDATE()),
	TimeType VARCHAR(4)
)
/*======分类表======*/
CREATE TABLE Category
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryName VARCHAR(32) NOT NULL
)
/*======文章表======*/
CREATE TABLE Article
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title VARCHAR(MAX) NOT NULL,
	Content NTEXT NOT NULL,
	UserId INT NOT NULL foreign key(UserId) references [User](Id),
	PubTime DATETIME DEFAULT(GETDATE()),
	CategoryId INT NOT NULL foreign key(CategoryId) references Category(Id),
)
/*======评论表======*/
CREATE TABLE Comment
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Content TEXT NOT NULL,
	ArticeId INT NOT NULL foreign key(ArticeId) references Article(Id),
	UserId INT NOT NULL foreign key(UserId) references [User](Id),
)

CREATE TABLE NLog_Error
(
	[ID] INT IDENTITY(1,1) NOT NULL,
	[CreateDate] DATETIME NOT NULL,
	[Origin] NVARCHAR(100) NOT NULL,
	[LogLevel] NCHAR(5) NOT NULL,
	[Message] NVARCHAR(MAX) NOT NULL,
	[Exception] NVARCHAR(MAX) NOT NULL,
	[StackTrace] NVARCHAR(MAX) NOT NULL,
	PRIMARY KEY CLUSTERED ([ID] ASC)
)

/*======友情链接======*/
CREATE TABLE [FriendLink]
(
	[Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Title] VARCHAR(20) NOT NULL,
	Link VARCHAR(20) NOT NULL
)