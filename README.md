# pizzabox

Not impressed with UberEats, DoorDash, GrubHub pizza offerings?
You can now try PizzaBox, the latest food delivery service.
It is a command line-based application focused on nothing but pizzas.

## technologies

+ .NET Core - C#
+ .NET Core - EF + SQL
+ .NET Core - xUnit
+ ASP.NET Core - MVC

### Current features available on PizzaBox 

- A customer is able to view all stores and make a selection 
- A customer is able to place an order for both custom and pre-set pizzas
- A customer is able to select Size, toppings, and crust type for their pizzas
- A customer is able to view previously placed order

### To-do list:
- Add more form validation
- Implement functionality specific to store employees

## Getting started

git clone https://github.com/Gledinburgh/project-pizzabox-web.git

### Development server

From PizzaBox.Client directory, run `dotnet run` for a dev server. Navigate to `http://localhost:5000/home/index`. 

### Build

Run `dotnet build` to build the project. The build artifacts will be stored in the `dist/` directory. 

### Running unit tests

Run `dotnet test` to execute the unit tests via [Xunit](https://github.com/xunit/xunit).

## Usage

- Navigate the main page at localhost:5000/home/index
- Input name and select next
- Select the desired store you wish to order from
- Select the desired pizza you wish to order
- Select the desired crust, toppings, and size for your pizza
- Select from a list of final actions such as "order history" or "Place order" 

## Contributors
- Glenn Edinbourgh

## License

This project uses the following license: MIT
