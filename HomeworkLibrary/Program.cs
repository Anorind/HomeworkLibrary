using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
            conn.Open();

            //Додавання даних до таблиці Author
            //string insertComAuthor = "INSERT INTO[dbo].[Author] ([FirstName], [LastName]) VALUES('Andriy', 'Sapkovskiy');\r\n" +
            //    "INSERT INTO[dbo].[Author] ([FirstName], [LastName]) VALUES('Ivan', 'Franko');\r\n" +
            //    "INSERT INTO[dbo].[Author] ([FirstName], [LastName]) VALUES('Boris', 'Rijiy');\r\n" +
            //    "INSERT INTO[dbo].[Author] ([FirstName], [LastName]) VALUES('Lesya', 'Ukrainka');\r\n" +
            //    "INSERT INTO[dbo].[Author] ([FirstName], [LastName]) VALUES('Mukola', 'Gogol');";
            //SqlCommand cmd1 = new SqlCommand(insertComAuthor, conn);
            //cmd1.ExecuteNonQuery();


            //Додавання даних до таблиці Visitor
            //        string insertComVisitor = "INSERT INTO[dbo].[Visitor] ([FirstName], [LastName]) VALUES('Vasyl', 'Petrenko');\r\n " +
            //"INSERT INTO[dbo].[Visitor] ([FirstName], [LastName]) VALUES('Olexandr', 'Ivanov');\r\n" +
            //"INSERT INTO[dbo].[Visitor] ([FirstName], [LastName]) VALUES('Maria', 'Sidorenko');\r\n" +
            //"INSERT INTO[dbo].[Visitor] ([FirstName], [LastName]) VALUES('Julia', 'Kovalenko');\r\n  " +
            //"INSERT INTO[dbo].[Visitor] ([FirstName], [LastName]) VALUES('Hanna', 'Melnyk');";
            //        SqlCommand cmd2 = new SqlCommand(insertComVisitor, conn);
            //        cmd2.ExecuteNonQuery();

            //Додавання даних до таблиці Book
            //string insertComBook = "INSERT INTO[dbo].[Book] ([Title], [Pages], [AuthorId], [VisitorId], [Price]) VALUES('Witcher', 300, 1, 1, 199.99);\r\n" +
            //    "INSERT INTO[dbo].[Book] ([Title], [Pages], [AuthorId], [VisitorId], [Price]) VALUES('Zahar Berkut', 250, 2, 2, 149.99);\r\n" +
            //    "INSERT INTO[dbo].[Book] ([Title], [Pages], [AuthorId], [VisitorId], [Price]) VALUES('Kobzar', 200, 3, 3, 99.99);\r\n" +
            //    "INSERT INTO[dbo].[Book] ([Title], [Pages], [AuthorId], [VisitorId], [Price]) VALUES('Forest Song', 150, 4, 4, 129.99);\r\n" +
            //    "INSERT INTO[dbo].[Book] ([Title], [Pages], [AuthorId], [VisitorId], [Price]) VALUES('Dead Souls', 350, 5, 5, 249.99);";
            //SqlCommand cmd3 = new SqlCommand(insertComBook, conn);
            //cmd3.ExecuteNonQuery();

            //Додавання даних до таблиці BookAuthor
            //string insertComBookAuthor = "INSERT INTO[dbo].[BookAuthor] ([AuthorId], [BookId]) VALUES(1, 1);\r\n" +
            //    "INSERT INTO[dbo].[BookAuthor] ([AuthorId], [BookId]) VALUES(2, 2);\r\n" +
            //    "INSERT INTO[dbo].[BookAuthor] ([AuthorId], [BookId]) VALUES(3, 3);\r\n" +
            //    "INSERT INTO[dbo].[BookAuthor] ([AuthorId], [BookId]) VALUES(4, 4);\r\n" +
            //    "INSERT INTO[dbo].[BookAuthor] ([AuthorId], [BookId]) VALUES(5, 5);";
            //SqlCommand cmd4 = new SqlCommand(insertComBookAuthor, conn);
            //cmd4.ExecuteNonQuery();

            //Додавання даних до таблиці VisitorBook
            //string insertComVisitorBook = "INSERT INTO dbo.VisitorBook(VisitorId, BookId, TookDate) VALUES(1, 1, '2023-10-01');\r\n" +
            //    "INSERT INTO dbo.VisitorBook(VisitorId, BookId, TookDate) VALUES(2, 2, '2023-10-02');\r\n" +
            //    "INSERT INTO dbo.VisitorBook(VisitorId, BookId, TookDate) VALUES(3, 3, '2023-10-03');\r\n" +
            //    "INSERT INTO dbo.VisitorBook(VisitorId, BookId, TookDate) VALUES(4, 4, '2023-10-04');\r\n" +
            //    "INSERT INTO dbo.VisitorBook(VisitorId, BookId, TookDate) VALUES(5, 5, '2023-10-05');";
            //SqlCommand cmd5 = new SqlCommand(insertComVisitorBook, conn);
            //cmd5.ExecuteNonQuery();

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Используя параметризируемые запросы, выведите:
            //-всех пользователей, которые взяли книгу «Witcher» 
            //string bookTitle = "Witcher";
            //string queryString = "SELECT v.FirstName, v.LastName FROM [dbo].[Visitor] AS v " +
            //                     "JOIN [dbo].[VisitorBook] vb ON v.Id = vb.VisitorId " +
            //                     "JOIN [dbo].[Book] b ON vb.BookId = b.Id " +
            //                     "WHERE b.Title = @bookTitle";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //command.Parameters.AddWithValue("@bookTitle", bookTitle);

            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Список відвідувачів які взяли книгу 'Witcher':");
            //int i = 1;
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{i++}. {reader[0]} {reader[1]}");
            //}


            ////////////////////////////////////////////////////////////////////////////////////////
            //-авторов книги «Witcher», 
            //string bookTitle = "Witcher";
            //string queryString = "SELECT a.FirstName, a.LastName  FROM [dbo].[Author] AS a " +
            //                     "JOIN [dbo].[BookAuthor] AS ba ON a.Id = ba.AuthorId " +
            //                     "JOIN [dbo].[Book] AS b ON ba.BookId = b.Id " +
            //                     "WHERE b.Title = @bookTitle";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //command.Parameters.AddWithValue("@bookTitle", bookTitle);

            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Автор книги 'Witcher':");
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader[0]} {reader[1]}");
            //}

            ////////////////////////////////////////////////////////////////////////////////////////////
            // список книг, которые были взяты после указанной даты,
            //string date = "2023-01-01"; 
            //string queryString = "SELECT b.Title FROM [dbo].[Book] AS b " +
            //                     "JOIN [dbo].[VisitorBook] AS vb ON b.Id = vb.BookId " +
            //                     "WHERE vb.TookDate > @date";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //command.Parameters.AddWithValue("@date", date);

            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Книги, взяті після " + date + ":");
            //int i = 1;
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{i++}. {reader[0].ToString()}");
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////
            //вывести цены тех книг, которые на руках у определенного в параметре пользователя.
            //string visitorName = "Hanna Melnyk";
            //string queryString = "SELECT b.Title, b.Price FROM [dbo].[Book] AS b " +
            //                     "JOIN [dbo].[VisitorBook] AS vb ON b.Id = vb.BookId " +
            //                     "JOIN [dbo].[Visitor] AS v ON vb.VisitorId = v.Id " +
            //                     "WHERE v.FirstName+' '+v.LastName = @visitorName";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //command.Parameters.AddWithValue("@visitorName", visitorName);

            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Ціни книг, які на руках у користувача " + visitorName + ":");
            //while (reader.Read())
            //{
            //    Console.WriteLine("Назва книги: {0}, Ціна: {1}", reader[0].ToString(), reader[1].ToString());
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////
            //- вывести все книги, цена которых больше указанной, вышедшие не позднее указанной во втором параметре даты
            //int price = 150;
            //string queryString = "SELECT b.Title FROM [dbo].[Book] AS b " +
            //                     "WHERE b.Price > @price AND b.RealeseDate <= GetDate()";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //command.Parameters.AddWithValue("@price", price);

            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Книги, ціна яких вища за " + price + " і які були випущені не пізніше наявної дати:");
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0].ToString());
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //Используя хранимые процедуры:
            //-узнать количество книг в библиотеке,

            //CREATE PROCEDURE GetBookCount
            //AS
            //BEGIN
            // SELECT COUNT(*) AS BookCount FROM[dbo].[Book];
            //END;

            //SqlCommand sql = new SqlCommand("GetBookCount", conn);
            //sql.CommandType = System.Data.CommandType.StoredProcedure;
            //int bookCount = (int)sql.ExecuteScalar();
            //Console.WriteLine("Кількість книг у бібліотеці: " + bookCount);


            ///////////////////////////////////////////////////////////////////////////////////////////////////
            //- вычислить сумму цен всех книг и сумму страниц всех книг, написанных определённым автором.
            //CREATE PROCEDURE GetAuthorBookStats
            //@authorName NVARCHAR(50)
            //AS
            //BEGIN
            //SELECT SUM(b.Price) AS TotalPrice, SUM(b.Pages) AS TotalPages
            //FROM[dbo].[Book] AS b
            //JOIN[dbo].[BookAuthor] AS ba ON b.Id = ba.BookId
            //JOIN[dbo].[Author] AS a ON ba.AuthorId = a.Id
            //WHERE a.FirstName + ' ' + a.LastName = @authorName;
            //END;

            //string authorName = "Andriy Sapkovskiy";
            //SqlCommand command = new SqlCommand("GetAuthorBookStats", conn);
            //command.CommandType = System.Data.CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@authorName", authorName);

            //SqlDataReader reader = command.ExecuteReader();
            //if (reader.Read())
            //{
            //    decimal totalPrice = reader.GetDecimal(0);
            //    int totalPages = reader.GetInt32(1);
            //    Console.WriteLine("Сума цін та сума сторінок всіх книг, написаних автором " + authorName + ":");
            //    Console.WriteLine("Сума цін: " + totalPrice);
            //    Console.WriteLine("Сума сторінок: " + totalPages);
            //}





            //                                             Завдання 2
            // 1) Выведите список должников.
            //string queryString = "SELECT v.FirstName, v.LastName FROM [dbo].[Visitor] AS v " +
            //          "JOIN [dbo].[VisitorBook] AS vb ON v.Id = vb.VisitorId " +
            //          "WHERE vb.GaveDate IS NULL";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Список боржників:");
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader[0]} {reader[1]}");
            //}

            //Выведите список авторов книги №3(по порядку из таблицы ‘Book’).
            //string queryString = "SELECT a.FirstName, a.LastName FROM [dbo].[Author] AS a " +
            //                     "JOIN [dbo].[BookAuthor] AS ba ON a.Id = ba.AuthorId " +
            //                     "WHERE ba.BookId = 3";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Автор книги #3:");
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader[0]} {reader[1]}");
            //}

            //Выведите список книг, которые доступны в данный момент. 
            //string queryString = "SELECT b.Title FROM [dbo].[Book] AS b " +
            //                     "LEFT JOIN [dbo].[VisitorBook] AS vb ON b.Id = vb.BookId " +
            //                     "WHERE vb.BookId IS NULL OR vb.GaveDate IS NOT NULL";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Список книг які доступні в даний момент (але я такі не додавав))) ):");
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader[0]}");
            //}


            //Вывести список книг, которые на руках у пользователя №2. 
            //string queryString = " SELECT b.Title \r\nFROM [dbo].[Book] AS b\r\n" +
            //    "JOIN [dbo].[VisitorBook] AS vb ON b.Id = vb.BookId\r\n" +
            //    "WHERE vb.VisitorId = 2 AND vb.GaveDate IS NULL;";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Список книг які на руках у користувача №2:");
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader[0]}");
            //}

            //Вывести список книг, которые были взяты за последние 2 недели.
            //string queryString = "SELECT b.Title \r\n" +
            //    "FROM [dbo].[Book] AS b\r\n" +
            //    "JOIN [dbo].[VisitorBook] AS vb ON b.Id = vb.BookId\r\n" +
            //    "WHERE vb.TookDate >= DATEADD(WEEK, -2, GETDATE());";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Список книг які були взяті за останні 2 тижня:");
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader[0]}");
            //}

            //Обнулите задолженности всех должников.
            //string queryString = "UPDATE [dbo].[VisitorBook]\r\n" +
            //    "SET GaveDate = GETDATE()\r\n" +
            //    "WHERE GaveDate IS NULL;";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //command.ExecuteReader();

            //Вывести количество книг, взятых определённым посетителем за последний год.
            //string queryString = "SELECT COUNT(*) \r\n" +
            //    "FROM [dbo].[VisitorBook]\r\n" +
            //    "WHERE VisitorId = 2 AND TookDate >= DATEADD(YEAR, -1, GETDATE());";
            //SqlCommand command = new SqlCommand(queryString, conn);
            //SqlDataReader reader = command.ExecuteReader();
            //Console.WriteLine("Кількість книг взятих вівідувачем №2 в списку за останній рік:");
            //while (reader.Read())
            //{
            //    Console.WriteLine($"{reader[0]}");
            //}

            conn.Close();
            Console.ReadLine();
        }
    }
}
