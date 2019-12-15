using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_thutien
    {
        private string _mapt;
        private string _tiendien;
        private string _tiennuoc;
        private string _tienmang;
        private string _tienxe;
        private string _tienphong;
        private string _tongtien;
        private DateTime _ngaythu;
        

        public string mapt
        {
            get
            {
                return _mapt;
            }

            set
            {
                _mapt = value;
            }
        }

        public string tiendien
        {
            get
            {
                return _tiendien;
            }

            set
            {
                _tiendien = value;
            }
        }

        public string tienphong
        {
            get
            {
                return _tienphong;
            }

            set
            {
                _tienphong = value;
            }
        }

        public string tiennuoc
        {
            get
            {
                return _tiennuoc;
            }

            set
            {
                _tiennuoc = value;
            }
        }

        public string tienxe
        {
            get
            {
                return _tienxe;
            }

            set
            {
                _tienxe = value;
            }
        }
        public string tienmang
        {
            get
            {
                return _tienmang;
            }

            set
            {
                _tienmang = value;
            }
        }
        public string tongtien
        {
            get
            {
                return _tongtien;
            }

            set
            {
                _tongtien = value;
            }
        }
        public DateTime ngaythu
        {
            get
            {
                return _ngaythu;
            }
            set
            {
                _ngaythu = value;
            }
        }
    }
}
