using DecoratorDesignPattern;

var circle = new Circle();
var square = new Square();

var redCircleDecorator = new RedShapeDecorator(circle);
var blueSquareDecorator = new BlueShapeDecorator(square);

redCircleDecorator.Move();
blueSquareDecorator.Move();