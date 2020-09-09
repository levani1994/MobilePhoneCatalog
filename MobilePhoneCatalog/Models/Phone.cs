using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilePhoneCatalog.Models
{
    public class Phone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Size { get; set; }
        public double Weitht { get; set; }
        public double ScreenSize { get; set; }
        public string ScreenRezolution { get; set; }
        public string CpuModel { get; set; }
        public int Storage { get; set; }
        public string OperationSystem { get; set; }
        public double Price { get; set; }
        public string PictureAndVideo { get; set; }

    }
}
