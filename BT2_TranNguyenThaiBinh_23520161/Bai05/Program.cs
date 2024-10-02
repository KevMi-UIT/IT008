using System.Text;

namespace Bai05;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;

        Console.Write("Số lượng khu đất: ");
        int k = int.Parse(Console.ReadLine());
        KhuDat[] K = new KhuDat[k];

        Console.Write("Số lượng nhà phố: ");
        int n = int.Parse(Console.ReadLine());
        NhaPho[] N = new NhaPho[n];

        Console.Write("Số lượng chung cư: ");
        int c = int.Parse(Console.ReadLine());
        ChungCu[] C = new ChungCu[c];

        choose(K, N, C);
    }
    public class KhuDat
    {
        protected string location;
        protected long price;
        protected double area;
        public string Location
        {
            get
            {
                return location;
            }
        }
        public long Price
        {
            get
            {
                return price;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        public void infoImport()
        {
            Console.Write("- Địa điểm: ");
            location = Console.ReadLine();
            Console.Write("- Diện tích (m2): ");
            area = int.Parse(Console.ReadLine());
            Console.Write("- Giá bán (VND): ");
            price = long.Parse(Console.ReadLine());
            moreInfoImport();
        }
        public void infoExport()
        {
            Console.WriteLine("- Địa điểm: " + location);
            Console.WriteLine("- Diện tích (m2): " + area);
            Console.WriteLine("- Giá bán (VND): " + price);
            moreInfoExport();
        }
        public virtual void moreInfoImport() { }
        public virtual void moreInfoExport() { }
    }
    public class NhaPho : KhuDat
    {
        private int buildYear;
        private int floorAmount;
        public int BuildYear
        {
            get
            {
                return buildYear;
            }
        }
        public int FloorAmount
        {
            get
            {
                return floorAmount;
            }
        }
        public override void moreInfoImport()
        {
            Console.Write("- Năm xây dựng: ");
            buildYear = int.Parse(Console.ReadLine());
            Console.Write("- Số tầng: ");
            floorAmount = int.Parse(Console.ReadLine());
        }
        public override void moreInfoExport()
        {
            Console.WriteLine("- Năm xây dựng: " + buildYear);
            Console.WriteLine("- Số tầng: " + floorAmount);
        }
    }
    public class ChungCu : KhuDat
    {
        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
        }
        public override void moreInfoImport()
        {
            Console.Write("- Thuộc tầng: ");
            floor = int.Parse(Console.ReadLine());
        }
        public override void moreInfoExport()
        {
            Console.WriteLine("- Thuộc tầng: " + floor);
        }
    }
    static void menu()
    {
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine(" (1) Nhập thông tin");
        Console.WriteLine(" (2) Xuất thông tin");
        Console.WriteLine(" (3) Xuất tổng giá bán cho ba loại");
        Console.WriteLine(" (4) Xuất danh sách khu đất có diện tích trên 100 m2 hoặc nhà phố có diện tích trên 60 m2 và năm xây dựng bắt đầu từ 2019");
        Console.WriteLine(" (5) Tìm thông tin danh sách tất cả các nhà phố hoặc chung cư phù hợp yêu cầu ");
        Console.WriteLine(" (6) Thoát");
        Console.WriteLine("-------------------------------------------------------------------");
    }
    static void choose(KhuDat[] KhuDatArr, NhaPho[] NhaPhoArr, ChungCu[] ChungCuArr)
    {
        menu();
        Console.Write("  Lựa chọn của bạn là: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Clear();
                infoImport(KhuDatArr, NhaPhoArr, ChungCuArr);
                choose(KhuDatArr, NhaPhoArr, ChungCuArr);
                break;
            case 2:
                Console.Clear();
                infoExport(KhuDatArr, NhaPhoArr, ChungCuArr);
                choose(KhuDatArr, NhaPhoArr, ChungCuArr);
                break;
            case 3:
                Console.Clear();
                priceTotal(KhuDatArr, NhaPhoArr, ChungCuArr);
                choose(KhuDatArr, NhaPhoArr, ChungCuArr);
                break;
            case 4:
                Console.Clear();
                findList(KhuDatArr, NhaPhoArr);
                choose(KhuDatArr, NhaPhoArr, ChungCuArr);
                break;
            case 5:
                Console.Clear();
                findInfo(NhaPhoArr, ChungCuArr);
                choose(KhuDatArr, NhaPhoArr, ChungCuArr);
                break;
            case 6:
                Console.Clear();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Lựa chọn không hợp lệ!");
                choose(KhuDatArr, NhaPhoArr, ChungCuArr);
                break;
        }
    }
    static void infoImport(KhuDat[] KhuDatArr, NhaPho[] NhaPhoArr, ChungCu[] ChungCuArr)
    {
        for (int i = 0; i < KhuDatArr.Length; i++)
        {
            Console.WriteLine("Khu đất thứ {0}:", i + 1);
            KhuDatArr[i] = new KhuDat();
            KhuDatArr[i].infoImport();
            Console.Clear();
        }
        for (int i = 0; i < NhaPhoArr.Length; i++)
        {
            Console.WriteLine("Nhà phố thứ {0}:", i + 1);
            NhaPhoArr[i] = new NhaPho();
            NhaPhoArr[i].infoImport();
            Console.Clear();
        }
        for (int i = 0; i < ChungCuArr.Length; i++)
        {
            Console.WriteLine("Chung cư thứ {0}:", i + 1);
            ChungCuArr[i] = new ChungCu();
            ChungCuArr[i].infoImport();
            Console.Clear();
        }
    }
    static void infoExport(KhuDat[] KhuDatArr, NhaPho[] NhaPhoArr, ChungCu[] ChungCuArr)
    {
        for (int i = 0; i < KhuDatArr.Length; i++)
        {
            Console.WriteLine("Khu đất thứ {0}:", i + 1);
            KhuDatArr[i].infoExport();
        }
        Console.WriteLine();
        for (int i = 0; i < NhaPhoArr.Length; i++)
        {
            Console.WriteLine("Nhà phố thứ {0}:", i + 1);
            NhaPhoArr[i].infoExport();
        }
        Console.WriteLine();
        for (int i = 0; i < ChungCuArr.Length; i++)
        {
            Console.WriteLine("Chung cư thứ {0}:", i + 1);
            ChungCuArr[i].infoExport();
        }
    }
    static void priceTotal(KhuDat[] KhuDatArr, NhaPho[] NhaPhoArr, ChungCu[] ChungCuArr)
    {
        long totalKhuDat = 0;
        for (int i = 0; i < KhuDatArr.Length; i++)
            totalKhuDat += KhuDatArr[i].Price;
        long totalNhaPho = 0;
        for (int i = 0; i < NhaPhoArr.Length; i++)
            totalNhaPho += NhaPhoArr[i].Price;
        long totalChungCu = 0;
        for (int i = 0; i < ChungCuArr.Length; i++)
            totalChungCu += ChungCuArr[i].Price;
        Console.WriteLine("Tổng giá bán khu đất là " + totalKhuDat);
        Console.WriteLine("Tổng giá bán nhà phố là " + totalNhaPho);
        Console.WriteLine("Tổng giá bán chung cư là " + totalChungCu);
    }
    static void findList(KhuDat[] KhuDatArr, NhaPho[] NhaPhoArr)
    {
        bool isAvailableKhuDat()
        {
            for (int i = 0; i < KhuDatArr.Length; i++)
                if (KhuDatArr[i].Area > 100)
                    return true;
            return false;
        }
        bool isAvailableNhaPho()
        {
            for (int i = 0; i < NhaPhoArr.Length; i++)
                if (NhaPhoArr[i].Area > 60 && NhaPhoArr[i].BuildYear >= 2019)
                    return true;
            return false;
        }

        if (!isAvailableKhuDat())
            Console.WriteLine("Không có khu đất nào diện tích lớn hơn 100 m2");
        else
        {
            Console.WriteLine("Các khu đất có diện tích lớn hơn 100 m2 gồm có:");
            for (int i = 0; i < KhuDatArr.Length; i++)
                if (KhuDatArr[i].Area > 100)
                {
                    KhuDatArr[i].infoExport();
                    Console.WriteLine();
                }
        }

        if (!isAvailableNhaPho())
            Console.WriteLine("Không có nhà phố nào diện tích lớn hơn 100 m2");
        else
        {
            Console.WriteLine("Các nhà phố có diện tích lớn hơn 100 m2 gồm có:");
            for (int i = 0; i < NhaPhoArr.Length; i++)
                if (NhaPhoArr[i].Area > 60 && NhaPhoArr[i].BuildYear >= 2019)
                    NhaPhoArr[i].infoExport();
        }
    }
    static void findInfo(NhaPho[] NhaPhoArr, ChungCu[] ChungCuArr)
    {
        Console.Write("Địa điểm cần tìm: ");
        string findLocation = Console.ReadLine();
        Console.Write("Tầm giá cần tìm: ");
        long findPrice = long.Parse(Console.ReadLine());
        Console.Write("Diện tích cần tìm: ");
        double findArea = double.Parse(Console.ReadLine());
        Console.Clear();

        bool isAvailable(dynamic[] x)
        {
            for (int i = 0; i < x.Length; i++)
                if (x[i].Location.ToLower() == findLocation.ToLower() && x[i].Price <= findPrice && x[i].Area >= findArea)
                    return true;
            return false;
        }
        void printInfo(dynamic[] x)
        {
            for (int i = 0; i < x.Length; i++)
                if (x[i].Location.ToLower() == findLocation.ToLower() && x[i].Price <= findPrice && x[i].Area >= findArea)
                    x[i].infoExport();
            Console.WriteLine();
        }

        if (!isAvailable(NhaPhoArr))
            Console.WriteLine("Không có nhà phố nào thỏa mãn thông tin tìm kiếm");
        else
        {
            Console.WriteLine("Thông tin các nhà phố thỏa mãn thông tin tìm kiếm gồm: ");
            printInfo(NhaPhoArr);
        }

        if (!isAvailable(ChungCuArr))
            Console.WriteLine("Không có chung cư nào thỏa mãn thông tin tìm kiếm");
        else
        {
            Console.WriteLine("Thông tin các chung cư thỏa mãn thông tin tìm kiếm gồm: ");
            printInfo(ChungCuArr);
        }
    }
}
