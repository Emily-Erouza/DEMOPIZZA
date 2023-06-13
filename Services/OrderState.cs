// namespace BlazingPizza.Services;

// public class OrderState
// {
//     public bool ShowingConfigureDialog { get; private set; }
//     public ContosoPizza.Models.Pizza? ConfiguringPizza { get; private set; }
//     public Order Order { get; private set; } = new Order();

//     public void ShowConfigurePizzaDialog(PizzaSpecial special)
//     {
//         ConfiguringPizza = new ContosoPizza.Models.Pizza()
//         {
//             Special = special,
//             SpecialId = special.Id,
//             Size = ContosoPizza.Models.Pizza.DefaultSize,
//             Toppings = new List<PizzaTopping>(),
//         };

//         ShowingConfigureDialog = true;
//     }

//     public void CancelConfigurePizzaDialog()
//     {
//         ConfiguringPizza = null;

//         ShowingConfigureDialog = false;
//     }

//     public void ConfirmConfigurePizzaDialog()
//     {
//         Order.Pizzas.Add(ConfiguringPizza);
//         ConfiguringPizza = null;

//         ShowingConfigureDialog = false;
//     }
// }

// public class Order
// {
//     internal object? Pizzas;
// }

// internal class PizzaTopping
// {
// }
// // remove a pizza from a customer oder
// public void RemoveConfiguredPizza(ContosoPizza.Models.Pizza pizza)
// {
//     Order.Pizzas.Remove(pizza);
// }