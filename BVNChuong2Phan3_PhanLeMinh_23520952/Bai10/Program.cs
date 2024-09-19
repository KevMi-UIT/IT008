// 226

namespace Bai10;

internal interface ISoSanh : IComparable
{
}

internal class SinhVien(string hoTen = "", float diemTrungBinh = 0) : ISoSanh
{
    public string HoTen { get; private set; } = hoTen;
    public float DiemTrungBinh { get; private set; } = diemTrungBinh;

    public int CompareTo(object? obj)
    {
        if (obj == null)
        {
            return 1;
        }
        SinhVien? other = obj as SinhVien;
        return other switch
        {
            null => throw new ArgumentException("Object is not a SinhVien"),
            _ => (int)((DiemTrungBinh - other.DiemTrungBinh) * 100)
        };
    }

    public override string ToString()
    {
        return $"Ho ten: {HoTen}\nDiem trung binh: {DiemTrungBinh,-2}";
    }
}

public class Program
{
    private static void VoidSinhVienInput(out string hoTen, out float diemTrungBinh)
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";
        Console.Write("Nhap diem trung binh: ");
        diemTrungBinh = float.Parse(Console.ReadLine() ?? "0");
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        List<SinhVien> ds = new(n);

        for (int i = 0; i < n; ++i)
        {
            VoidSinhVienInput(out string hoTen, out float diemTrungBinh);
            ds.Add(new(hoTen, diemTrungBinh));
        }

        ds.Sort();

        Console.WriteLine("Danh sach sinh vien sau khi sap xep theo DTB:");

        foreach (SinhVien sinhVien in ds)
        {
            Console.WriteLine(sinhVien);
        }
    }
}
