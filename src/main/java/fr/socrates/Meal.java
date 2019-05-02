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

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Meal meal = (Meal) o;

        if (covers != null ? !covers.equals(meal.covers) : meal.covers != null) return false;
        if (mealType != meal.mealType) return false;
        return dayOfWeek == meal.dayOfWeek;
    }

    @Override
    public int hashCode() {
        int result = covers != null ? covers.hashCode() : 0;
        result = 31 * result + (mealType != null ? mealType.hashCode() : 0);
        result = 31 * result + (dayOfWeek != null ? dayOfWeek.hashCode() : 0);
        return result;
    }
}
