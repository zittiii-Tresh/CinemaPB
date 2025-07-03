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

        public static string InsertAccount = @"
            INSERT INTO dbo.Employees (
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
    }
}
