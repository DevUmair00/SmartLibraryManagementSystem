using System.Data;

namespace Smart_Library_Management_System.Members
{
    public class MemberService
    {
        private readonly MemberRepo _memberRepo = new MemberRepo();

        public string RegisterMember(MemberModel member)
        {
            if (string.IsNullOrWhiteSpace(member.FullName)) return "Name is required.";
            if (string.IsNullOrWhiteSpace(member.Email) || !member.Email.Contains("@"))
                return "A valid Email address is required.";

            return _memberRepo.AddMember(member) ? "Success" : "Error saving member.";
        }

        public DataTable GetMemberList()
        { 
            return _memberRepo.GetAllMembers();
        }

        public string UpdateMember(MemberModel member)
        {
            if (member.MemberID <= 0) return "Selection error.";
            return _memberRepo.UpdateMember(member) ? "Member updated successfully!" : "Update failed.";
        }

        public string RemoveMember(int id)
        {
            return _memberRepo.DeleteMember(id) ? "Member deleted." : "Delete failed.";
        }

        public DataTable SearchMembersInInventory(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                return _memberRepo.GetAllMembers(); // If empty, show everyone
            }

            string sanitizedTerm = term.Trim();
            return _memberRepo.SearchMembers(sanitizedTerm);
        }

    }
}