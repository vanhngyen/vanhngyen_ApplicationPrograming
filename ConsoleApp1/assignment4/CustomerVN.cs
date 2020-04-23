namespace ConsoleApp1.assignment4
{
    //Xây dựng chương trình quản lý danh sách hoá đơn tiền điện của khách hàng. Thông tin bao gồm các loại khách hàng :
    //+ Khách hàng Việt Nam: mã khách hàng, họ tên, ngày ra hoá đơn (ngày, tháng, năm), đối tượng khách hàng (sinh hoạt, kinh doanh, sản xuất): số lượng (số KW tiêu thụ), đơn giá, định mức. Thành tiền được tính như sau:
    //- Nếu số lượng <= định mức thì: thành tiền = số lượng * đơn giá.
    //- Ngược lại thì: thành tiền = đơn giá * định mức + số lượng KW vượt định mức * Đơn giá mới
    
    public class CustomerVN
    {
        private int id;
        private string name;
        private string date;
        private string customers;
        private int amount;
        private double unit_price;
        private double quota;

        public CustomerVN()
        {
        }

        public CustomerVN(int id, string name, string date, string customers, int amount, double unitPrice, double quota)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.customers = customers;
            this.amount = amount;
            unit_price = unitPrice;
            this.quota = quota;
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

        public string Customers
        {
            get => customers;
            set => customers = value;
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

        public double Quota
        {
            get => quota;
            set => quota = value;
        }

        public double Into_money(double money,double newprice)
        {
            if (amount <= quota)
            {
                return money = quota*unit_price;   
            }
            else
            {
                return money = (unit_price * quota) + (amount * newprice);
            }
        }
        
        
    }
}