using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CinemaPB.GlobalSQL
{
    public class SQLQuery
    {
        public static string connectionString = @"Data Source = LAPTOP-FC9GSM04\SQLEXPRESS;Initial Catalog = CinemaDB;Integrated Security = True;";
        //public static string connectionString = @"Data Source = PAGALING\SQLEXPRESS;Initial Catalog = CinemaDB;Integrated Security = True;";

        public static string InsertAccount = @"
            INSERT INTO emp.Employees (
                   FirstName
                  ,MiddleName
                  ,LastName
                  ,NameExtension
                  ,Gender
                  ,ContactNo
                  ,Address
                  ,Username
                  ,Password
                  ,RoleID
                  ,StatusID
                  ,EmploymentStatus) 
           VALUES (
                @FirstName,
                @MiddleName,
                @LastName,
                @NameExtension,
                @Gender,
                @ContactNo,
                @Address,
                @Username,
                @Password,
                @RoleID,
                @StatusID,
                @EmploymentStatus);";

        public static string FilterAllEmployees = @"
           SELECT 
         [EmployeeID],
         [FirstName],
         [MiddleName],
         [LastName],
         [NameExtension],
         FirstName + ' ' + 
             CASE 
                 WHEN MiddleName IS NULL OR LTRIM(RTRIM(MiddleName)) = '' 
                     THEN LastName 
                 ELSE LEFT(MiddleName, 1) + '. ' + LastName 
             END +
             CASE 
                 WHEN NameExtension IS NULL OR LTRIM(RTRIM(NameExtension)) = '' 
                     THEN '' 
                 ELSE ' ' + NameExtension 
             END AS EmployeeName,
         [Gender],
         [ContactNo],
         [Address],
         [Username],
         r.RoleName,
         CASE 
             WHEN EmploymentStatus = 1 THEN 'Active'
             ELSE 'In-Active'
         END AS EmploymentStatus,
		 CASE 
			 WHEN IsLocked = 1 THEN 'Locked'
			 ELSE 'Unlocked'
		END AS IsLocked
     FROM emp.Employees e
     LEFT JOIN emp.Roles r ON r.RoleID = e.RoleID
     ORDER BY EmployeeID;";

        public static string UpdateAccount = @"
            UPDATE emp.Employees
            SET 
                RoleID = @RoleID,
                FirstName = @FirstName,
                MiddleName = @MiddleName,
                LastName = @LastName,
                NameExtension = @NameExtension,
                ContactNo = @ContactNo,
                Address = @Address,
                Username = @Username,
                EmploymentStatus = @EmploymentStatus,
                StatusID = @StatusID,
                IsLocked = @IsLocked
            WHERE Username = @OriginalUsername";

        public static string Ticket = @"
                                    SELECT T.ShowtimeID,
                                           T.TicketID,
	                                       S.HallID,
	                                       SE.SeatNumber,
	                                       S.StartTime,
	                                       S.EndTime,
	                                       M.Title,
	                                       CR.RatingName,
	                                       MP.Price,
	                                       S.ShowDate,
	                                       PurchaseTime AS PurchasedDate

                                    FROM Tickets T
                                    LEFT JOIN dbo.Showtime S
                                    ON S.ShowtimeID = T.ShowtimeID
                                    LEFT JOIN mov.Movies M
                                    ON M.MovieID = S.MovieID
                                    LEFT JOIN mov.MoviePrices MP
                                    ON MP.MoviePriceID = T.MoviePriceID
                                    LEFT JOIN mov.ContentRating CR
                                    ON CR.RatingID = m.RatingID
                                    LEFT JOIN Seats SE
                                    ON SE.SeatID = T.SeatID
                                    WHERE T.ShowtimeID = @ShowtimeID AND T.SeatID = @SeatID;";

        public static string DailyReport = @"SELECT 
                                                M.MovieID,
                                                M.Title AS MovieTitle,
                                                COUNT(T.TicketID) AS TicketsSold,
                                                FORMAT(SUM(MP.Price), 'N2') AS TotalRevenue
                                            FROM Tickets T
                                            LEFT JOIN Showtime S ON S.ShowtimeID = T.ShowtimeID
                                            LEFT JOIN mov.Movies M ON M.MovieID = S.MovieID
                                            LEFT JOIN mov.MoviePrices MP ON MP.MoviePriceID = T.MoviePriceID
                                            WHERE CAST(S.ShowDate AS DATE) = CAST(GETDATE() AS DATE)
                                            GROUP BY M.MovieID, M.Title;
                                            ";

        public static string WeeklyReport = @"SELECT 
                                                M.MovieID,
                                                M.Title AS MovieTitle,
                                                COUNT(T.TicketID) AS TicketsSold,
                                                FORMAT(SUM(MP.Price), 'N2') AS TotalRevenue
                                            FROM Tickets T
                                            LEFT JOIN Showtime S ON S.ShowtimeID = T.ShowtimeID
                                            LEFT JOIN mov.Movies M ON M.MovieID = S.MovieID
                                            LEFT JOIN mov.MoviePrices MP ON MP.MoviePriceID = T.MoviePriceID
                                            WHERE 
                                                S.ShowDate >= DATEADD(DAY, 1 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE)) 
                                                AND S.ShowDate < DATEADD(DAY, 8 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE)) 
                                            GROUP BY M.MovieID, M.Title;";

        public static string MonthlyReport = @"SELECT 
                                                        M.MovieID,
                                                        M.Title AS MovieTitle,
                                                        COUNT(T.TicketID) AS TicketsSold,
                                                        FORMAT(SUM(MP.Price), 'N2') AS TotalRevenue
                                                    FROM Tickets T
                                                    LEFT JOIN Showtime S ON S.ShowtimeID = T.ShowtimeID
                                                    LEFT JOIN mov.Movies M ON M.MovieID = S.MovieID
                                                    LEFT JOIN mov.MoviePrices MP ON MP.MoviePriceID = T.MoviePriceID
                                                    WHERE 
                                                        MONTH(S.ShowDate) = MONTH(GETDATE()) AND
                                                        YEAR(S.ShowDate) = YEAR(GETDATE())
                                                    GROUP BY M.MovieID, M.Title;
                                                    ";
    }
}
