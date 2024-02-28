using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Aroma.Domain.Entities.Auth;
//using Aroma.Domain.Entities.GeneralResponce;
using Aroma.Domain.Entities.Product;
using Aroma.Domain.Entities.Product.DBModel;
using Aroma.Domain.Entities.User;
//using Aroma.Domain.Entities.User.DbModel;

namespace Aroma.BusinessLogic.Core
{
    public class UserApi
    {

        //___________________________Product________________________________________
        internal ProductDataModel ProductActionGetToList()
        {
            var products = new List<Product>();


            return new ProductDataModel { Products = products };
        }




    }
}
