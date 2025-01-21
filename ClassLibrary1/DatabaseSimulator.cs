using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class DatabaseSimulator
    {
        private readonly List<string> _mockData = new()
        {
            "Eintrag 1",
            "Eintrag 2",
            "Eintrag 3",
            "Eintrag 4",
        };

        // Synchrone Methode zum Abrufen von Daten
        public List<string> GetData()
        {


            // Simuliere Verzögerung (z. B. Datenbankabfrage)
            Thread.Sleep(20000);

            
            return _mockData;
        }

        // Asynchrone Methode zum Abrufen von Daten
        public async Task<List<string>> GetDataAsync()
        {


            // Simuliere Verzögerung (z. B. asynchrone Datenbankabfrage)
            await Task.Delay(20000);


            return _mockData;
        }
    }
}
