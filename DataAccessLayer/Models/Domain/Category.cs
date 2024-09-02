using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Domain
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string UrlHandle { get; set; }
    }
}
