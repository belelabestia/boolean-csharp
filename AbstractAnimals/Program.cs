using AbstractAnimals.Models;
using AbstractAnimals.Skills;

var aq = new Aquila();
var dl = new Delfino();
var ps = new Passerotto();
var pm = new PulcinellaDiMare();

aq.Vola();
dl.Nuota();
ps.Vola();

if (pm is IVolante v) v.Vola();
if (pm is INuotante n) n.Nuota();