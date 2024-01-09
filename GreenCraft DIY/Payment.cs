using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace GreenCraft_DIY
{
    public class Payment
    {
        string _connStr = ConfigurationManager.ConnectionStrings["GreenCraft"].ConnectionString;
        private string _PaymentId = null;
        private string _Amount = "";
        private string _CardNumber = "";
        private string _CardType = null;
        private string _ExpiryDate = "";
        private string _CardHolderName = string.Empty;
        private string _PaymentDate = "";
        private string _Status = "";
        private string _CVV = "";

        public Payment()
        {
        }
        public Payment(string paymentID, string amount, string cardNumber, string cardType, string expiryDate, string cardHolderName,string paymentDate, string status, string cvv)
        {
            _PaymentId = paymentID;
            _Amount = amount;
            _CardNumber = cardNumber;
            _CardType = cardType;
            _ExpiryDate = expiryDate;
            _CardHolderName = cardHolderName;
            _PaymentDate = paymentDate;
            _Status = status;
            _CVV = cvv;
        }
        public Payment(string amount, string cardNumber, string cardType, string expiryDate, string cardHolderName,string paymentDate, string status, string cvv)
               : this(null, amount, cardNumber, cardType, expiryDate, cardHolderName, paymentDate, status, cvv)
        {
        }
        public Payment(string paymentID)
            : this(paymentID, "", "", "", "", "", "", "", "")
        {
        }
        public string Payment_Id
        {
            get { return _PaymentId; }
            set { _PaymentId = value; }
        }
        public string Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        public string CardNumber
        {
            get { return _CardNumber; }
            set { _CardNumber = value; }
        }
        public string CardType
        {
            get { return _CardType; }
            set { _CardType = value; }
        }
        public string ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }
        public string CardHolderName
        {
            get { return _CardHolderName; }
            set { _CardHolderName = value; }
        }
        public string PaymentDate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string CVV
        {
            get { return _CVV; }
            set { _CVV = value; }
        }

        public int PaymentInsert()
        {
            int result = 0;
            string queryStr = "INSERT INTO Payments(Amount,CardNumber,CardType,ExpiryDate,CardHolderName,PaymentDate,Status,CVV)"
                + "values(@Amount,@CardNumber,@CardType,@ExpiryDate,@CardHolderName,@PaymentDate,@Status,@CVV)";

            try
            {
                SqlConnection conn = new SqlConnection(_connStr);
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.Parameters.AddWithValue("@Amount","20.50" );
                cmd.Parameters.AddWithValue("@CardNumber", this.CardNumber);
                cmd.Parameters.AddWithValue("@CardType", this.CardType);          
                cmd.Parameters.AddWithValue("@ExpiryDate", this.ExpiryDate);
                cmd.Parameters.AddWithValue("@CardHolderName", this.CardHolderName);
                cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@Status", "Completed");
                cmd.Parameters.AddWithValue("@CVV", this.CVV); 

                conn.Open();
                result += cmd.ExecuteNonQuery();
                conn.Close();

                return result;
            } catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int PaymentUpdate(string pId,string card_number, string card_type, string expiry_date, string pName, string Pcvv)
        {
            //string queryStr = "UPDATE Payments SET" + "CardType = @CardType," + "CardHolderName = @CardHolderName," + "CardNumber = @CardNumber" + "ExpiryDate = @ExpiryDate" + "CVV = @CVV" + " WHERE Payment_Id = @PaymentId";
            string queryStr = "UPDATE Payments SET CardNumber=@CardNumber, CardType=@CardType, ExpiryDate=@ExpiryDate, CardHolderName=@CardHolderName, CVV=@CVV WHERE Payment_Id=@PaymentId";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@PaymentId", pId);
            cmd.Parameters.AddWithValue("@CardHolderName", pName);
            cmd.Parameters.AddWithValue("@CardType", card_type);
            cmd.Parameters.AddWithValue("@CardNumber", card_number);
            cmd.Parameters.AddWithValue("@ExpiryDate", expiry_date);
            cmd.Parameters.AddWithValue("@CVV", Pcvv);

            conn.Open();
            int nofRow = 0;
            nofRow = cmd.ExecuteNonQuery();
            conn.Close();
            return nofRow;
        }
        public Payment getPayment(string paymentID)
        {
            Payment paymentDetail = null;
            string card_number, card_type, card_holder_name, status,cvv,amount;
            
            string expiry_date, payment_date;
            string queryStr = "SELECT * FROM Payments WHERE Payment_Id = @PaymentId";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@PaymentId", paymentID);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                amount = dr["Amount"].ToString();
                card_number = dr["CardNumber"].ToString();
                card_type = dr["CardType"].ToString();
                expiry_date = dr["ExpiryDate"].ToString();
                card_holder_name = dr["CardHolderName"].ToString();
                payment_date = dr["PaymentDate"].ToString();
                status = dr["Status"].ToString();
                cvv = dr["CVV"].ToString();

                paymentDetail = new Payment(paymentID, amount, card_number, card_type, expiry_date, card_holder_name, payment_date, status, cvv);
            }
            else
            {
                paymentDetail = null;
            }
            conn.Close();
            dr.Close();
            dr.Dispose();

            return paymentDetail;
        }

        public List<Payment> GetPaymentAll()
        {
            List<Payment> paymentList = new List<Payment>();
            string paymentID, card_number, card_type, card_holder_name, status, amount,cvv;
            string expiry_date, payment_date;

            string queryStr = "SELECT * FROM Payments";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                paymentID = dr["Payment_Id"].ToString();
                amount = dr["Amount"].ToString();
                card_number = dr["CardNumber"].ToString();
                card_type = dr["CardType"].ToString();
                expiry_date = dr["ExpiryDate"].ToString();
                card_holder_name = dr["CardHolderName"].ToString();
                payment_date = dr["PaymentDate"].ToString();
                status = dr["Status"].ToString();
                cvv = dr["CVV"].ToString();
                Payment p = new Payment(paymentID, amount, card_number, card_type, expiry_date, card_holder_name, payment_date, status, cvv);
                paymentList.Add(p);
            }
            conn.Close();
            dr.Close();
            dr.Dispose();

            return paymentList;
        }
    }
}