// See https://aka.ms/new-console-template for more information

using Group_C;
var tshape = Shapes.Tshape();
var ushape = Shapes.Ushape();
var mshape = Shapes.Mshape();
var tushape = new Union(tshape,ushape);
var tumshape = new Union(tushape,mshape);
tumshape.Visualize(80,80,1.8);








