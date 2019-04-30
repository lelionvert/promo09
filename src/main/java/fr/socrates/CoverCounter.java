package fr.socrates;

import java.util.List;

class CoverCounter {
    long countForDiet(List<Cover> covers, DietType dietType) {
        return covers.stream().filter(cover -> cover.hasDietType(dietType)).count();
    }
}
