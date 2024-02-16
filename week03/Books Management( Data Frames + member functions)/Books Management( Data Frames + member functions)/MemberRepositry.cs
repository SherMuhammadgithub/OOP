using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Management__Data_Frames___member_functions_
{
    internal class MemberRepositry
    {
        List<Member> members;
        public MemberRepositry() {
            members = new List<Member>();
        }
        public void AddMember(Member member)
        {
            members.Add(member);
        }
        public Member GetMember(string search_query)
        {
         
            // if id then member
            if(int.TryParse(search_query, out int member_id))
            {
             Member member_to_search = members.Find(member => member.id == member_id);
            if(member_to_search != null)
            {
                return member_to_search;
            }
               }
             else // not a member
            {
                Member non_member_to_search = members.Find(member => member.name.Equals(search_query, StringComparison.OrdinalIgnoreCase) );
                if(non_member_to_search != null)
                 return non_member_to_search;
            }

            return null;
        }
        public bool UpdateMemberInfo(string search_query, Member updated_member)
        {
            if(int.TryParse(search_query, out int  updated_member_id))
            {
                Member existing_member = members.Find(member => member.id == updated_member_id);
                if(existing_member != null)
                {
                    existing_member.name = updated_member.name;
                    existing_member.id = updated_member_id;
                    return true;
                }
            }
            else
            {
                Member non_memeber = members.Find(member => member.name.Equals(search_query, StringComparison.OrdinalIgnoreCase));
                if(non_memeber != null)
                {
                    non_memeber.name = updated_member.name;
                    return true;
                }
            }
            return false;
        }
    }
}
