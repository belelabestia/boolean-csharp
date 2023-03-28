using GestoreEventi;

var e = new Evento();

_ = e.Whole; // 0
_ = e.Half; // 0
_ = e.GetWholeAsDouble(); // 0.0
_ = e.GetWhole(); // 0
_ = e.GetHalf(); // 0

_ = e.Half;
e.Half = 13;
_ = e.Whole; // 26
e.Whole = 2;
_ = e.Half; // 1
_ = e.GetHalf();
e.SetHalf(3);
_ = e.GetWholeAsDouble(); // 6.0