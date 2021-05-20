using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;

namespace ConsoleApp1
{
    class MemberCollection : iMemberCollection
    {
        public int Number => throw new NotImplementedException();

        public void add(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void delete(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public bool search(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public iMember[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
