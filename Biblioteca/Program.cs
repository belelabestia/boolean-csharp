/*
 * TEST CASE:
 * 
 * allestimento
 * operazione da testare
 * asserzioni
 * 
 */

/*
 * CASES:
 * 
 * - CercaDocumentoPerCodice
 *   .trova per codice
 *   .torna null se codice errato
 *   .torna null se lista vuota
 * 
 */

using Biblioteca;
using Biblioteca.Models.Documenti;

var res = CercaDocumentoPerCodice_TrovaPerCodice();
printTestResult(nameof(CercaDocumentoPerCodice_TrovaPerCodice), res);

void printTestResult(string testCase, bool ok)
{
    Console.WriteLine($"testing: {testCase}");
    Console.WriteLine(ok ? "passed :)" : "failed :(");
}

bool CercaDocumentoPerCodice_TrovaPerCodice()
{
    var biblioteca = new BibliotecaDb();
    var testDoc = new Documento("0001", "Noi e la Giulia");
    biblioteca.AggiungiDocumento(testDoc);
    biblioteca.AggiungiDocumento(new Documento("0002", "Il signore degli anelli"));
    biblioteca.AggiungiDocumento(new Documento("0003", "Harry potter"));

    var risultato = biblioteca.CercaDocumentoPerCodice("0001");

    return risultato == testDoc;
}