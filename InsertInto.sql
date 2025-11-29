INSERT INTO dbo.Categories (Name, CreatedDate)
VALUES
(N'Adventure', SYSDATETIME()),
(N'Fantasy', SYSDATETIME()),
(N'Animation', SYSDATETIME()),
(N'Romance', SYSDATETIME()),
(N'Science Fiction', SYSDATETIME());

INSERT INTO dbo.Movies
    (Name, Duration, Clasification, Director, Studio, ReleaseDate, CreatedDate)
VALUES
(N'Inception', 150, N'PG13', N'Christopher Nolan', N'Warner Bros', '2010-07-16', SYSDATETIME()),
(N'The Godfather', 185, N'R', N'Francis Ford Coppola', N'Paramount', '1972-03-24', SYSDATETIME()),
(N'Toy Story', 61, N'G', N'John Lasseter', N'Pixar', '1995-11-22', SYSDATETIME()),
(N'The Dark Knight', 132, N'PG13', N'Christopher Nolan', N'Warner Bros', '2008-07-18', SYSDATETIME()),
(N'Interstellar', 179, N'PG13', N'Christopher Nolan', N'Paramount', '2014-11-07', SYSDATETIME()),
(N'The Matrix', 146, N'R', N'Lana Wachowski', N'Warner Bros', '1999-03-31', SYSDATETIME()),
(N'Avatar', 152, N'PG13', N'James Cameron', N'20th Century', '2009-12-18', SYSDATETIME()),
(N'Finding Nemo', 101, N'G', N'Andrew Stanton', N'Pixar', '2003-05-30', SYSDATETIME()),
(N'Gladiator', 165, N'R', N'Ridley Scott', N'DreamWorks', '2000-05-05', SYSDATETIME()),
(N'Joker', 132, N'R', N'Todd Phillips', N'Warner Bros', '2019-10-04', SYSDATETIME());