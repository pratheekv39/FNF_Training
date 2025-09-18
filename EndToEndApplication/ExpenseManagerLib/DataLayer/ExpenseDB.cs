using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagerLib.DataLayer
{

    public interface IExpenseDB
    {
        void AddExpense(Expense expense);

        void UpdateExpense(Expense expense);

        void DeleteExpense(int expenseId);

        void GetExpense(int expenseId);

        IEnumerable<Expense> GetAllExpenses();
    }
    public class ExpenseDB : IExpenseDB
    {
        readonly string STRCONNECTION = ConfigurationManager.ConnectionStrings["ConnectionConfig"].ConnectionString;
        const string STRSELECTALL = "Select * from Expense";
        const string STRINSERT = "INSERT INTO Expense (ExpDesc,Amount, ExpDate) VALUES (@expDesc, @amount, @expDate)";
        const string STRUPDATE = "UPDATE Expense SET ExpDesc = @expDesc, Amount = @amount, ExpDate = @expDate WHERE ExpenseId = @expId";
        const string STRDELETE = "DELETE FROM Expense WHERE ExpenseId = @empId";
        public void AddExpense(Expense expense)
        {
            var con=new SqlConnection(STRCONNECTION);
            var cmd= new SqlCommand(STRINSERT, con);
            cmd.Parameters.AddWithValue("@expDesc", expense.ExpDesc);
            cmd.Parameters.AddWithValue("@amount", expense.Amount);
            cmd.Parameters.AddWithValue("@expDate", expense.ExpDate);
            try
            {
                con.Open();
                _= cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteExpense(int expenseId)
        {
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(STRDELETE, con);
            cmd.Parameters.AddWithValue("@expId", expenseId);
            try{
                con.Open();
                _ = cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            var list = new List<Expense>();
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(STRSELECTALL, con);
            try
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var expense = new Expense
                        {
                            ExpId = reader.GetInt32(0),
                            ExpDesc = reader.GetString(1),
                            Amount = reader.GetDecimal(2),
                            ExpDate = reader.GetDateTime(3)
                        };
                        list.Add(expense);
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public void GetExpense(int expenseId)
        {
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand("SELECT * FROM Expense WHERE ExpenseId = @expId", con);
            cmd.Parameters.AddWithValue("@expId", expenseId);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Use correct column names as per your table schema
                    int expId = reader.GetInt32(reader.GetOrdinal("ExpenseId"));
                    string expDesc = reader.GetString(reader.GetOrdinal("ExpDesc"));
                    decimal amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
                    DateTime expDate = reader.GetDateTime(reader.GetOrdinal("ExpDate"));

                    Console.WriteLine($"Expense Id: {expId}\nExpense Description: {expDesc}\nAmount: {amount}\nExpense Date: {expDate:yyyy-MM-dd}\n");
                }
                else
                {
                    Console.WriteLine("Expense not found.");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateExpense(Expense expense)
        {
            var con= new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(STRUPDATE, con);
            cmd.Parameters.AddWithValue("@expDesc", expense.ExpDesc);
            cmd.Parameters.AddWithValue("@amount", expense.Amount);
            cmd.Parameters.AddWithValue("@expDate", expense.ExpDate);
            cmd.Parameters.AddWithValue("@expId", expense.ExpId);
            try
            {
                con.Open();
                _ = cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
