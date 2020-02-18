using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestBlazor.Models
{
    public partial class Mahasiswas
    {
        //[Required(ErrorMessage = "ID tolong di isi")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nim tolong di isi")]
        public string Nim { get; set; }
        [Required(ErrorMessage = "Nama tolong di isi")]
        public string Nama { get; set; }
        [Required(ErrorMessage = "Alamat tolong di isi")]
        public string Alamat { get; set; }
        [Required(ErrorMessage = "Phone tolong di isi")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "JenisKelamin tolong di isi")]
        public int JenisKelamin { get; set; }
        [Required(ErrorMessage = "TanggalLahir tolong di isi")]
        public DateTime TanggalLahir { get; set; }
        [Required(ErrorMessage = "Tinggi tolong di isi")]
        public int Tinggi { get; set; }
        [Required(ErrorMessage = "Berat tolong di isi")]
        public int Berat { get; set; }
    }
}
