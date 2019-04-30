package fr.socrates;

import java.time.DayOfWeek;
import java.util.List;

class Meal {
    private List<Cover> covers;
    private final MealType mealType;
    private final DayOfWeek dayOfWeek;

    Meal(List<Cover> covers, DayOfWeek dayOfWeek, MealType mealType) {
        this.covers = covers;
        this.mealType = mealType;
        this.dayOfWeek = dayOfWeek;
    }

    long countForDiet(DietType dietType) {
        return this.covers.stream().filter(cover -> cover.hasDietType(dietType)).count();
    }
}
