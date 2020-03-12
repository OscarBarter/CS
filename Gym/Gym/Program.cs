using System;

namespace Gym
{
    public class Member
    {
        private string name;
        private int memberID;
        private int memberSince;
        protected double annualFee;

        // Constructor
        public Member(string pName, int pMemberID, int pMemberSince)
        {
            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
            Console.WriteLine("Member created");
        }

        // overriding ToString method
        public override string ToString()
        {
            return $"Member {name} \nMember ID: {memberID}\nMember Since: {memberSince}";
        }
    }

    public class NormalMember : Member
    {
        private int discount;

        // Constructor
        public NormalMember(string pname, int pmemberID, int pmemberSince, int pdiscount) : base(pname, pmemberID, pmemberSince)
        {
            discount = pdiscount;
            Console.WriteLine("Normal");
        }

        public double CalculateAnnualFee()
        {
            annualFee = 12 * 30.0 * ((100 - discount) / 100.0);
            return annualFee;
        }

    }

    public class VIPMember : Member
    {
        // Constructor
        public VIPMember(string pname, int pmemberID, int pmemberSince)
                    : base(pname, pmemberID, pmemberSince)
        {
            Console.WriteLine("VIP");
        }

        public double CalculateAnnualFee()
        {
            annualFee = 1200;
            return annualFee;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Member mem1 = new Member("JOE", 1, 2018);
            NormalMember mem2 = new NormalMember("DAVE", 2, 2019, 10);
            VIPMember mem3 = new VIPMember("JACK", 3, 2019);
            Console.WriteLine(mem1.ToString());
            Console.WriteLine();
            Console.WriteLine(mem2.ToString());
            Console.WriteLine(mem2.CalculateAnnualFee());
            Console.WriteLine(mem3.ToString());
            Console.WriteLine(mem3.CalculateAnnualFee());

        }
    }
}
