using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.Responses.CategoryResponses
{
    public class GetAllCategoryResponse
    {
        public int CategoryResponseId { get; set; }

        public string CategoryResponseName { get; set; }
    }
}
