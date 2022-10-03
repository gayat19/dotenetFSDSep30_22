using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreBL
{
    public class Cart
    {
        Dictionary<int, CartPizza> cart;
        public Cart()
        {
            cart = new Dictionary<int, CartPizza>();
        }
        public bool AddToCart(Pizza pizza)
        {
            bool result = false;
            try
            {
                var isPizzaAlreadyPresent = cart.ContainsKey(pizza.Id);
                if (isPizzaAlreadyPresent)
                {
                    cart[pizza.Id].Quantity += 1;
                }
                else
                {
                    CartPizza cartPizza = new CartPizza();
                    cartPizza.Id = pizza.Id;
                    cartPizza.Name = pizza.Name;
                    cartPizza.Price = pizza.Price;
                    cartPizza.Quantity = 1;
                    cart.Add(pizza.Id, cartPizza);
                    
                }
                result = true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return result;
        }
        public bool RemoveFromCart(int id)
        {
            bool result = false;
            try
            {
                var isPizzaAlreadyPresent = cart.ContainsKey(id);
                if (isPizzaAlreadyPresent)
                {
                    cart.Remove(id);
                    result = true;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return result;
        }
        public void ClearCart()
        {
            cart.Clear();
        }
        public ICollection<CartPizza> GetCart()
        {
            return cart.Values;
        }
    }
}
