using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BVNChuong3_TranNguyenThaiBinh_23520161.DataStructures
{
    internal class SoPhuc
    {
        private int phanThuc;
        public int PhanThuc
        {
            get { return phanThuc; }
            private set { phanThuc = value; }
        }
        private int phanAo;
        public int PhanAo
        {
            get { return phanAo; }
            private set { phanAo = value; }
        }
        public SoPhuc(int _phanThuc = 0, int _phanAo = 0)
        {
            phanThuc = _phanThuc;
            phanAo = _phanAo;
        }
        public override string ToString()
        {
            if (phanAo == 0)
                return phanThuc.ToString();
            if (phanThuc == 0)
                return phanAo + "i";
            if (phanAo < 0)
                return phanThuc + " - " + (phanAo) + "i";
            return phanThuc + " + " + phanAo + "i";
        }
        public static SoPhuc operator +(SoPhuc a, SoPhuc b)
        {
            return new SoPhuc(a.phanThuc + b.phanThuc, a.phanAo + b.phanAo);
        }
        public static SoPhuc operator -(SoPhuc a, SoPhuc b)
        {
            return new SoPhuc(a.phanThuc - b.phanThuc, a.phanAo - b.phanAo);
        }
        public static SoPhuc operator *(SoPhuc a, SoPhuc b)
        {
            return new SoPhuc(a.phanThuc * b.phanThuc - a.phanAo * b.phanAo, a.phanThuc * b.phanAo + a.phanAo * b.phanThuc);
        }
        public static SoPhuc operator /(SoPhuc a, SoPhuc b)
        {
            int tu = a.phanThuc * b.phanThuc + a.phanAo * b.phanAo;
            int mau = b.phanThuc * b.phanThuc + b.phanAo * b.phanAo;
            return new SoPhuc(tu / mau, (a.phanAo * b.phanThuc - a.phanThuc * b.phanAo) / mau);
        }
    }
}
