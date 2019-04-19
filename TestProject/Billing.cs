﻿using System;
using System.Collections.Generic;

namespace SocratesFrance
{
    public class Billing
    {
        Priceable meal;
        Dictionary<Product, int> catalog;

        public Billing(Priceable meal)
        {
            this.meal = meal;
            this.InitializeCatalog();
        }

        public Billing()
        {
            this.InitializeCatalog();
        }

        private void InitializeCatalog()
        {
            catalog = new Dictionary<Product, int>
            {
                {ConsumableProduct.MEAL, 40},
                {Room.SINGLE_ACCOMMODATION, 610},
                {Room.DOUBLE_ACCOMMODATION, 510},
                {Room.TRIPLE_ACCOMMODATION, 410},
                {Room.NO_ACCOMMODATION, 240}
            };
        }

        public int ComputeTotalPriceForRegistration(Registration registration, int mealCount)
        {
            return GetPriceFor(registration.Accommodation) + 
                mealCount * GetPriceFor(ConsumableProduct.MEAL);
        }

        private int GetPriceFor(Product product)
        {
            return catalog[product];
        }
    }
}
