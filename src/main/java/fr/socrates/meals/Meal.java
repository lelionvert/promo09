package fr.socrates.meals;

import java.util.List;

public class Meal {
    private List<Cover> covers;

    public Meal(List<Cover> covers) {
        this.covers = covers;
    }

    long countForDiet(DietType dietType) {
        return this.covers.stream().filter(cover -> cover.hasDietType(dietType)).count();
    }
}
