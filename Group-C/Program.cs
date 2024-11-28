// See https://aka.ms/new-console-template for more information

using Group_C;

var tShape = Shapes.TShape();
var uShape = Shapes.UShape();
var mShape = Shapes.MShape();
var tuShape = new Union(tShape, uShape);
var tumShape = new Union(tuShape, mShape);
tumShape.Visualize(80, 80);