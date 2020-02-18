using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlazor.Models;

namespace TestBlazor.Services
{
    public class MahasiswaService : ICrud<Mahasiswas>
    {
        MahasiswaContext db;
        public MahasiswaService()
        {
            if (db == null) db = new MahasiswaContext();
        }
        public bool DeleteData(object Id)
        {
            if (Id is int FID)
            {
                var data = from x in db.Mahasiswas
                           where x.Id == FID
                           select x;
                foreach (var item in data)
                {
                    db.Mahasiswas.Remove(item);
                }
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Mahasiswas> GetAllData()
        {
            var data = from x in db.Mahasiswas
                       select x;
            return data.ToList();
        }

        public Mahasiswas GetDataById(object Id)
        {
            if (Id is int FID)
            {
                var data = from x in db.Mahasiswas
                           where x.Id == FID
                           select x;
                return data.FirstOrDefault();
            }
            return default;
        }

        public int GetLastId()
        {
            var lastId = db.Mahasiswas.OrderByDescending(x => x.Id).FirstOrDefault();
            return lastId.Id + 1;
        }

        public bool InsertData(Mahasiswas data)
        {
            try
            {
                db.Mahasiswas.Add(data);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return false;
            }

        }

        public bool UpdateData(Mahasiswas data)
        {
            try
            {
                db.Entry(data).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;


            }

        }
    }
}
