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
    public class WriterManager : IWriterService
    {
        public IResult Add(Writer writer)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Writer writer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Writer> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Writer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
