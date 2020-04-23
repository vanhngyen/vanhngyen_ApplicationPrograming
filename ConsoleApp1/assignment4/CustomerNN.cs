namespace ConsoleApp1.assignment4
{
    //+ Khách hàng nước ngoài: mã khách hàng, họ tên, ngày ra hoá đơn (ngày, tháng, năm), quốc tịch, số lượng, đơn giá. Thành tiền được tính = số lượng * đơn giá.
    public class CustomerNN
    {
        private int id;
        private string name;
        private string date;
        private string nationality;
        private int amount;
        private double unit_price;

        public CustomerNN()
        {
        }

        public CustomerNN(int id, string name, string date, string nationality, int amount, double unitPrice)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.nationality = nationality;
            this.amount = amount;
            unit_price = unitPrice;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Date
        {
            get => date;
            set => date = value;
        }

        public string Nationality
        {
            get => nationality;
            set => nationality = value;
        }

        public int Amount
        {
            get => amount;
            set => amount = value;
        }

        public double UnitPrice
        {
            get => unit_price;
            set => unit_price = value;
        }

        public void Into_money()
        {
            double money = amount * unit_price;
        }
    }
}