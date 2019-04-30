package fr.socrates;

import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Meals {
    private final List<Meal> meals;

    public Meals(Meal... meals) {
        this.meals = Arrays.asList(meals);
    }

    public Map<Meal, Map<DietType, Long>> computeMealsChoices() {
        Map<Meal, Map<DietType, Long>> result = new HashMap<>();

        for (Meal meal : meals) {
            Map<DietType, Long> mealChoices = new HashMap<>();

            mealChoices.put(DietType.VEGETARIAN, meal.countForDiet(DietType.VEGETARIAN));
            mealChoices.put(DietType.VEGAN, meal.countForDiet(DietType.VEGAN));
            mealChoices.put(DietType.OMNIVOROUS, meal.countForDiet(DietType.OMNIVOROUS));
            mealChoices.put(DietType.PESCATARIAN, meal.countForDiet(DietType.PESCATARIAN));

            result.put(meal, mealChoices);
        }

        return result;
    }
}
