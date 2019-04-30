package fr.socrates;

import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

public class CountDietTest {

    @Test
    public void one_vegetarian_in_one_meal_should_return_one_vegetarian() {
        CoverCounter coverCounter = new CoverCounter();
        Cover vegetarianCover = new Cover("vegetarian");
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarianCover);

        long vegetarianCoverCount = coverCounter.countVegetarianCover(covers);

        long vegetarianMealExpectedCount = 1;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void one_vegetarian_and_one_no_vegetarian_in_one_meal_should_return_one_vegetarian() {
        CoverCounter coverCounter = new CoverCounter();
        Cover vegetarianCover = new Cover("vegetarian");
        Cover pescatarianCover = new Cover("pescatarian");
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarianCover);
        covers.add(pescatarianCover);

        long vegetarianCoverCount = coverCounter.countVegetarianCover(covers);

        long vegetarianMealExpectedCount = 1;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }

    @Test
    public void two_vegetarian_and_one_no_vegetarian_in_one_meal_should_return_2() {
        CoverCounter coverCounter = new CoverCounter();
        Cover vegetarianCover = new Cover("vegetarian");
        Cover vegetarianCover2 = new Cover("vegetarian");
        Cover pescatarianCover = new Cover("pescatarian");
        List<Cover> covers = new ArrayList<>();
        covers.add(vegetarianCover);
        covers.add(pescatarianCover);
        covers.add(vegetarianCover2);

        long vegetarianCoverCount = coverCounter.countVegetarianCover(covers);

        long vegetarianMealExpectedCount = 2;
        assertThat(vegetarianCoverCount).isEqualTo(vegetarianMealExpectedCount);
    }
}
