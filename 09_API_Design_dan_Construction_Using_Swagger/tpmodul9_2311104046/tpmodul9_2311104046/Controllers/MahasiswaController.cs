using Microsoft.AspNetCore.Mvc;
using tpmodul9_2311104046.Models;
using System.Collections.Generic;

namespace tpmodul9_2311104046.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        // STATIC LIST, ini tempat simpan data mahasiswa
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Tulus", Nim = "2311104046" },
            new Mahasiswa { Nama = "Alya", Nim = "2311104076" },
            new Mahasiswa { Nama = "Aulia", Nim = "2311104060" }
        };

        // GET semua mahasiswa
        [HttpGet]
        public ActionResult<List<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }

        // GET mahasiswa berdasarkan index
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            return daftarMahasiswa[index];
        }

        // POST mahasiswa baru
        [HttpPost]
        public ActionResult<List<Mahasiswa>> Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return daftarMahasiswa;
        }

        // DELETE mahasiswa berdasarkan index
        [HttpDelete("{index}")]
        public ActionResult<List<Mahasiswa>> Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            daftarMahasiswa.RemoveAt(index);
            return daftarMahasiswa;
        }
    }
}
