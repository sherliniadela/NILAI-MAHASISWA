using System;

// Membuat class Mahasiswa
class Mahasiswa
{
    // Field / data yang disimpan
    public string Nama;
    public string NIM;
    public double NilaiTugas;
    public double NilaiUTS;
    public double NilaiUAS;

    // Constructor: langsung isi data saat objek dibuat
    public Mahasiswa(string nama, string nim, double tugas, double uts, double uas)
    {
