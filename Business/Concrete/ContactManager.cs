using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        public IResult Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Contact> Get()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
