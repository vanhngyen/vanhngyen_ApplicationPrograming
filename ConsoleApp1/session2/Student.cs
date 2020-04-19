namespace ConsoleApp1
{
    public class Student
    {
        public string name;
        public int age;

        public void ShowInfo()
        {
            //kê khai thông tin
        }

        internal void ShowName()
        {
            
        }
        //public private protected internal
        //protected muốn kế thừa cho con
        //.dll dynamic linked library
        //internal chính là public của java cũ - phạm vi solution của mình
        // public là phạm vi all solution

        public bool YesOrNo(int varname)
        {
            return true;
        }
    }
}