package fr.socrates;

import java.util.List;

class CoverCounter {

    private List<Cover> covers;

    CoverCounter(List<Cover> covers) {
        this.covers = covers;
    }

    long countForDiet(DietType dietType) {
        return this.covers.stream().filter(cover -> cover.hasDietType(dietType)).count();
    }
}
