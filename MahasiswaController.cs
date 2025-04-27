using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_103022300109
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // Data Awal CIhuyu
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Reza Indra Maulana", Nim = "103022300109" },
            new Mahasiswa { Nama = "Deru Khairan Djuharianto", Nim = "103022300101" },
            new Mahasiswa { Nama = "Siapa aja lah", Nim = "103022300100" }
        };

        // GET
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return mahasiswaList;
        }

        // GET
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
            {
                return NotFound();
            }
            return mahasiswaList[index];
        }

        // POST
        [HttpPost]
        public ActionResult<IEnumerable<Mahasiswa>> Post([FromBody] Mahasiswa newMahasiswa)
        {
            mahasiswaList.Add(newMahasiswa);
            return mahasiswaList;
        }

        // DELETE
        [HttpDelete("{index}")]
        public ActionResult<IEnumerable<Mahasiswa>> Delete(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
            {
                return NotFound();
            }

            mahasiswaList.RemoveAt(index);
            return mahasiswaList;
        }
    }
}
