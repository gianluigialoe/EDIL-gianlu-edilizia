using EDIL_gianlu_edilizia.Models;
using Microsoft.AspNetCore.Mvc;

namespace EDIL_gianlu_edilizia.controllers
{
    public class DipententiController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticSb.GetAll());
        }
        public IActionResult ADD()
        {
            return View();


        }
        [HttpPost]
        public IActionResult Add(string name, string Surname, int Anni, int Stipendio)
        {
            try
            {
                // Validare i dati, ad esempio controllare se i campi sono vuoti o se sono rispettati i requisiti
                // Includi la logica di validazione necessaria qui

                // Aggiungi il nuovo dipendente utilizzando il metodo della classe StaticSb
                var newDipendente = StaticSb.Add(name, Surname, Anni, Stipendio);

                // Dopo l'aggiunta del dipendente, puoi aggiornare dinamicamente la lista dei dipendenti nella tua vista.
                // Qui, sto usando RedirectToAction per reindirizzare all'azione "Index" del controller corrente.
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // In caso di errori, puoi gestire l'eccezione qui e restituire un risultato adeguato
                // Puoi anche loggare l'errore per analizzarlo successivamente
                return RedirectToAction("Error"); // Personalizza questa azione in base alle tue esigenze
            }
        }

        // ... altri metodi del controller ...
    }
}
