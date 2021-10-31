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
    public class AboutManager : IAboutService
    {
        public IResult Add(About about)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(About about)
        {
            throw new NotImplementedException();
        }

        public IDataResult<About> Get()
        {
            throw new NotImplementedException();
        }

        public IResult Update(About about)
        {
            throw new NotImplementedException();
        }
    }
}
