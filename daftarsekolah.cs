using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Dbsekoolah
{
    #region Daftarsekolah
    public class Daftarsekolah
    {
        #region Member Variables
        protected int _id;
        protected string _nama;
        protected string _tempat_lahir;
        protected unknown _tanggal_lahir;
        protected string _alamat;
        protected string _nohp_siswa;
        protected string _pilih_jurusan;
        protected string _jalur_pendaftaran;
        protected string _nama_sekolah_asal;
        protected string _alamat_sekolah_asal;
        protected string _dimanakah_anda_mendapatkan_info_tentang_SMK_Syafii_akrom;
        #endregion
        #region Constructors
        public Daftarsekolah() { }
        public Daftarsekolah(string nama, string tempat_lahir, unknown tanggal_lahir, string alamat, string nohp_siswa, string pilih_jurusan, string jalur_pendaftaran, string nama_sekolah_asal, string alamat_sekolah_asal, string dimanakah_anda_mendapatkan_info_tentang_SMK_Syafii_akrom)
        {
            this._nama=nama;
            this._tempat_lahir=tempat_lahir;
            this._tanggal_lahir=tanggal_lahir;
            this._alamat=alamat;
            this._nohp_siswa=nohp_siswa;
            this._pilih_jurusan=pilih_jurusan;
            this._jalur_pendaftaran=jalur_pendaftaran;
            this._nama_sekolah_asal=nama_sekolah_asal;
            this._alamat_sekolah_asal=alamat_sekolah_asal;
            this._dimanakah_anda_mendapatkan_info_tentang_SMK_Syafii_akrom=dimanakah_anda_mendapatkan_info_tentang_SMK_Syafii_akrom;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Nama
        {
            get {return _nama;}
            set {_nama=value;}
        }
        public virtual string Tempat_lahir
        {
            get {return _tempat_lahir;}
            set {_tempat_lahir=value;}
        }
        public virtual unknown Tanggal_lahir
        {
            get {return _tanggal_lahir;}
            set {_tanggal_lahir=value;}
        }
        public virtual string Alamat
        {
            get {return _alamat;}
            set {_alamat=value;}
        }
        public virtual string Nohp_siswa
        {
            get {return _nohp_siswa;}
            set {_nohp_siswa=value;}
        }
        public virtual string Pilih_jurusan
        {
            get {return _pilih_jurusan;}
            set {_pilih_jurusan=value;}
        }
        public virtual string Jalur_pendaftaran
        {
            get {return _jalur_pendaftaran;}
            set {_jalur_pendaftaran=value;}
        }
        public virtual string Nama_sekolah_asal
        {
            get {return _nama_sekolah_asal;}
            set {_nama_sekolah_asal=value;}
        }
        public virtual string Alamat_sekolah_asal
        {
            get {return _alamat_sekolah_asal;}
            set {_alamat_sekolah_asal=value;}
        }
        public virtual string Dimanakah_anda_mendapatkan_info_tentang_SMK_Syafii_akrom
        {
            get {return _dimanakah_anda_mendapatkan_info_tentang_SMK_Syafii_akrom;}
            set {_dimanakah_anda_mendapatkan_info_tentang_SMK_Syafii_akrom=value;}
        }
        #endregion
    }
    #endregion
}