using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberById(int memberId);
        Member Login(string email, string password);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);
    }
}
