using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using SocratesFrance;

namespace SocratesFranceTest
{
    [TestClass]
    public class ColdMealTest
    {
        readonly DateTime COLD_MEAL_SERVING_TIME = new DateTime(2019, 4, 25, 21, 0, 0);
        readonly DateTime KITCHEN_CLOSING_TIME = new DateTime(2019, 4, 26, 0, 0, 0);

        [TestMethod]
        public void NoCheckInGivesNoColdMeal()
        {
            DayHours checkIns = new DayHours();

            ColdMeals coldMeals = new ColdMeals(new DayHour(COLD_MEAL_SERVING_TIME),checkIns);
            int coldMealsCount = coldMeals.Count();

            coldMealsCount.Should().Be(0);
        }

        [TestMethod]
        public void OneCheckInBeforeColdMealServingTimeGivesNoColdMeal()
        {
            DayHours beforeColdMealServingTimeCheckIns = GenerateCheckInsBeforeColdMealServingTime(1);

            ColdMeals coldMeals = new ColdMeals(new DayHour(COLD_MEAL_SERVING_TIME), beforeColdMealServingTimeCheckIns);
            int coldMealsCount = coldMeals.Count();

            coldMealsCount.Should().Be(0);
        }

        [TestMethod]
        public void OneCheckInAtColdMealServingTimeGivesOneColdMeal()
        {
            DayHour checkInAtColdMealServingTime = new DayHour(this.COLD_MEAL_SERVING_TIME);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkInAtColdMealServingTime);

            ColdMeals coldMeals = new ColdMeals(new DayHour(this.COLD_MEAL_SERVING_TIME), checkIns);
            int coldMealsCount = coldMeals.Count();

            coldMealsCount.Should().Be(1);
        }

        [TestMethod]
        public void OneCheckInAfterColdMealServingTimeGivesOneColdMeal()
        {
            DayHours checkIns = GenerateCheckInsAfterColdMealServingTime(1);

            ColdMeals coldMeals = new ColdMeals(new DayHour(this.COLD_MEAL_SERVING_TIME), checkIns);
            int coldMealsCount = coldMeals.Count();

            coldMealsCount.Should().Be(checkIns.Count());
        }

        [TestMethod]
        public void OneCheckInAtKitchenClosingTimeGivesNoColdMeal()
        {
            DayHour checkInAtKitchenClosingTime = new DayHour(this.KITCHEN_CLOSING_TIME);
            DayHours checkIns = new DayHours();
            checkIns.Add(checkInAtKitchenClosingTime);

            ColdMeals coldMeals = new ColdMeals(new DayHour(this.COLD_MEAL_SERVING_TIME), checkIns);
            int coldMealCount = coldMeals.Count();

            coldMealCount.Should().Be(0);
        }

        [TestMethod]
        public void OneCheckInAtColdMealServingTimeAndOneBeforeGivesOneColdMeal()
        {
            DayHours checkIns = GenerateCheckInsBeforeColdMealServingTime(1);
            DayHour checkInAtColdMealServingTime = new DayHour(this.COLD_MEAL_SERVING_TIME);
            checkIns.Add(checkInAtColdMealServingTime);

            ColdMeals coldMeals = new ColdMeals(new DayHour(this.COLD_MEAL_SERVING_TIME), checkIns);
            int coldMealsCount = coldMeals.Count();

            coldMealsCount.Should().Be(1);
        }

        [TestMethod]
        public void OneCheckInBeforeColdMealServingTimeAndOneAfterGivesOneColdMeal()
        {
            DayHours mixedTimeCheckIns = new DayHours();
            DayHours afterColdMealServingTimeCheckIns = GenerateCheckInsAfterColdMealServingTime(1);

            mixedTimeCheckIns.AddAll(GenerateCheckInsBeforeColdMealServingTime(1));
            mixedTimeCheckIns.AddAll(afterColdMealServingTimeCheckIns);
            
            ColdMeals coldMeals = new ColdMeals(new DayHour(this.COLD_MEAL_SERVING_TIME), mixedTimeCheckIns);
            int coldMealsCount = coldMeals.Count();

            coldMealsCount.Should().Be(afterColdMealServingTimeCheckIns.Count());
        }

        [TestMethod]
        public void OneCheckInBeforeColdMealServingTimeAndOneCheckInTheNextDayGivesNoColdMeal()
        {
            DayHours mixedCheckIns = new DayHours(GenerateCheckInsBeforeColdMealServingTime(1), GenerateOneDayLateCheckIns(1));
           
            ColdMeals coldMeals = new ColdMeals(new DayHour(COLD_MEAL_SERVING_TIME), mixedCheckIns);
            int coldMealsCount = coldMeals.Count();
            
            coldMealsCount.Should().Be(0);
        }

        private DayHours GenerateCheckInsBeforeColdMealServingTime(int number)
        {
            DayHours checkIns = new DayHours();

            for (int i = 0; i < number; i++)
            {
                DayHour checkIn = new DayHour(this.COLD_MEAL_SERVING_TIME.AddHours(-1));
                checkIns.Add(checkIn);
            }

            return checkIns;
        }

        private DayHours GenerateCheckInsAfterColdMealServingTime(int number)
        {
            DayHours checkIns = new DayHours();

            for (int i = 0; i < number; i++)
            {
                DayHour checkIn = new DayHour(this.COLD_MEAL_SERVING_TIME.AddHours(1));
                checkIns.Add(checkIn);
            }

            return checkIns;
        }

        private DayHours GenerateOneDayLateCheckIns(int number)
        {
            DayHours checkIns = new DayHours();

            for (int i = 0; i < number; i++)
            {
                DayHour checkIn = new DayHour(this.COLD_MEAL_SERVING_TIME.AddDays(1));
                checkIns.Add(checkIn);
            }

            return checkIns;
        }
    }
}
