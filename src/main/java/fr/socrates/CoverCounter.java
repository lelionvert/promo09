package fr.socrates;

import java.util.List;

class CoverCounter {
    long countVegetarianCover(List<Cover> covers) {
        return covers.stream().filter(Cover::isVegetarian).count();
    }
}
