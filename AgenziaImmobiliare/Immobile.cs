using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Environment;

public class Immobile
{
    string codice;
    string indirizzo;
    string cap;
    string citta;
    int metriQuadri;
    int personeInteressate;

    public Immobile(string codice, string indirizzo, string cap, string citta, int metriQuadri, int personeInteressate)
    {
        this.codice = codice;
        this.indirizzo = indirizzo;
        this.cap = cap;
        this.citta = citta;
        this.metriQuadri = metriQuadri;
        this.personeInteressate = personeInteressate;
    }

    public void IncrementaPersoneInteressate() => personeInteressate++;
    public void ReimpostaSuperfici(int mq) => metriQuadri = mq;

    public override string ToString()
    {
        return $"codice: {codice}" + NewLine
            + $"indirizzo: {indirizzo}" + NewLine
            + $"cap: {cap}" + NewLine
            + $"città: {citta}" + NewLine
            + $"mq: {metriQuadri}" + NewLine
            + $"persone interessate: {personeInteressate}";
    }
}

public class Box : Immobile
{
    int postiAuto;

    public Box(string codice, string indirizzo, string cap, string citta, int metriQuadri, int personeInteressate, int postiAuto) : base(codice, indirizzo, cap, citta, metriQuadri, personeInteressate)
    {
        this.postiAuto = postiAuto;
    }

    public override string ToString()
    {
        return base.ToString() + NewLine
            + $"posti auto: {postiAuto}";
    }
}

public class Abitazione : Immobile
{
    int vani;
    int bagni;

    public Abitazione(string codice, string indirizzo, string cap, string citta, int metriQuadri, int personeInteressate, int vani, int bagni) : base(codice, indirizzo, cap, citta, metriQuadri, personeInteressate)
    {
        this.vani = vani;
        this.bagni = bagni;
    }

    public override string ToString()
    {
        return base.ToString() + NewLine
            + $"vani: {vani}" + NewLine
            + $"bagni: {bagni}";
    }
}

public class Villa : Abitazione
{
    int metriQuadriGiardino;

    public Villa(string codice, string indirizzo, string cap, string citta, int metriQuadri, int personeInteressate, int vani, int bagni, int metriQuadriGiardino) : base(codice, indirizzo, cap, citta, metriQuadri, personeInteressate, vani, bagni)
    {
        this.metriQuadriGiardino = metriQuadriGiardino;
    }

    public void ReimpostaSuperfici(int mq, int mqGiardino)
    {
        ReimpostaSuperfici(mq);
        metriQuadriGiardino = mqGiardino;
    }

    public override string ToString()
    {
        return base.ToString() + NewLine
            + $"mq giardino: {metriQuadriGiardino}";
    }
}