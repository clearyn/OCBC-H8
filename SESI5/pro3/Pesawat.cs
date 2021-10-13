using System;

public class Pesawat
{   
    
    public string Nama;
    public int JumlahRoda;
    public string JumlahPenumpang;
    public string Ketinggian;

    public virtual void terbang()
    {
        Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.Nama);
    }

    public void sudahTerbang()
    {
        Console.WriteLine("Pesawat sekarang berada ketinggian {0}", this.Ketinggian);
    }

}

class pesawat_tempur : Pesawat
{
    public override void terbang()
    {
        Console.WriteLine("Pesawat Tempur dengan nama {0}. yang mempunyai jumlah roda {1}, sedang berada pada kettingian {2} dengan membawa jumlah penumpang sebanyak {3} Akan meledakan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
    }

    public void terbangTinggi()
    {
        Console.WriteLine("Pesawat terbang tinggi!");
    }
}