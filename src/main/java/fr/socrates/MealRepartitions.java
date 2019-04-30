package fr.socrates;

import java.util.List;

public class MealRepartitions {
    List<MealRepartition> repartitions;

    public MealRepartitions(List<MealRepartition> repartitions) {
        this.repartitions = repartitions;
    }

    public long getTotalCoverForDiet(DietType type) {
        return repartitions.stream().mapToLong(repartition -> repartition.getCoverCountForDiet(type)).sum();
    }
}
