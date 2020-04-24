namespace ConsoleApp1.assignment4
{
    //Xây dựng chương trình quản lý danh sách hoá đơn tiền điện của khách hàng. Thông tin bao gồm các loại khách hàng :
    //+ Khách hàng Việt Nam: mã khách hàng, họ tên, ngày ra hoá đơn (ngày, tháng, năm), đối tượng khách hàng (sinh hoạt, kinh doanh, sản xuất): số lượng (số KW tiêu thụ), đơn giá, định mức. Thành tiền được tính như sau:
    //- Nếu số lượng <= định mức thì: thành tiền = số lượng * đơn giá.
    //- Ngược lại thì: thành tiền = đơn giá * định mức + số lượng KW vượt định mức * Đơn giá mới
    
    public class CustomerVN:Customer
    {
        private string doituong;

        public CustomerVN(int id, string name, string billDate, int number, string doituong) : base(id, name, billDate, number)
        {
            this.doituong = doituong;
        }

        public string Doituong
        {
            get => doituong;
            set => doituong = value;
        }
    }
}