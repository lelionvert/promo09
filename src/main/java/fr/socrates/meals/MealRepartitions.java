package fr.socrates.meals;

import java.util.List;

public class MealRepartitions {
    private List<MealRepartition> repartitions;

    MealRepartitions(List<MealRepartition> repartitions) {
        this.repartitions = repartitions;
    }

    public long getTotalCoverForDiet(DietType type) {
        return repartitions.stream().mapToLong(repartition -> repartition.getCoverCountForDiet(type)).sum();
    }
}
