namespace ConsoleApp1.practical.Exam2
{
    public class animal
    {
        public string name;
        public int weight;

        public animal()
        {
        }

        public animal(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }
        
        public class tiger : animal
        {
            public tiger()
            {
            }

            public tiger(string name, int weight) : base(name, weight)
            {
                
            }
        }
        
        public class lion : animal
        {
            public lion()
            {
            }

            public lion(string name, int weight) : base(name, weight)
            {
            }
        }
    }
}