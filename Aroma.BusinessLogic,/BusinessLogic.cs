using Aroma.BusinessLogic_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aroma.BusinessLogic_.Core;
using Aroma.Domain.Entities.User;
using Aroma.BusinessLogic.Interfaces;
using Aroma.Helpers;
namespace Aroma.BusinessLogic_
{
    public class BussinesLogic
    {
        public IProduct GetProductBL()
        {
            return new ProductBL();
        }

    }
}
