using PGBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PGBusiness.Service.Models
{
    public interface ISearchModel
    {
        List<PayingGuestHouse> Search(SearchFilterCriteria filterCriteria);
    }
    public class SearchModel : ISearchModel
    {

        public List<PayingGuestHouse> Search(SearchFilterCriteria filterCriteria)
        {
            throw new NotImplementedException();
        }
    }
}

    
    