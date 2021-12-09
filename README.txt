Database:
CREATE DATABASE [OopProject]
CREATE TABLE [dbo].[Students](
	[FullName] [varchar](30) NOT NULL,
	[Age] [int] NULL,
	[AverageGrade] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[FullName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

Connect to db in VS:
https://www.youtube.com/watch?v=SnU4Ulee_NI&t=388s&ab_channel=Computerix
