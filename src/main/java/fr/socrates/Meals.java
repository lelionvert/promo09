package fr.socrates;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Meals {
    private final List<Meal> meals;

    public Meals(Meal... meals) {
        this.meals = Arrays.asList(meals);
    }

    public MealRepartitions computeMealsRepartitions() {
        List<MealRepartition> repartitions = new ArrayList<>();

        for (Meal meal : meals) {
            MealRepartition repartition = MealRepartition.computeRepartitionForMeal(meal);
            repartitions.add(repartition);
        }

        return new MealRepartitions(repartitions);
    }
}
