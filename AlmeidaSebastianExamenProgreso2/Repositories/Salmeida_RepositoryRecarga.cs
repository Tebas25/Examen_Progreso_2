using AlmeidaSebastianExamenProgreso2.Interfaces;
using AlmeidaSebastianExamenProgreso2.Models;
using Newtonsoft.Json;

namespace AlmeidaSebastianExamenProgreso2.Repositories
{
    public class Salmeida_RepositoryRecarga : ISalmeidaRecarga
    {
        private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "SebastianAlmeida.txt");
        public bool CreateRecarga(SalmeidaRecarga recarga)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(recarga);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteRecarga(string numero)
        {
            throw new NotImplementedException();
        }

        public SalmeidaRecarga GetRecarga(string numero)
        {
            SalmeidaRecarga recarga = new SalmeidaRecarga();
            if (File.Exists(_fileName))
            {
                string josn_data = File.ReadAllText(_fileName);
                recarga = JsonConvert.DeserializeObject<SalmeidaRecarga>(josn_data);
            }
            return recarga;
        }

        public bool UpdateRecarga(SalmeidaRecarga recarga)
        {
            throw new NotImplementedException();
        }
    }
}
