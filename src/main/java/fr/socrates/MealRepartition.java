package fr.socrates;

import java.util.HashMap;
import java.util.Map;

public class MealRepartition {
    private Map<DietType, Long> repartition;

    private MealRepartition(Map<DietType, Long> repartition) {
        this.repartition = repartition;
    }

    public static MealRepartition computeRepartitionForMeal(Meal meal) {
        Map<DietType, Long> repartition = new HashMap<>();

        for (DietType type : DietType.values()) {
            repartition.put(type, meal.countForDiet(type));
        }

        return new MealRepartition(repartition);
    }

    public long getCoverCountForDiet(DietType dietType) {
        return repartition.get(dietType);
    }
}
