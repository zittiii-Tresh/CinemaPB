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
        //public static string connectionString = @"Data Source = LAPTOP-FC9GSM04\SQLEXPRESS;Initial Catalog = CinemaDB;Integrated Security = True;";
        public static string connectionString = @"Data Source = PAGALING\SQLEXPRESS;Initial Catalog = CinemaDB;Integrated Security = True;";

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
    }
}
