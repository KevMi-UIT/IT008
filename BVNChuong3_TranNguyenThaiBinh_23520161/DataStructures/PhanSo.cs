using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BVNChuong3_TranNguyenThaiBinh_23520161.Utils.Utils;

namespace BVNChuong3_TranNguyenThaiBinh_23520161.DataStructures
{
    internal class PhanSo
    {
        private int tu;
        public int Tu
        {
            get { return tu; }
            private set { tu = value; }
        }

        private int mau;
        public int Mau
        {
            get { return mau; }
            private set { mau = value; }
        }

        public PhanSo(int _tu = 0, int _mau = 1)
        {
            if (_mau == 0)
            {
                throw new ArgumentException("Mau so khong the bang 0");
            }
            int ucln = GCD(_tu, _mau);
            tu = _tu / ucln;
            mau = _mau / ucln;
        }

        public override string ToString()
        {
            if (mau == 1)
                return tu.ToString();
            if (tu == 0)
                return "0";
            return (tu * mau > 0 ? "" : "-") + Math.Abs(tu) + "/" + Math.Abs(mau);
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tu * b.mau + b.tu * a.mau, a.mau * b.mau);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tu * b.mau - b.tu * a.mau, a.mau * b.mau);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tu * b.tu, a.mau * b.mau);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tu * b.mau, a.mau * b.tu);
        }
    }
}
