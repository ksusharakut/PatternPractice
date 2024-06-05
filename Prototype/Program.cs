using Prototype;

ICell originalCell = new MitoticCell("interphase");

ICell daughterCells = originalCell.Clone();

Console.WriteLine(((MitoticCell)originalCell).State);
Console.WriteLine(((MitoticCell)daughterCells).State);