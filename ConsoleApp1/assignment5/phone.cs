using System.Collections.Generic;
using ConsoleApp1.assignment5.info;

namespace ConsoleApp1.assignment5
{
    public abstract class phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newphone);
        public abstract void searchPhone(string name);

    }
    
    public class Phonebook:phone
    {
        List<PBInfo> phonelist = new List<PBInfo>();
        
        public override void InsertPhone(string name, string phone)
        {
            foreach (PBInfo p in phonelist)
            {
                if (p.Name.Equals(name))
                {
                    if(p.Phonenumber.Equals(phone)){
                        return;
                    }
                    p.Phonenumber = p.Phonenumber+":"+phone;
                    return;
                }
            }
            phonelist.Add(new PBInfo(name,phone));
        }

        public override void removePhone(string name)
        {
            foreach (PBInfo pbInfo in phonelist)
            {
                if (pbInfo.Name.Equals(name))
                {
                    phonelist.Remove(pbInfo);
                    return;
                }
            }
        }

        public override void updatePhone(string name, string newphone)
        {
            foreach (PBInfo p in phonelist)
            {
                if (p.Name.Equals(name))
                {
                    p.Phonenumber = newphone;
                    return;
                }
            }
        }

        public override void searchPhone(string name)
        {
            foreach (PBInfo p in phonelist)
            {
                if (p.Name.Equals(name))
                {
                    return ;
                }
            }
        }
    }
}

namespace ConsoleApp1.assignment5.info
{
    public class PBInfo
    {
        protected string name;
        protected string phonenumber;

        public PBInfo()
        {
        }

        public PBInfo(string name, string phonenumber)
        {
            this.name = name;
            this.phonenumber = phonenumber;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Phonenumber
        {
            get => phonenumber;
            set => phonenumber = value;
        }
    }
}

