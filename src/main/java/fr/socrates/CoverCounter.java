package fr.socrates;

import java.util.List;

class CoverCounter {
    long countVegetarianCover(List<Cover> covers) {
        return covers.stream().filter(Cover::isVegetarian).count();
    }

    long countPescatarian(List<Cover> covers) {
        return covers.stream().filter(Cover::isPescatarian).count();
    }
}
