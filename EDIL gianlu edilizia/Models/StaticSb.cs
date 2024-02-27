using System.Collections.Generic;  // Import necessary namespace for List

namespace EDIL_gianlu_edilizia.Models
{
    public class StaticSb
    {
        // Initialize a static variable to keep track of the maximum dipendentiId
        public static int _maxId = 3;

        // Initialize a static List<dipendenti> to store dipendenti objects
        public static List<dipendenti> _dipendenti = new List<dipendenti>
        {
            new dipendenti() { dipendentiId = 1, Name = "Gigi", Surname = "Buffone", Anni = 22, Stipendio = 2800 },
            new dipendenti() { dipendentiId = 2, Name = "Gigi", Surname = "Buffone", Anni = 22, Stipendio = 2800 },
            new dipendenti() { dipendentiId = 3, Name = "Gigi", Surname = "Buffone", Anni = 22, Stipendio = 2800 },
        };

        // Method to get all dipendenti
        public static List<dipendenti> GetAll()
        {
            return _dipendenti;
        }

        // Method to get dipendenti by id
        // Metodo per ottenere un dipendente per ID
        public static dipendenti? GetById(int? id)
        {
            if (id is null) return null;

            foreach (var dipendenti in _dipendenti)
            {
                if (dipendenti.dipendentiId == id.Value)
                {
                    return dipendenti;
                }
            }

            return null;
        }

        // Method to add a new dipendenti
        public static dipendenti Add(string name, string surname, int anni, int stipendio)
        {
            _maxId++;

            // Create a new dipendenti object with the incremented dipendentiId
            var newDipendenti = new dipendenti()
            {
                dipendentiId = _maxId,
                Name = name,
                Surname = surname,
                Anni = anni,
                Stipendio = stipendio
            };

            // Add the new dipendenti to the list
            _dipendenti.Add(newDipendenti);

            // Return the newly added dipendenti
            return newDipendenti;
        }
    }
}
