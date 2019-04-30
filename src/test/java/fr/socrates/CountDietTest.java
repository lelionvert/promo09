package fr.socrates;

import org.junit.Test;

import java.time.DayOfWeek;
import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

public class CountDietTest {

    private Cover pescatarian = new Cover(DietType.PESCATARIAN);
    private Cover vegan = new Cover(DietType.VEGAN);
    private Cover vegetarian = new Cover(DietType.VEGETARIAN);
    private Cover omnivorous = new Cover(DietType.OMNIVOROUS);

    @Test
    public void one_vegetarian_in_one_meal_should_return_one_vegetarian() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);
        Meal meal = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);

        long vegetarianCoverCount = meal.countForDiet(DietType.VEGETARIAN);

        long vegetarianMealExpectedCount = 1;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void one_vegetarian_and_one_no_vegetarian_in_one_meal_should_return_one_vegetarian() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);
        covers.add(pescatarian);
        Meal meal = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);

        long vegetarianCoverCount = meal.countForDiet(DietType.VEGETARIAN);

        long vegetarianMealExpectedCount = 1;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void two_vegetarian_and_one_no_vegetarian_in_one_meal_should_return_2() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);
        covers.add(vegetarian);
        covers.add(pescatarian);
        Meal meal = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);

        long vegetarianCoverCount = meal.countForDiet(DietType.VEGETARIAN);

        long vegetarianMealExpectedCount = 2;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void one_pescatarian_in_one_meal_should_return_one() {
        List<Cover> covers = new ArrayList<>();
        covers.add(pescatarian);
        Meal meal = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);

        long pescatarianCoverCount = meal.countForDiet(DietType.PESCATARIAN);

        long pescatarianCoverCountExpected = 1;
        assertThat(pescatarianCoverCount).isEqualTo(pescatarianCoverCountExpected);
    }

    @Test
    public void two_pescatarian_and_one_vegetarian_in_one_meal_should_return_2() {
        List<Cover> covers = new ArrayList<>();
        covers.add(pescatarian);
        covers.add(pescatarian);
        covers.add(vegetarian);
        Meal meal = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);

        long pescatarianCoverCount = meal.countForDiet(DietType.PESCATARIAN);

        long pescatarianCoverCountExpected = 2;
        assertThat(pescatarianCoverCount).isEqualTo(pescatarianCoverCountExpected);
    }

    @Test
    public void one_vegan_in_one_meal_should_return_one() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegan);
        Meal meal = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);

        long veganCoverCount = meal.countForDiet(DietType.VEGAN);

        long veganCoverCountExpected = 1;
        assertThat(veganCoverCount).isEqualTo(veganCoverCountExpected);
    }

    @Test
    public void two_vegan_and_2_pescatarian_in_one_meal_should_return_2() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegan);
        covers.add(vegan);
        covers.add(pescatarian);
        covers.add(pescatarian);
        Meal meal = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);

        long veganCoverCount = meal.countForDiet(DietType.VEGAN);

        long veganCoverCountExpected = 2;
        assertThat(veganCoverCount).isEqualTo(veganCoverCountExpected);
    }

    @Test
    public void one_omnivorous_in_one_meal_should_return_1() {
        List<Cover> covers = new ArrayList<>();
        covers.add(omnivorous);
        Meal meal = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);

        long omnivorousCoverCount = meal.countForDiet(DietType.OMNIVOROUS);

        long omnivorousCoverCountExpected = 1;
        assertThat(omnivorousCoverCount).isEqualTo(omnivorousCoverCountExpected);
    }

    @Test
    public void three_omnivorous_and_one_vegan_in_one_meal_should_return_three() {
        List<Cover> covers = new ArrayList<>();
        covers.add(omnivorous);
        covers.add(omnivorous);
        covers.add(omnivorous);
        covers.add(vegan);
        Meal meal = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);

        long omnivorousCoverCount = meal.countForDiet(DietType.OMNIVOROUS);

        long omnivorousCoverCountExpected = 3;
        assertThat(omnivorousCoverCount).isEqualTo(omnivorousCoverCountExpected);
    }

    @Test
    public void two_meals_with_one_vegetarian_in_each_should_return_two_vegetarian_meals_for_the_event() {
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarian);
        Meal meal1 = new Meal(covers, DayOfWeek.THURSDAY, MealType.DINNER);
        Meal meal2 = new Meal(covers, DayOfWeek.FRIDAY, MealType.LUNCH);
        Meals meals = new Meals(meal1, meal2);

        MealRepartitions repartitions = meals.computeMealsRepartitions();
        long vegetarianCoverCountInMeal = repartitions.getTotalCoverForDiet(DietType.VEGETARIAN);

        long vegetarianMealCountExpected = 2;
        assertThat(vegetarianCoverCountInMeal).isEqualTo(vegetarianMealCountExpected);
    }
}
