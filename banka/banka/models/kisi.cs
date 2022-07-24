using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka.models
{
    internal class kisi
    {
        [Key]

        public int tc { get; set; }
        public string sifre { get; set; }
    }
}
