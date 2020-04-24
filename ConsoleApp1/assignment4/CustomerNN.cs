namespace ConsoleApp1.assignment4
{
    //+ Khách hàng nước ngoài: mã khách hàng, họ tên, ngày ra hoá đơn (ngày, tháng, năm), quốc tịch, số lượng, đơn giá. Thành tiền được tính = số lượng * đơn giá.
    public class CustomerNN:Customer
    {
        private string country;

        public CustomerNN(int id, string name, string billDate, int number, string country) : base(id, name, billDate, number)
        {
            this.country = country;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public override int ThanhTien()
        {
            return Number*2000;
        }
    }
}