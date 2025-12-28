using System;

namespace Smart_Library_Management_System.Members
{
    public class MemberModel
    {
        public int MemberID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime MembershipDate { get; set; }

        public MemberModel() { }

        public MemberModel(string name, string email)
        {
            FullName = name;
            Email = email;
            MembershipDate = DateTime.Now;
        }
        public MemberModel(int id , string name, string email)
        {
            MemberID = id;
            FullName = name;
            Email = email;
            MembershipDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{MemberID}] {FullName} ({Email}) - Joined: {MembershipDate.ToShortDateString()}";
        }
    }
}