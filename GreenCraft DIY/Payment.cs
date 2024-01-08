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
        private decimal _Amount = 0;
        private string _CardNumber = "";
        private string _CardType = null;
        private DateTime _ExpiryDate = DateTime.MinValue;
        private string _CardHolderName = string.Empty;
        private DateTime _PaymentDate = DateTime.MinValue;
        private string _Status = "";
        private Int16 _CVV = 0;

        public Payment()
        {
        }
        public Payment(string paymentID, decimal amount, string cardNumber, string cardType, DateTime expiryDate, string cardHolderName, DateTime paymentDate, string status, Int16 cvv)
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
        public Payment(decimal amount, string cardNumber, string cardType, DateTime expiryDate, string cardHolderName, DateTime paymentDate, string status, Int16 cvv)
               : this(null, amount, cardNumber, cardType, expiryDate, cardHolderName, paymentDate, status, cvv)
        {
        }
        public Payment(string paymentID)
            : this(paymentID, 0, "", "", DateTime.Now, "", DateTime.Now, "", 0)
        {  
        }
        public string Payment_Id
        {
            get { return _PaymentId; }
            set { _PaymentId = value; }
        }
        public decimal Amount
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
            set {_CardType = value; }
        }
        public DateTime ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }
        public string CardHolderName
        {
            get { return _CardHolderName; }
            set { _CardHolderName = value; }
        }
        public DateTime PaymentDate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public Int16 CVV        {
            get { return _CVV; }
            set { _CVV = value; }
        }

        public int PaymentInsert()
        {
            int result = 0;
            string queryStr = "INSERT INTO Payments(CardType,CardHolderName,CardNumber,ExpiryDate,CVV)"
                + "values(@CardType,@CardHolderName,@CardNumber,@ExpiryDate,@CVV)";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@CardType", this.CardType);
            cmd.Parameters.AddWithValue("@CardHolderName", this.CardHolderName);
            cmd.Parameters.AddWithValue("@CardNumber", this.CardNumber);
            cmd.Parameters.AddWithValue("@ExpiryDate", this.ExpiryDate);
            cmd.Parameters.AddWithValue("@CVV", this.CVV);

            conn.Open();
            result += cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }
        public Payment getPayment(string paymentID)
        {
            Payment paymentDetail = null;
            string card_number, card_type, card_holder_name, status;
            decimal amount;
            Int16 cvv;
            DateTime expiry_date, payment_date;
            string queryStr = "SELECT * FROM Payments WHERE Payment_Id = @PaymentId";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@PaymentId", paymentID);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                amount = decimal.Parse(dr["Amount"].ToString());
                card_number = dr["CardNumber"].ToString();
                card_type = dr["CardType"].ToString();
                expiry_date = DateTime.Parse(dr["ExpiryDate"].ToString());
                card_holder_name = dr["CardHolderName"].ToString();
                payment_date = DateTime.Parse(dr["PaymentDate"].ToString());
                status = dr["Status"].ToString();
                cvv = Int16.Parse(dr["CVV"].ToString());

                paymentDetail = new Payment(paymentID,amount, card_number, card_type, expiry_date, card_holder_name, payment_date, status,cvv);
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
            string paymentID, card_number, card_type, card_holder_name, status;
            decimal amount;
            Int16 cvv;
            DateTime expiry_date, payment_date;

            string queryStr = "SELECT * FROM Payments";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                paymentID = dr["Payment_Id"].ToString();
                amount = decimal.Parse(dr["Amount"].ToString());
                card_number = dr["CardNumber"].ToString();
                card_type = dr["CardType"].ToString();
                expiry_date = DateTime.Parse(dr["ExpiryDate"].ToString());
                card_holder_name = dr["CardHolderName"].ToString();
                payment_date = DateTime.Parse(dr["PaymentDate"].ToString());
                status = dr["Status"].ToString();
                cvv = Int16.Parse(dr["CVV"].ToString());
                Payment p = new Payment(paymentID, amount, card_number, card_type, expiry_date, card_holder_name, payment_date, status,cvv);
                paymentList.Add(p);
            }
            conn.Close();
            dr.Close();
            dr.Dispose();

            return paymentList;
        }
    }
}