using DependencyInjection;

var context = new AAA();
var controller = new Controller(context);

controller.Endpoint(new Model { });