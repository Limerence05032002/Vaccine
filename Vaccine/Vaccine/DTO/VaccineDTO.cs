using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.DTO
{
    class VaccineDTO
    {
        private string MaDM;
        private string HSD;
        private string TenVC;
        private string MaVC;

        public string MaDM1
        {
            get { return MaDM; }
            set { MaDM = value; }
        }

        public string MaVC1
        {
            get { return MaVC; }
            set { MaVC = value; }
        }

        public string TenVC1
        {
            get { return TenVC; }
            set { TenVC = value; }
        }

        public string HSD1
        {
            get { return HSD; }
            set { HSD = value; }
        }
    }
}
